using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class Region
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        private OnTourDBEntities conexion;

        public Region()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
            conexion = new OnTourDBEntities();
        }

        public IEnumerable<object> listadoRegion()
        {
            try
            {
                return conexion.REGION.ToList();
            }
            catch (Exception ex)
            {
                return null;                
            }
        }
        
    }
}
