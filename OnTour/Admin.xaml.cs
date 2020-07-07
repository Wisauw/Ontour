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
using System.Windows.Shapes;
using CapaLogicaNegocio;

namespace OnTour
{
    /// <summary>
    /// Lógica de interacción para Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public static Admin ventana;

        public static Admin getInstance()
        {
            if (ventana == null)
            {
                ventana = new Admin();
            }
            return ventana;
        }

        public Admin()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                int index = int.Parse(((Button)e.Source).Uid);

                CursorGrid.Margin = new Thickness(15 + (160 * index), 45, 0, 0);

                switch (index)
                {
                    case 0:
                        FrameAdmin.Content = new Clientes();
                        //CursorGrid.Background = Brushes.OrangeRed;
                        break;

                    case 1:
                        FrameAdmin.Content = new CotizacionPage();
                        break;


                }
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ventana = null;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
