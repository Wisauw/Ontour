using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Paquete Paquete { get; set; }
        private OnTourDBEntities conexion;

        public Servicio()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;       
            Paquete = new Paquete();
            conexion = new OnTourDBEntities();
        }

        public IEnumerable<object> listadoServicios(int idPaquete)
        {
            try
            {
                var listado = (from c in conexion.SERVICIO
                               where c.Id_Paquete== idPaquete
                               select c).ToList();
                return listado;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
