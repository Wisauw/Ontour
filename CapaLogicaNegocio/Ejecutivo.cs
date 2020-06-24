using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Ejecutivo
    {
        public int Id { get; set; }
        public string Nombre_Completo { get; set; }

        public Ejecutivo()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre_Completo = String.Empty;
        }
    }
}
