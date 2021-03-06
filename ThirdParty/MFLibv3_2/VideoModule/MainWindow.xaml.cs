﻿using ControlModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoModule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConsoleViewModel _consoleViewModel;
        private VideoModuleLogic _videoModuleLogic;

        public MainWindow()
        {
            try
            {
                InitializeComponent();

                _videoModuleLogic = new VideoModuleLogic();
                _videoModuleLogic.InitDisplay(IntPtr.Zero);

                _consoleViewModel = new ConsoleViewModel(_videoModuleLogic);
                _consoleViewModel.PropertyChanged += ConsoleViewModel_PropertyChanged;
                _consoleControl.DataContext = _consoleViewModel;

                this.DataContext = _consoleViewModel;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "VideoModuleMF", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }        
        }

        private void ConsoleViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }
    }
}
