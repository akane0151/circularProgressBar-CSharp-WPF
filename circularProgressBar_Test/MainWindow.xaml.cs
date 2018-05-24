﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace circularProgressBar_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer tm = new Timer(1000);
        
        public MainWindow()
        {
            InitializeComponent();
            tm.Elapsed += new ElapsedEventHandler(t);
            tm.Enabled = true;
        }
        public void t(object src, ElapsedEventArgs e)
        {
            pgbar.setprogress(DateTime.Now.Second);
        }
    }
}
