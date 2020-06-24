using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class Comuna
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Region Region { get; set; }
        private OnTourDBEntities conexion;

        public Comuna()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
            Region = new Region();
            conexion = new OnTourDBEntities();
        }

        public IEnumerable<object> listadoComunas(int idRegion)
        {
            try
            {
                var listado = (from c in conexion.COMUNA
                               where c.Id_Region == idRegion
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
