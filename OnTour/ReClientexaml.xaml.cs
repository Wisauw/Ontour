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

namespace OnTour
{
    /// <summary>
    /// Lógica de interacción para ReClientexaml.xaml
    /// </summary>
    public partial class ReClientexaml : Page
    {
        //GLOBAL
        Cliente cli = new Cliente();
        

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

        private void BtnRegistrarCliente_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
