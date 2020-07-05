using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

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
        public string Email_Rector { get; set; }
        public int Participantes { get; set; }
        public string Nombre_Representante { get; set; }
        public string Telefono_Representante { get; set; }
        public string Email_Representante { get; set; }
        public Curso Curso { get; set; }        
        private OnTourDBEntities conexion;

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
            Email_Rector = String.Empty;
            Participantes = 0;
            Nombre_Representante = String.Empty;
            Telefono_Representante = String.Empty;
            Email_Representante = String.Empty;
            Curso = new Curso();
            conexion = new OnTourDBEntities();
        }
    }
}
