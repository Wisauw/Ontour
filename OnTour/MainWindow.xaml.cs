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
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            CursorGrid.Margin = new Thickness(15 + (160 * index), 45, 0, 0);

            switch (index) {
                case 0:
                    PantallaPrincipal.Content = new Menu();
                    //CursorGrid.Background = Brushes.OrangeRed;
                    break;

                case 1:
                    PantallaPrincipal.Content = new ReClientexaml();
                    break;

                case 2:
                    PantallaPrincipal.Content = new PaqueteTuristico();
                    break;

                case 3:
                    PantallaPrincipal.Content = new Cotizacion();
                    break;

                case 4:
                    PantallaPrincipal.Content = new Nosotros();
                    break;

                case 5:
                    PantallaPrincipal.Content = new informacion();
                    break;


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

   

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Bievenido_Click(object sender, RoutedEventArgs e)
        {
            if (Bievenido.Content.ToString() == "Hola, Admin")
            {
                Admin admin = new Admin();
                admin.Show();
            }
        }
    }
    }
