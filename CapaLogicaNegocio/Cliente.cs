using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre_completo { get; set; }
        public String Email { get; set; }
        public Colegio Colegio { get; set; }
        public Ejecutivo Ejecutivo { get; set; }
        public Paquete PaqueteTuristico { get; set; }
        public Region Region { get; set; }

        public Cliente()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre_completo = String.Empty;
            Email = String.Empty;
            Colegio = new Colegio();
            Ejecutivo = new Ejecutivo();
            PaqueteTuristico = new Paquete();
            Region = new Region();
        }
    }
}
