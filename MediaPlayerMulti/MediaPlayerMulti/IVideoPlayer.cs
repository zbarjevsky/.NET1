﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MkZ.MediaPlayer
{
    public interface IVideoPlayer : INotifyPropertyChanged
    {
        Action<IVideoPlayer> VideoStartedAction { get; set; }
        Action<IVideoPlayer> VideoEndedAction { get; set; }
        Func<ExceptionRoutedEventArgs, MediaElement, bool> VideoFailedAction { get; set; }

        MediaState MediaState { get; }
        string FileName { get; }
        double SpeedRatio { get; set; }
        double Volume { get; set; }
        TimeSpan Position { get; set; }
        Size NaturalSize { get; }
        double NaturalDuration { get; }
        ePlayMode PlayMode { get; }

        void Play();
        void Pause();
        void Stop();
        void TogglePlayPauseState();

        void FitWidth(bool adjustScroll);
    }
}
