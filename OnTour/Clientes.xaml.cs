using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : Page
    {
        Colegio colegio = new Colegio();

        public Colegio ColegioSeleccionado
        {
            get
            {
                if (dgrLista.HasItems)
                {
                    if (dgrLista.SelectedItem != null)
                    {
                        return (Colegio)dgrLista.SelectedItem;
                    }
                }
                return null;
            }
        }

        public Clientes()
        {
            InitializeComponent();
            CargarGrid();
            CargarCursos();


        }

        private void CargarCursos()
        {
            cmbCurso.ItemsSource = new Curso().listadoCurso();
            cmbCurso.DisplayMemberPath = "Nombre";
            cmbCurso.SelectedValuePath = "Id";
            cmbCurso.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            dgrLista.ItemsSource = new Colegio().ListarColegio();
            dgrLista.Items.Refresh();
        }

        private void CmbCurso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dgrLista.ItemsSource = new Colegio().FiltrarCurso((int)cmbCurso.SelectedValue);
            dgrLista.Items.Refresh();
        }

        private void TxtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            dgrLista.ItemsSource = new Colegio().FiltrarNombre(txtNombre.Text);
            dgrLista.Items.Refresh();
        }

        private void Btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = "";
            txtrepresentante.Text = "";
            cmbCurso.SelectedValue = -1;
            CargarGrid();
        }

        private void Txtrepresentante_KeyUp(object sender, KeyEventArgs e)
        {
            dgrLista.ItemsSource = new Colegio().FiltrarRepresentante(txtrepresentante.Text);
            dgrLista.Items.Refresh();
        }

        private void Btneliminar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                colegio.Id = int.Parse(txtId.Text);

                if (colegio.EliminarColegio() == true)
                {
                    MessageBox.Show("Colegio eliminada");
                    txtId.Text = "";
                    dgrLista.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Cotizacion no se pudo eliminar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar");
            }
        }

        private void Btnmodificar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtId_KeyUp(object sender, KeyEventArgs e)
        {
            dgrLista.ItemsSource = new Colegio().FiltrarId(int.Parse(txtId.Text));
            dgrLista.Items.Refresh();
        }
    }
}
