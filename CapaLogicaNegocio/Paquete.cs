using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class Paquete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        private OnTourDBEntities conexion;

        public Paquete()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
            conexion = new OnTourDBEntities();
        }

        public IEnumerable<object> listadoPaquete()
        {
            try
            {
                return conexion.PAQUETE_TURISTICO.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
