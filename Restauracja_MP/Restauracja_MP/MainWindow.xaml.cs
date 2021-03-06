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
using System.Windows.Shapes;

namespace Restauracja_MP
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Order_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Order_window order = new Order_window();
            order.ShowDialog();
        }


        private void History_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            history_window history_w = new history_window();
            history_w.ShowDialog();
        }

    }
    
}
