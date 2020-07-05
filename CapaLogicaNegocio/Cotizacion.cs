using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public string Nombre_completo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Colegio Nombre_Colegio { get; set; }
        public string Origen { get; set; }
        public DateTime Ida { get; set; }
        public DateTime Vuelta { get; set; }
        public int Cantidad_Alumnos { get; set; }
        public int Cantidad_profesores { get; set; }
        public string Mensaje { get; set; }
        public Paquete PaqueteTuristico { get; set; }
        public Region Region { get; set; }


        public Cotizacion()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre_completo = String.Empty;
            Email = String.Empty;
            Telefono = String.Empty;
            Nombre_Colegio = new Colegio();
            Origen = String.Empty;
            Ida = new DateTime();
            Vuelta = new DateTime();
            Cantidad_Alumnos = 0;
            Cantidad_profesores = 0;
            Mensaje = String.Empty;
            PaqueteTuristico = new Paquete();
            Region = new Region();
        }
    }
}
