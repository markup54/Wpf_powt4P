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

namespace WpfApp1
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autorem aplikacji jest 000000000",
                "Autor",
                MessageBoxButton.OK,
                MessageBoxImage.Exclamation);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("wersja 0");
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Black;
            tekst3.Foreground = Brushes.White;
            //tekst3.Foreground= Brushes.White;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
