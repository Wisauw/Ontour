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
using CapaLogicaNegocio;
using MaterialDesignThemes.Wpf;
using OnTour.Dialogo;


namespace OnTour
{
    /// <summary>
    /// Lógica de interacción para ReClientexaml.xaml
    /// </summary>
    public partial class ReClientexaml : Page
    {
        //GLOBAL
        Colegio cole = new Colegio();


        public ReClientexaml()
        {
            InitializeComponent();
            CargarCursos();
        }

        private void CargarCursos()
        {
            cboCursoContratar.ItemsSource = new Curso().listadoCurso();
            cboCursoContratar.DisplayMemberPath = "Nombre";
            cboCursoContratar.SelectedValuePath = "Id";
            cboCursoContratar.SelectedIndex = -1;
        }

        private void CboCursoContratar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboSigla.ItemsSource = new Sigla().listadoSiglas((int)cboCursoContratar.SelectedValue);
            cboSigla.DisplayMemberPath = "Nombre";
            cboSigla.SelectedValuePath = "Id";
            cboSigla.SelectedIndex = -1;
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void BtnInfo_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new informacion());
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private async void BtnRegistrarCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cole.Nombre = txtNombrecolegio.Text;
                cole.Direccion = txtDireccionColegio.Text;
                cole.Telefono = txtTelefonoColegio.Text;
                cole.Nombre_Rector = txtNombreRector.Text;
                cole.Telefono_Rector = txtTelefonoRector.Text;
                cole.Email_Rector = txtemailRector.Text;
                cole.Curso = new Curso() { Id = (int)cboCursoContratar.SelectedValue };
                cole.Sigla = new Sigla() { Id = (int)cboSigla.SelectedValue };
                cole.Participantes = int.Parse(txtParticipantes.Text);
                cole.Nombre_Representante = txtNombreRepresentante.Text;
                cole.Telefono_Representante = txtTelefonoRepresentante.Text;
                cole.Email_Representante = txtEmailRepresentante.Text;

                if (cole.agregarColegio() == true)
                {
                    var dialog = new user(); // me manie y le puse user como nombre al dialogo xdd
                    var result = (bool)await DialogHost.Show(dialog, "DHEstado");
                    
                }
                else
                {
                    var dialog = new DialogoError(); // Este dialogo si esta bien definido ya que llama al control user dialogoError
                    var result = (bool)await DialogHost.Show(dialog, "DHEstado");
                    
                }

            }
            catch (Exception ex)
            {
                var dialog = new DialogoError(); 
                var result = (bool)await DialogHost.Show(dialog, "DHEstado");
               
            }
        }
    }
}
