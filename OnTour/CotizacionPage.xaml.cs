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
    /// Lógica de interacción para CotizacionPage.xaml
    /// </summary>
    public partial class CotizacionPage : Page
    {
        //GLOBAL
        ClaseCotizacion coti = new ClaseCotizacion();
        public ClaseCotizacion CotizacionSeleccionado
        {
            get
            {
                if (dgrListaCot.HasItems)
                {
                    if (dgrListaCot.SelectedItem != null)
                    {
                        return (ClaseCotizacion)dgrListaCot.SelectedItem;
                    }
                }
                return null;
            }
        }

        public CotizacionPage()
        {
            InitializeComponent();
            CargarGrid();
            CargarCot();
        }

        private void CargarCot()
        {
            cmbRegion.ItemsSource = new Region().listadoRegion();
            cmbRegion.DisplayMemberPath = "Nombre";
            cmbRegion.SelectedValuePath = "Id";
            cmbRegion.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            dgrListaCot.ItemsSource = new ClaseCotizacion().ListarCotizacion();
            dgrListaCot.Items.Refresh();
        }                         

        private void Btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = "";
            txtNombre_Cole.Text = "";
            //txtId.Text = "";
            cmbRegion.SelectedValue = -1;
            CargarGrid();
        }
        
        private void TxtNombre_KeyUp_1(object sender, KeyEventArgs e)
        {
            dgrListaCot.ItemsSource = new ClaseCotizacion().FiltrarNombre(txtNombre.Text);
            dgrListaCot.Items.Refresh();
        }
        
        private void TxtNombre_Cole_KeyUp_1(object sender, KeyEventArgs e)
        {
            dgrListaCot.ItemsSource = new ClaseCotizacion().FiltrarColegio(txtNombre_Cole.Text);
            dgrListaCot.Items.Refresh();
        }

        private void CmbRegion_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            dgrListaCot.ItemsSource = new ClaseCotizacion().FiltrarRegion((int)cmbRegion.SelectedValue);
        }

   

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (this.CotizacionSeleccionado == null)
            {
                MessageBox.Show("Selecciona algo antes de borrar");
            }
            else
            {
                try
                {
                    
                    coti.Id = int.Parse(CotizacionSeleccionado.Id.ToString());

                    if (coti.EliminarCotizacion() == true)
                    {
                        MessageBox.Show("Cotizacion eliminada");
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("no se pudo eliminar cotizacion");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al eliminar");
                }
            }
               
        }
    }


}
