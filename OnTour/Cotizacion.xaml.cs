using System;
using System.Collections;
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
using CapaLogicaNegocio;
using MaterialDesignThemes.Wpf;
using OnTour.Dialogo.Cotizacion;

namespace OnTour
{
    /// <summary>
    /// Lógica de interacción para Cotizacion.xaml
    /// </summary>
    public partial class Cotizacion : Page
    {
        //GLOBAL
        ClaseCotizacion coti = new ClaseCotizacion();

        public Cotizacion()
        {
            InitializeComponent();
            CargarRegiones();
            CargarPaquetes();
        }

        internal IEnumerable ListarCotizacion()
        {
            throw new NotImplementedException();
        }

        private void CargarPaquetes()
        {
            cboPaquete.ItemsSource = new Paquete().listadoPaquete();
            cboPaquete.DisplayMemberPath = "Nombre";
            cboPaquete.SelectedValuePath = "Id";
            cboPaquete.SelectedIndex = -1;
        }

        private void CargarRegiones()
        {
            cboRegion.ItemsSource = new Region().listadoRegion();
            cboRegion.DisplayMemberPath = "Nombre";
            cboRegion.SelectedValuePath = "Id";
            cboRegion.SelectedIndex = -1;
        }

        private void CboRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboComuna.ItemsSource = new Comuna().listadoComunas((int)cboRegion.SelectedValue);
            cboComuna.DisplayMemberPath = "Nombre";
            cboComuna.SelectedValuePath = "Id";
            cboComuna.SelectedIndex = -1;
        }

        private void CboPaquete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboServicios.ItemsSource = new Servicio().listadoServicios((int)cboPaquete.SelectedValue);
            cboServicios.DisplayMemberPath = "Nombre";
            cboServicios.SelectedValuePath = "Id";
            cboServicios.SelectedIndex = -1;
        }

        private void BtnMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void BtnInfo_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new informacion());
        }              

        private void BtnPrint_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(Cotiza, "Cotización");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private async void BtnSolicitarCotizacion_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarFormulario()) return;
            try
            {
                coti.Nombre_completo = txtNombre_completo.Text;
                coti.Email = txtEmail.Text;
                coti.Telefono = txtTelefono.Text;
                coti.Nombre_Colegio = txtNombre_Colegio.Text;
                coti.Region = new Region() { Id = (int)cboRegion.SelectedValue };
                coti.Comuna = new Comuna() { Id = (int)cboComuna.SelectedValue };
                coti.Origen = txtOrigen.Text;
                coti.Ida = DtpIda.SelectedDate.Value;
                coti.Vuelta = DtpVuelta.SelectedDate.Value;
                coti.Cantidad_Alumnos = int.Parse(txtCantidadAlumnos.Text);
                coti.Cantidad_profesores = int.Parse(txtCantidadProfesores.Text);
                coti.PaqueteTuristico = new Paquete() { Id = (int)cboPaquete.SelectedValue };
                coti.Servicio = new Servicio() { Id = (int)cboServicios.SelectedValue };
                coti.Mensaje = txtMensaje.Text;

                if (coti.agregarCotizacion() == true)
                {
                    var dialog = new DialogCotizaBien(); 
                    var result = (bool)await DialogHost.Show(dialog, "DHCotiza");

                }
                else
                {
                    var dialog = new ErrorCoti();
                    var result = (bool)await DialogHost.Show(dialog, "DHCotiza");
                }
            }
            catch (Exception)
            {
                var dialog = new ErrorCoti();
                var result = (bool)await DialogHost.Show(dialog, "DHCotiza");
            }
        }
        private bool ValidarFormulario()
        {
            if (!Validacion.ValidarCampoDeTextoObligatorio(txtNombre_completo.Text, "Nombre Colegio")) return false;
            if (!Validacion.ValidarCampoDeTextoObligatorio(txtEmail.Text, "Dirección Colegio")) return false;
            if (!Validacion.ValidarCampoDeTextoObligatorio(txtTelefono.Text, "Telefono Colegio")) return false;

            if (!Validacion.ValidarCampoDeTextoObligatorio(txtNombre_Colegio.Text, "Nombre Colegio")) return false;

            if (cboRegion.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una Region", "Error");
                return false;
            }
            if (cboComuna.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una Comuna", "Error");
                return false;
            }

            if (!Validacion.ValidarCampoDeTextoObligatorio(txtOrigen.Text, "Origen")) return false;

            if (!Validacion.ValidarCampoDeTextoObligatorio(DtpIda.Text, "Ida")) return false;
            if (!Validacion.ValidarCampoDeTextoObligatorio(DtpVuelta.Text, "Vuelta")) return false;



            if (!Validacion.ValidarCantidad(txtCantidadAlumnos.Text, "Cantidad Alumnos")) return false;
            if (!Validacion.ValidarCantidad(txtCantidadProfesores.Text, "Cantidad Profesores")) return false;

            

            if (cboPaquete.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un Paquete", "Error");
                return false;
            }
            if (cboServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un Servicio", "Error");
                return false;
            }



            return true;
        }
    }
}
