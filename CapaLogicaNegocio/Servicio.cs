using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Servicio()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
        }
    }
}
