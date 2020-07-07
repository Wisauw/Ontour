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
using MaterialDesignThemes.Wpf;
namespace OnTour
{
    /// <summary>
    /// Lógica de interacción para Logeo.xaml
    /// </summary>
    public partial class Logeo : Window
    {
        public Logeo()
        {
            InitializeComponent();
        }
        MainWindow ventanaprincipal = new MainWindow();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BtnIniciar_Click(object sender, RoutedEventArgs e)
        {

            if (txtUsuario.Text == "Admin" && txtPass.Password == "Admin")
            {

                //Terminado.IsOpen = true;
                ventanaprincipal.Show();
                this.Close();
                ventanaprincipal.Bievenido.Content = "Hola, Admin";
            }
            if (txtUsuario.Text == "empleado" && txtPass.Password == "123")
            {
                //Terminado.IsOpen = true;
                ventanaprincipal.Show();
                this.Close();
                ventanaprincipal.Bievenido.Content = "Hola, Empleado";
            }
            else {
                if (txtUsuario.Text == "" | txtPass.Password == "")
                    MessageBox.Show("debe rellenar ambos cuadros de texto");
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) {
                DragMove();
            }
        }
    }
}
