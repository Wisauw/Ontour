using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class Sigla
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Curso Curso { get; set; }
        private OnTourDBEntities conexion;

        public Sigla()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = String.Empty;
            Curso = new Curso();
            conexion = new OnTourDBEntities();
        }

        public IEnumerable<object> listadoSiglas(int idCurso)
        {
            try
            {
                var listado = (from c in conexion.SIGLA
                               where c.Id_Curso == idCurso
                               select c).ToList();
                return listado;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public IEnumerable<object> FiltrarSigla(int idCurso)
        {
            try
            {
                var listado = (from c in conexion.SIGLA
                               where c.Id_Curso == idCurso
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
