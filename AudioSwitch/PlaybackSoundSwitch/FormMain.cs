﻿using PlaybackSoundSwitch.ComObjects;
using PlaybackSoundSwitch.Device;
using PlaybackSoundSwitch.DeviceSwitch;
using PlaybackSoundSwitch.Interfaces;
using PlaybackSoundSwitch.Notifications;
using PlaybackSoundSwitch.Properties;
using PlaybackSoundSwitch.Tools;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaybackSoundSwitch
{
    public partial class FormMain : Form
    {
        private Font _fontNorm;
        private Font _fontBold;
        MMDeviceEnumerator _mmd = new MMDeviceEnumerator();
        MMDevice _activeDevice = null;

        public FormMain()
        {
            InitializeComponent();

            _fontNorm = m_listDevices.Font;
            _fontBold = new Font(_fontNorm, FontStyle.Bold);

            m_listDevices.SmallImageList = new ImageList
            {
                ImageSize = new Size(32, 32),
                ColorDepth = ColorDepth.Depth32Bit
            };

            m_imageListSpeakers.Images.AddStrip(Resources.SpeakerImgList);

            m_listDevices.SetDoubleBuffered(true);

            _mmd.DevicesChanged = OnDevicesChanged;
            _mmd.DefaultDeviceChanged = OnDefaultDeviceChanged;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            EnumDevices();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mmd.Dispose();
        }

        private void OnDevicesChanged(string deviceId = "")
        {
            EnumDevices();
        }

        private void OnDefaultDeviceChanged(MMDevice device)
        {
            EnumDevices();
        }

        private void EnumDevices()
        {
            CommonUtils.ExecuteOnUIThread(() => {
                try
                {
                    m_listDevices.Items.Clear();

                    MMDeviceCollection coll = _mmd.EnumerateAudioEndPoints(EDataFlow.Render, DeviceState.Active);
                    IReadOnlyCollection<DeviceFullInfo> devs = CreateDeviceList(coll);

                    foreach (DeviceFullInfo dev in devs)
                    {
                        AddDeviceIconSmallImage(dev);

                        Debug.WriteLine("Dev: " + dev.Name);
                        ListViewItem lvi = m_listDevices.Items.Add(dev.Name);
                        lvi.ImageKey = dev.IconPath;
                        lvi.SubItems.Add("N/A");
                        lvi.SubItems.Add("N/A");
                        lvi.Tag = dev;
                    }

                    SetActiveDeviceToBold();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }, this);
        }

        private void SetActiveDeviceToBold()
        {
            _activeDevice = _mmd.GetDefaultAudioEndpoint(EDataFlow.Render, Role.Multimedia);
            _activeDevice.AudioEndpointVolume.OnVolumeNotification = (notificationData) =>
            {
                CommonUtils.ExecuteOnUIThread(() => {
                    m_trackVolume.Value = (int)(100f * notificationData.MasterVolume);
                }
                , this);
            };

            foreach (ListViewItem item in m_listDevices.Items)
            {
                DeviceFullInfo dev = item.Tag as DeviceFullInfo;
                bool isActive = dev.Id == _activeDevice.ID;
                item.Font = isActive ? _fontBold : _fontNorm;
                item.SubItems[1].Text = isActive ? "Active" : "";
                item.Selected = false; // dev.Id == sel.ID;
            }

            m_trackVolume.Value = (int)(100f * _activeDevice.AudioEndpointVolume.MasterVolumeLevelScalar);
            UpdateUI();
        }

        private static IReadOnlyCollection<DeviceFullInfo> CreateDeviceList(MMDeviceCollection collection)
        {
            var sortedDevices = new SortedList<string, DeviceFullInfo>();
            foreach (var device in collection)
            {
                try
                {
                    MMDevice d = new MMDevice(device);
                    var deviceInfo = new DeviceFullInfo(d);
                    if (string.IsNullOrEmpty(deviceInfo.Name))
                    {
                        continue;
                    }

                    sortedDevices.Add(d.ID, deviceInfo);
                }
                catch (Exception e)
                {
                    //Log.Warning("Can't get name of device {device}", device.ID);
                    throw;
                }
            }

            return sortedDevices.Values.ToArray();
        }

        private void m_btnRefresh_Click(object sender, EventArgs e)
        {
            EnumDevices();
        }

        private void m_trackVolume_Scroll(object sender, EventArgs e)
        {
            _activeDevice.AudioEndpointVolume.MasterVolumeLevelScalar = m_trackVolume.Value / 100f;
            //SystemSounds.Beep.Play();
        }

        private void m_trackVolume_ValueChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void m_btnMute_Click(object sender, EventArgs e)
        {
            _activeDevice.AudioEndpointVolume.Mute = !_activeDevice.AudioEndpointVolume.Mute;
            UpdateUI();
        }

        private void UpdateUI()
        {
            float volume = m_trackVolume.Value / 100f;
            foreach (ListViewItem item in m_listDevices.Items)
            {
                if(item.Font.Bold)
                {
                    item.SubItems[2].Text = volume.ToString("0%");
                }
                else
                {
                    item.SubItems[2].Text = "---";
                }
            }

            if (volume >= 0.7)
                m_btnMute.ImageIndex = 0;
            else if (volume > 0.3 && volume < 0.7)
                m_btnMute.ImageIndex = 1;
            else if (volume > 0 && volume <= 0.3)
                m_btnMute.ImageIndex = 2;
            else
                m_btnMute.ImageIndex = 4;

            if (_activeDevice.AudioEndpointVolume.Mute)
                m_btnMute.ImageIndex = 3;

            if (m_listDevices.SelectedItems.Count > 0)
            {
                m_btnActivate.Enabled = (m_listDevices.SelectedItems[0].Font.Bold == false);
                m_btnActivate.Text = "Set Active: " + m_listDevices.SelectedItems[0].Text;
            }
            else
            {
                m_btnActivate.Enabled = false;
                m_btnActivate.Text = "Select Device to Activate...";
            }
        }

        private void m_listDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void m_btnActivate_Click(object sender, EventArgs e)
        {
            SetActiveDevice();
        }

        private void m_listDevices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                SetActiveDevice();
        }

        private void SetActiveDevice()
        {
            try
            {
                m_btnActivate.Enabled = false;
                if (m_listDevices.SelectedItems.Count == 0)
                    return;

                ListViewItem item = m_listDevices.SelectedItems[0];
                DeviceFullInfo audioDevice = item.Tag as DeviceFullInfo;

                SoundDeviceManager.SetActiveDevice(audioDevice);
            
                SetActiveDeviceToBold();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Using the DeviceClassIconPath, get the Icon
        /// </summary>
        /// <param name="device"></param>
        /// <param name="listView"></param>
        private void AddDeviceIconSmallImage(DeviceFullInfo device)
        {
            if (!m_listDevices.SmallImageList.Images.ContainsKey(device.IconPath))
            {
                m_listDevices.SmallImageList.Images.Add(device.IconPath, device.LargeIcon);
            }
        }
    }
}
