﻿using System;
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
    /// Lógica de interacción para Cotizacion.xaml
    /// </summary>
    public partial class Cotizacion : Page
    {
        public Cotizacion()
        {
            InitializeComponent();
            CargarRegiones();
            CargarPaquetes();
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

        
    }
}
