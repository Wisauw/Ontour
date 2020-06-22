using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnTour
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new ReClientexaml();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Cotizacion();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Main.Content = new Menu();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PaqueteTuristico();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Main.Content = new Nosotros();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Main.Content = new informacion();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
    }
