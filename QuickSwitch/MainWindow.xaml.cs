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

namespace QuickSwitch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.WindowStyle = WindowStyle.None;//隐藏菜单栏
            //this.AllowsTransparency = true;//允许mainwindow透明
            //this.Opacity = 1;//设置透明程度，0为透明，1不透明
            //this.WindowStartupLocation =WindowStartupLocation.CenterScreen;
            //this.SizeToContent = SizeToContent.Height;
        }

        
    }
}