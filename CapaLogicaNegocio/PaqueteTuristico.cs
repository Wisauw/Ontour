﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class PaqueteTuristico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Destino Destino { get; set; }
        public Servicio Servicio { get; set; }

        public PaqueteTuristico()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
            Destino = new Destino();
            Servicio = new Servicio();
        }
    }
}