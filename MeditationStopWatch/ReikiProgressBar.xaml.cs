﻿using System;
using System.Media;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Timers;
using System.ComponentModel;
using System.Windows.Resources;
using System.IO;
using MeditationStopWatch;
using System.Runtime.CompilerServices;
using System.Windows.Shapes;

namespace ReiKi
{
    /// <summary>
    /// Interaction logic for ReikiProgressBar.xaml
    /// </summary>
    public partial class ReikiProgressBar : UserControl, INotifyPropertyChanged
    {
        private Timer m_Timer = new Timer(300);
        private DateTime m_LastTime = DateTime.Now;
        private TimeSpan m_ElapsedTime = TimeSpan.FromSeconds(0);
        private bool m_bPaused = false;
        private bool m_bSoundPlayed;
        //private SoundPlayer m_SoundPlayer;
        private MCIPLayer m_SoundPlayer = new MCIPLayer();
        private string m_sExePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private Options _options;

        [Serializable]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ReiKiSettings
        {
            [Browsable(false)]
            [DefaultValue(180.0)]
            public double ProgressInterval { get; set; } = 180.0;

            [Browsable(false)]
            public bool BellAtTheEnd { get; set; } = false;
        }

        private double ProgressInterval { get; set; }
        private bool BellAtTheEnd { get; set; }

        private ReiKiSettings Settings
        {
            get
            {
                if(_options.PlayListCollection.SelectedPlayList != null)
                    return _options.PlayListCollection.SelectedPlayList.ReiKiSettings;
                return new ReiKiSettings();
            }
        }

        public ReikiProgressBar()
        {
            InitializeComponent();
			
			chkBell3min.IsChecked = true;
			mnuBellOnOff.IsChecked = true;
            chkBellAtTheEnd.IsChecked = true;

            m_Timer.Enabled = false;
            m_Timer.Elapsed += m_Timer_Elapsed;
        }

        public void PlayDing()
        {
            string sName = System.IO.Path.Combine(m_sExePath, "Sounds", "ding.mp3");
            m_SoundPlayer.Play(sName, "ding");
            m_SoundPlayer.SetVolume(_options.Volume);
        }

        private void UpdateTooltip(double secondsLeft)
        {
            this.Dispatcher.BeginInvoke((Action)(() =>
            {
                const string FMT = @"m\:ss"; // @"hh\:mm\:ss"

                string interval = TimeSpan.FromSeconds(Settings.ProgressInterval).ToString(FMT);
                string value = TimeSpan.FromSeconds(secondsLeft).ToString(FMT);

                if (Max > 10)
                {
                    this.ToolTip = string.Format("Bell: {0}, Interval: {1:0} Time Left: {2:0}",
                        Settings.BellAtTheEnd ? "On" : "Off", interval, value);
                }
                else
                {
                    this.ToolTip = "None";
                }
            }));
        }

		private void m_Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            m_Timer.Stop();

            DateTime now = DateTime.Now;
            if (!m_bPaused)
                m_ElapsedTime += (now - m_LastTime);
            m_LastTime = now;

            if (Max > 10)
            {
                Value = m_ElapsedTime.TotalSeconds % Max;

                if (Settings.BellAtTheEnd && Max - Value < 2 && !m_bSoundPlayed)
                {
                    m_bSoundPlayed = true;
                    PlayDing();
                }

                if (Max - Value > 5)
                    m_bSoundPlayed = false;
            }
            else
            {
                Value = 0;
            }

            UpdateTooltip(Max - Value);

            m_Timer.Start();
        }

        private double _value;
        public double Value
        {
            get { return _value; }
            set { _value = value;  OnPropertyChanged(); }
        }

		public double Max
		{
			get 
			{ 
				if (_options == null) 
					return 180; 
				return Settings.ProgressInterval; 
			}
			set 
			{
                Settings.ProgressInterval = value;
                DrawTicks();

                OnPropertyChanged(); 
			}
		}

        public void Initialize(Options options)
        {
            if (options == null)
                return;

            _options = options;

            mnuBellOnOff.IsChecked = Settings.BellAtTheEnd;
            chkBellAtTheEnd.IsChecked = Settings.BellAtTheEnd;
            InitInterval();
            OnPropertyChanged("Max");
        }
        
        public void Start()
        {
            m_LastTime = DateTime.Now;
            m_ElapsedTime = TimeSpan.FromSeconds(0);
            m_bPaused = false;

            Value = 0;
            m_Timer.Enabled = true;
        }

        public void Pause()
        {
            m_bPaused = true;
            PlayDing();
        }

        public void Resume()
        {
            m_bPaused = false;
        }
        
        public void Stop()
        {
            m_Timer.Enabled = false;
            m_bPaused = false;
            Value = 0;
        }

        #region INotifyPropertyChanged Members


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private void OnStart(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void OnStop(object sender, RoutedEventArgs e)
        {
            Stop();
        }

		private void OnBellOnOffClicked(object sender, RoutedEventArgs e)
		{
            if (e.Source is MenuItem)
            {
                mnuBellOnOff.IsChecked = !mnuBellOnOff.IsChecked;
                if (_options != null)
                    Settings.BellAtTheEnd = mnuBellOnOff.IsChecked;

                chkBellAtTheEnd.IsChecked = mnuBellOnOff.IsChecked;
            }
            if(e.Source is CheckBox)
            {
                if (_options != null)
                    Settings.BellAtTheEnd = chkBellAtTheEnd.IsChecked.Value;

                mnuBellOnOff.IsChecked = chkBellAtTheEnd.IsChecked.Value;
            }
        }

		private void OnBellIntervalClicked(object sender, RoutedEventArgs e)
		{
			SetInterval(e.Source as MenuItem);
		}

		private void SetInterval(MenuItem mnuClicked)
		{
            SetInterval(mnuClicked, chkNoProgress, 1);
            SetInterval(mnuClicked, chkBell1min, 60);
            SetInterval(mnuClicked, chkBell2min, 120);
            SetInterval(mnuClicked, chkBell3min, 180);
			SetInterval(mnuClicked, chkBell4min, 240);
			SetInterval(mnuClicked, chkBell5min, 300);
		}

		private void SetInterval(MenuItem mnuClicked, MenuItem mnuInterval, int iTimeout)
		{
			if (mnuClicked.Name == mnuInterval.Name)
			{
				mnuInterval.IsChecked = true;
				Max = iTimeout;
			}
			else
			{
				mnuInterval.IsChecked = false;
			}
		}

		private void InitInterval()
		{
            if (Settings.ProgressInterval < 31)
                SetInterval(chkNoProgress);
            else if (Settings.ProgressInterval > 30 && Settings.ProgressInterval < 61)
                SetInterval(chkBell1min);
            else if (Settings.ProgressInterval > 60 && Settings.ProgressInterval < 121)
                SetInterval(chkBell2min);
            else if (Settings.ProgressInterval > 120 && Settings.ProgressInterval < 181)
				SetInterval(chkBell3min);
			else if (Settings.ProgressInterval > 180 && Settings.ProgressInterval < 241)
				SetInterval(chkBell4min);
			else if (Settings.ProgressInterval > 240)
				SetInterval(chkBell5min);
			else //default
				SetInterval(chkBell3min);
		}

        private void DrawTicks()
        {
            _canvas.Children.Clear();
            double line_count = Max;  //(Max / 30.0); //line per 30 sec
            double line_offset = (_canvas.ActualWidth-3) / line_count;
            double smallDelta = _canvas.ActualHeight / 10;
            double bigDelta = _canvas.ActualHeight / 4;

            for (int i = 0; i < line_count + 1; i++)
            {
                double thickness = -1;
                double delta = bigDelta;

                if (i % 10 == 0)
                {
                    thickness = 0.5;
                    delta = bigDelta;
                }
                if (i % 30 == 0)
                {
                    thickness = 2;
                    delta = bigDelta;
                }
                if (i % 60 == 0)
                {
                    thickness = 2;
                    delta = smallDelta;
                }
                if (thickness < 0)
                    continue;

                Line line = new Line();
                line.Stroke = System.Windows.Media.Brushes.Green;
                line.StrokeThickness = thickness;
                line.X1 = 1 + i * line_offset;
                line.X2 = line.X1;
                line.Y1 = delta;
                line.Y2 = _canvas.ActualHeight - delta;

                _canvas.Children.Add(line);
            }
        }

        private void ReiKi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Start();
        }

        private void ReiKi_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawTicks();
        }
    }
}
