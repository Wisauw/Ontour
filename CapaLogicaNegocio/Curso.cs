using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class Curso
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        private OnTourDBEntities conexion;

        public Curso()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
            conexion = new OnTourDBEntities();
        }

        public IEnumerable<object> listadoCurso()
        {
            try
            {
                return conexion.CURSO.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
