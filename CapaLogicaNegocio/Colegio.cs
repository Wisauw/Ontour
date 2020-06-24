using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Colegio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nombre_Rector { get; set; }
        public string Telefono_Rector { get; set; }
        public string Nombre_Representante { get; set; }
        public string Telefono_Representante { get; set; }

        public Colegio()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
            Direccion = String.Empty;
            Telefono = String.Empty;
            Nombre_Rector = String.Empty;
            Telefono_Rector = String.Empty;
            Nombre_Representante = String.Empty;
            Telefono_Representante = String.Empty;
        }
    }
}
