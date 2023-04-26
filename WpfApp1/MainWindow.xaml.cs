using System;
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
            //tekst3.Foreground = Brushes.White;
            //tekst3.Foreground= Brushes.White;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Foreground = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mc= miesiac.Text;
            MessageBox.Show("wybrano miesiąc " + mc);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int ile = 0;
            if (wart1.IsChecked == true)
            {
                ile = 5;
            }
            else if(wart2.IsChecked == true)
            {
                ile = 10;
            }
            else
            {
                ile = 15;
            }
            
            wylosuj(ile);
        }
        private void wylosuj(int n)
        {
            var random = new Random();
            string tekstlosowy = "";
            for(int i = 0; i < n; i++)
            {
                int x = random.Next(100);
                tekstlosowy = tekstlosowy + x.ToString()+", ";
            }
            MessageBox.Show(tekstlosowy);

        }

        private void wart1_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton =(RadioButton)sender;
            int ile = int.Parse(radioButton.Content.ToString());
            wylosuj(ile);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string jezyki = "";
            if(Cszarp.IsChecked == true)
            {
                jezyki += Cszarp.Content+", ";
            }
            if(Cplus.IsChecked == true)
            {
                jezyki += Cplus.Content+", ";
            }
            if(TypeScript.IsChecked == true)
            {
                jezyki += TypeScript.Content + ", ";
            }
            if(Java.IsChecked == true)
            {
                jezyki +=Java.Content + ", ";

            }
            if(Pehap.IsChecked == true)
            {
                jezyki += Pehap.Content + ", ";
            }
            tekstJezyki.Text = jezyki;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window okno = new Window1();
            //okno.ShowDialog();
            okno.Show();

        }
    }
}
