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

namespace WPF_Tp_03
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_update_Click(object sender, RoutedEventArgs e)
        {
            Lbl_one.Content = "Hey !";
        }

        private void Btn_update_Click_2(object sender, RoutedEventArgs e)
        {
            Lbl_two.Content = "We are number one !";
        }

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            Sld_one.Value = 0;
        }
    }
}
