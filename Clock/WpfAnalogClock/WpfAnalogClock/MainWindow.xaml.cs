﻿using System;
using System.Collections.Generic;
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

namespace WpfAnalogClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClockGrid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowStyle == WindowStyle.None && e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void MainWindow_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if(Width + e.Delta < 200 || Width + e.Delta > 1600)
                return;
            if(Height + e.Delta < 200 || Height + e.Delta > 1000)
                return;

            this.Width += e.Delta;
            this.Height += e.Delta;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
