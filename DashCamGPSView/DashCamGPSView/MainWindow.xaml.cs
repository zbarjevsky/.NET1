﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

using DashCamGPSView.Properties;
using DashCamGPSView.Tools;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using GPSDataParser;

namespace DashCamGPSView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool mediaPlayerIsPlaying = false;
        private bool mediaPlayerIsPaused = false;
        private bool userIsDraggingSlider = false;

        private DashCamFileInfo _dashCamFileInfo;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            playerF.Volume = Settings.Default.SoundVolume;

            treeGroups.TreeItemDoubleClickAction = (fileName) => 
            {
                PlayFile(fileName);
            };

            treeGroups.OpenFileAction = () =>
            {
                OpenVideoFile();
            };

            treeGroups.ExportGPSAction = (infos) =>
            {
                ExportGPSData(infos);
            };

            playerF.VideoStarted = () => { waitScreen.Visibility = Visibility.Collapsed; };

            playerF.VideoEnded = () => { if (chkAutoPlay.IsChecked.Value) PlayNext(); };
            
            waitScreen.Visibility = Visibility.Visible;
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
            {
                if (!mediaPlayerIsPlaying)
                    return;

                if (mediaPlayerIsPaused)
                    Play_Executed(this, null);
                else
                    Pause_Executed(this, null);
            }
            else if (e.Key == Key.Up || e.Key == Key.VolumeUp)
            {
                playerF.Volume += 0.1 * playerF.Volume;
            }
            else if (e.Key == Key.Down || e.Key == Key.VolumeDown)
            {
                playerF.Volume -= 0.1 * playerF.Volume;
            }
            else if (e.Key == Key.Left)
            {
                sliProgress.Value -= sliProgress.SmallChange;
            }
            else if (e.Key == Key.Right)
            {
                sliProgress.Value += sliProgress.SmallChange;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left = Settings.Default.InitialLocation.X;
            this.Top = Settings.Default.InitialLocation.Y;
            this.WindowState = WindowState.Maximized;

            //waitScreen.Visibility = Visibility.Collapsed;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ClosePayer();
            Settings.Default.SoundVolume = playerF.Volume;
            Settings.Default.InitialLocation = new System.Drawing.Point((int)this.Left, (int)this.Top);
            Settings.Default.Save();
        }

        private bool _bMapWasCollapsed = false;
        private void PlayFile(string fileName, double startFrom = 0)
        {
            string prev = treeGroups.FindPrevFile(fileName);
            if(_dashCamFileInfo != null && prev != _dashCamFileInfo.FrontFileName)
            {
                MainMap.SetRouteAndCar(null); //reset route 
            }

            gpsInfo.UpdateInfo(null); //reset GPS Info control

            treeGroups.SelectFile(fileName);

            _dashCamFileInfo = new DashCamFileInfo(fileName);

            txtFileName.Text = _dashCamFileInfo.FrontFileName;
            playerF.Open(_dashCamFileInfo.FrontFileName, playerF.Volume);
            playerR.Open(_dashCamFileInfo.BackFileName, 0);

            if (_dashCamFileInfo.GpsInfo != null && _dashCamFileInfo.GpsInfo.Count > 0)
            {
                MainMap.SetRouteAndCar(_dashCamFileInfo);
                UpdateGpsInfo();

                if (_bMapWasCollapsed)// && mapColumn.Width.Value < 300)
                {
                    _bMapWasCollapsed = false;
                    MainMap.Zoom = 17;
                    GridLengthAnimation.AnimateColumn(mapColumn, mapColumn.Width, 500);
                }
            }
            else //no GPS info
            {
                //MainMap.Position = new PointLatLng(first.Latitude, first.Longitude);
                if (!_bMapWasCollapsed)// && mapColumn.Width.Value > 300)
                {
                    _bMapWasCollapsed = true;
                    MainMap.Zoom = 2;
                    GridLengthAnimation.AnimateColumn(mapColumn, mapColumn.Width, 0);
                }
            }

            playerF.Play();
            playerR.Play();

            if(startFrom > 1)
            {
                sliProgress.Value = startFrom;
                sliProgress_ValueChanged(sliProgress, null);
            }

            mediaPlayerIsPlaying = true;
            mediaPlayerIsPaused = false;
        }

        private void ClosePayer()
        {
            playerF.Close();
            playerR.Close();
            mediaPlayerIsPlaying = false;
            mediaPlayerIsPaused = false;
            MainMap.SetRouteAndCar(null);
        }

        private void PlayNext()
        {
            string fileName = treeGroups.FindNextFile(_dashCamFileInfo.FrontFileName);
            if (!File.Exists(fileName))
                return;

            PlayFile(fileName);
        }

        private void PlayPrev()
        {
            string fileName = treeGroups.FindPrevFile(_dashCamFileInfo.FrontFileName);
            if (!File.Exists(fileName))
              return;

            PlayFile(fileName);
        }

        private void OpenVideoFile()
        {
            waitScreen.Visibility = Visibility.Visible;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.mp3;*.mp4;*.mpg;*.mpeg)|*.mp3;*.mp4;*.mpg;*.mpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                DashCamFileTree groups = new DashCamFileTree(openFileDialog.FileName);
                treeGroups.LoadTree(groups, openFileDialog.FileName);

                MainMap.SetRouteAndCar(null); //reset

                PlayFile(openFileDialog.FileName);
                
                playerF.FitWidth();
                playerR.FitWidth();

                if (_dashCamFileInfo.GpsInfo != null && _dashCamFileInfo.GpsInfo.Count > 0)
                    MainMap.Zoom = 17;
            }
        }

        private void ExportGPSData(List<DashCamFileInfo> infos)
        {
            if (infos == null || infos.Count == 0)
                return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Google GPS Format (KML) (*.kml)|*.kml|GPS Exchange Format (GPX) (*.gpx)|*.gpx";
            saveFileDialog.FilterIndex = 1;
            string baseFileName = System.IO.Path.GetFileNameWithoutExtension(infos[0].FrontFileName);
            saveFileDialog.FileName = string.Format("TrackData_{0}.kml", baseFileName);

            if (saveFileDialog.ShowDialog() == true)
            {
                List<GpsPointData> list = new List<GpsPointData>();
                foreach (DashCamFileInfo info in infos)
                {
                    if(info.GpsInfo != null && info.GpsInfo.Count > 0)
                        list.AddRange(info.GpsInfo);
                }
                try
                {
                    ExportUtils.SaveGPSData(list, saveFileDialog.FileName);
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, err.Message, "Error");
                }            
            }
        }

        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenVideoFile();
        }

        private void Next_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            string fileName = null;
            if (_dashCamFileInfo != null)
                fileName = treeGroups.FindNextFile(_dashCamFileInfo.FrontFileName);

            e.CanExecute = !string.IsNullOrWhiteSpace(fileName);
        }

        private void Next_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PlayNext();
        }

        private void Prev_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            string fileName = null;
            if (_dashCamFileInfo != null)
                fileName = treeGroups.FindPrevFile(_dashCamFileInfo.FrontFileName);

            e.CanExecute = !string.IsNullOrWhiteSpace(fileName);
        }

        private void Prev_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PlayPrev();
        }

        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = playerF.Play_CanExecute;
        }

        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            playerF.Play();
            playerR.Play();

            mediaPlayerIsPlaying = true;
            mediaPlayerIsPaused = false;
        }

        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying && !mediaPlayerIsPaused;
        }

        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            playerF.Pause();
            playerR.Pause();

            mediaPlayerIsPaused = true;
        }

        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            playerF.Stop();
            playerR.Stop();
            mediaPlayerIsPlaying = false;
            mediaPlayerIsPaused = false;
        }

        private void sliProgress_DragStarted(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
            Pause_Executed(sender, null);
        }

        private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            //playerF.Position = TimeSpan.FromSeconds(sliProgress.Value);
            //playerR.Position = TimeSpan.FromSeconds(sliProgress.Value);
            //UpdateGpsInfo();
        }

        private void sliProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan tsPos = TimeSpan.FromSeconds(sliProgress.Value);
            TimeSpan tsMax = TimeSpan.FromSeconds(playerF.NaturalDuration);

            playerF.Position = tsPos;
            playerR.Position = tsPos;
            
            lblProgressStatus.Text = tsPos.ToString(@"hh\:mm\:ss") + "/" + tsMax.ToString(@"hh\:mm\:ss");

            UpdateGpsInfo();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!mediaPlayerIsPlaying || mediaPlayerIsPaused || userIsDraggingSlider)
                return;

            UpdateGpsInfo();
        }

        private void UpdateGpsInfo()
        {
            if (_dashCamFileInfo == null)
                return;

            sliProgress.Minimum = 0;

            if (playerF.NaturalDuration != 0)
            {
                sliProgress.Maximum = playerF.NaturalDuration;
                sliProgress.Value = playerF.Position.TotalSeconds;
                if (sliProgress.Maximum >= 60)
                    sliProgress.SmallChange = 1;
                else //if less than minute - have 60 tics
                    sliProgress.SmallChange = sliProgress.Maximum / 60.0;

                sliProgress.LargeChange = sliProgress.Maximum / 10.0;
            }

            txtGPSInfo.Text = _dashCamFileInfo.GetLocationInfoForTime(playerF.Position.TotalSeconds);

            int idx = _dashCamFileInfo.FindGpsInfo(playerF.Position.TotalSeconds);
            if (_dashCamFileInfo.GpsInfo != null && _dashCamFileInfo.GpsInfo.Count > idx)
            {
                gpsInfo.UpdateInfo(_dashCamFileInfo.GpsInfo[idx], _dashCamFileInfo.TimeZone);
                
                PointLatLng currentPosition = new PointLatLng(_dashCamFileInfo.GpsInfo[idx].Latitude, _dashCamFileInfo.GpsInfo[idx].Longitude);
                MainMap.UpdateRouteAndCar(currentPosition, idx);
            }
        }

        private void GridSplitter1_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            playerF.FitWidth();
            playerR.FitWidth();
        }

        private void Screenshot_Click(object sender, RoutedEventArgs e)
        {
            string fileName = @"C:\Temp\Screenshot.png";
            if (_dashCamFileInfo != null)
                fileName = _dashCamFileInfo.GetScreenshotFileName();

            fileName = string.Format("{0}_at{1:0.00}.png", fileName, playerF.Position.TotalSeconds);
            Tools.Tools.SaveWindowScreenshotToFile(this, fileName);
            Process.Start(fileName);
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            playerF.RecreateMediaElement();
            if (_dashCamFileInfo != null)
                PlayFile(_dashCamFileInfo.FrontFileName, sliProgress.Value);
        }
    }
}
