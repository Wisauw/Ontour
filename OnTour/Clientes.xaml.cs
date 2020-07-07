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
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : Page
    {
        public Clientes()
        {
            InitializeComponent();
            CargarGrid();
        }
        private void CargarGrid()
        {
            dgrLista.ItemsSource = new Colegio().ListarColegio();
            dgrLista.Items.Refresh();
        }
    }
}
