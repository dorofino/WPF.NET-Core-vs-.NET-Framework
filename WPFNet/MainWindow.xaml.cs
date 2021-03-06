﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFNet
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

        private Process emulatorProcess;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            emulatorProcess = new Process();
            emulatorProcess.StartInfo.FileName = @"c:\windows\System32\notepad.exe";
            emulatorProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            emulatorProcess.Start();
        }
    }
}
