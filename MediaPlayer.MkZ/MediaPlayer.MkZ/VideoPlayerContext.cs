﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using MkZ.MediaPlayer.Utils;
using MkZ.Windows;
using MkZ.WPF;

namespace MkZ.MediaPlayer
{
    public class VideoPlayerContext : NotifyPropertyChangedImpl
    {
        public static VideoPlayerContext Instance { get; } = new VideoPlayerContext() { InDesignMode = WPFUtils.GetInDesignMode() };

        public static double CursorHeight { get { return Application.Current.MainWindow.ActualHeight / 20; } }
        public static double ToolTipFontSize { get { return Application.Current.MainWindow.ActualHeight / 40; } }
        public static Brush ToolTipForeground { get { return Application.Current.MainWindow.Background; } }

        public AppConfig Config { get; } = new AppConfig();

        public VideoPlayerControlVM PlayerVM { get; set; } = null;
        public bool InDesignMode { get; set; }

        public MediaPlayerCommands MediaPlayerCommands { get; set; } = null;

        public void AddNewMediaFiles(PlayList playList, string[] fileNames, double volume)
        {
            List<string> unsupported = new List<string>();
            int index = -1, count = 0;
            foreach (string fileName in fileNames)
            {
                if (Config.Configuration.IsSupportedImageFile(fileName))
                {
                    Config.Configuration.BackgroundImageFileName = fileName;
                }
                else if (Config.Configuration.IsSupportedMediaFile(fileName))
                {
                    count++;
                    index = playList.AddNewMediaFile(fileName, volume);
                }
                else
                {
                    unsupported.Add(fileName);
                }
            }

            if (unsupported.Count > 0)
                MessageBox.Show("File type is not supported.\n" + unsupported[0], "AddNewMediaFiles");
        }
    }
}
