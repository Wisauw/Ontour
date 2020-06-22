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

namespace OnTour
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new informacion());
        }

        private void BtnDame_Click(object sender, RoutedEventArgs e)
        {
            Paquetes();
        }

        private void BtnNoruega_Click(object sender, RoutedEventArgs e)
        {
            Paquetes();
        }

        private void BtnBariloche_Click(object sender, RoutedEventArgs e)
        {
            Paquetes();
        }

        private void BtnTorres_Click(object sender, RoutedEventArgs e)
        {
            Paquetes();
        }

        private void Paquetes() {
            NavigationService.Navigate(new PaqueteTuristico());
        }
    }
}
