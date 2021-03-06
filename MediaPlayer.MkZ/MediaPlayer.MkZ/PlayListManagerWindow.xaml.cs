﻿using MkZ.MediaPlayer.Utils;
using MkZ.WPF;
using MkZ.WPF.DragDrop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MkZ.MediaPlayer
{
    /// <summary>
    /// Interaction logic for PlayListManagerWindow.xaml
    /// </summary>
    public partial class PlayListManagerWindow : Window, IPlayerMainWindow
    {
        private MediaPlayerContext Context => MediaPlayerContext.Instance;

        private MediaPlayerCommands _mediaPlayerCommands;

        PlayListManagerVM VM = new PlayListManagerVM();
        ListViewDragDropManager<MediaFileInfo> dragMgr = new ListViewDragDropManager<MediaFileInfo>();

        public PlayListManagerWindow()
        {
            DataContext = VM;

            InitializeComponent();

            Context.MediaPlayerCommands = _mediaPlayerCommands = new MediaPlayerCommands(this, enableKeyboardShortcuts: false);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dragMgr.ListView = _listMediaFiles;
            dragMgr.ShowDragAdorner = true;
            dragMgr.DragAdornerOpacity = 0.5;

            VM.NotifyPropertyChangedAll();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _mediaPlayerCommands.Dispose();
            _mediaPlayerCommands = null;
        }

        private void _treePlayLists_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            PlayList list = _treePlayLists.SelectedItem as PlayList;
            _bSortAscending = true;
        }

        private void RemoveMediaFile_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.DataContext is MediaFileInfo file)
                {
                    var files = _listMediaFiles.ItemsSource as System.Collections.ObjectModel.ObservableCollection<MediaFileInfo>;
                    files.Remove(file);
                }
            }
        }

        private void TogglePlayPauseInList_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.Primitives.ToggleButton btn)
            {
                if (btn.DataContext is MediaFileInfo file)
                {
                    PlayMediaFile(file);
                }
            }
        }

        private void PlayMediaFile(MediaFileInfo file)
        {
            if (_treePlayLists.SelectedItem is PlayList playList)
            {
                playList.IsSelectedPlayList = true;

                int idx = playList.MediaFiles.IndexOf(file);
                if (VM.DB.SelectedMediaFileIndex != idx)
                {
                    file.MediaState = MediaState.Play;
                    VM.DB.SelectedMediaFileIndex = idx;
                }
                else
                {
                    _mediaPlayerCommands.TogglePlayPause_Executed(this, null);
                }
                VM.NotifyPropertyChanged(nameof(PlayListManagerVM.IsPlayingSelectedFile));
            }
        }

        private void RemovePlayList_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.DataContext is PlayList list)
                {
                    VM.RemovePlayList(list);
                }
            }
        }

        private void AddPlayList_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.DataContext is PlayList list)
                    VM.DB.AddNewPlayList("NewPlayList", list);
            }
        }

        private void ButtonAddRootPlayList_Click(object sender, RoutedEventArgs e)
        {
            VM.DB.AddNewPlayList("NewPlayList", null);
        }

        private void _listMediaFiles_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListViewItem item)
            {
                if (item.DataContext is MediaFileInfo info)
                {
                    PlayMediaFile(info);

                    this.DialogResult = true;
                    this.Close();
                }
            }
        }

        #region IPlayerMainWindow

        public Window Window => this;

        public void AddNewMediaFiles(string[] fileNames, double volume)
        {
            PlayList playList  = _treePlayLists.SelectedItem as PlayList;
            MediaPlayerContext.Instance.AddNewMediaFiles(playList, fileNames, volume);
        }

        public void FullScreenToggle()
        {
        }

        public MediaFileInfo PreviousTrackInfo()
        {
            return null;
        }

        public bool PreviousTrack_CanExecute()
        {
            return false;
        }

        public void PreviousTrack_Executed(bool bResetPositionAndPlay)
        {
        }

        public MediaFileInfo NextTrackInfo()
        {
            return null;
        }

        public bool NextTrack_CanExecute()
        {
            return false;
        }

        public void NextTrack_Executed(bool bResetPositionAndPlay)
        {
        }

        public void RemoveMediaFileAndSelectNext(MediaFileInfo info, bool bResetPositionAndPlay, bool bRemoveFromList)
        {
            throw new NotImplementedException();
        }

        #endregion

        private bool _bSortAscending = true;
        private void ButtonSort_Click(object sender, RoutedEventArgs e)
        {
            PlayList playList = _treePlayLists.SelectedItem as PlayList;
            if(playList != null && playList.MediaFiles.Count > 1)
            {
                List<MediaFileInfo> list = new List<MediaFileInfo>(playList.MediaFiles);
                list.Sort((f1, f2) => 
                { 
                    if(_bSortAscending)
                        return Path.GetFileNameWithoutExtension(f1.FileName).CompareTo(Path.GetFileNameWithoutExtension(f2.FileName)); 
                    else
                        return Path.GetFileNameWithoutExtension(f2.FileName).CompareTo(Path.GetFileNameWithoutExtension(f1.FileName));
                });

                playList.MediaFiles.Clear();
                playList.MediaFiles.AddRange(list);

                _bSortAscending = !_bSortAscending;
                _btnSort.IsChecked = _bSortAscending;
            }
        }

        private void FileName_TextChanged(object sender, string newText)
        {
            if(sender is EditBox txt)
            {
                if (txt.DataContext is MediaFileInfo info)
                {
                    try
                    {
                        string newFileName = txt.Text;
                        string newPath = Path.Combine(Path.GetDirectoryName(info.FileName), newFileName);
                        if (newPath != info.FileName)
                        {
                            File.Move(info.FileName, newPath);
                            info.FileName = newPath;
                        }
                    }
                    catch (Exception err)
                    {
                        txt.Text = Path.GetFileName(info.FileName);
                        MessageBox.Show(err.ToString());
                    }
                }
            }
        }
    }
}
