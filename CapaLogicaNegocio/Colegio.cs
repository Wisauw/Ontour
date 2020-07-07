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
        public Curso Curso { get; set; }
        public Sigla Sigla { get; set; }
        public int Participantes { get; set; }
        public string Nombre_Representante { get; set; }
        public string Telefono_Representante { get; set; }
        public string Email_Representante { get; set; }
        
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
            Curso = new Curso();
            Sigla = new Sigla();
            Participantes = 0;
            Nombre_Representante = String.Empty;
            Telefono_Representante = String.Empty;
            Email_Representante = String.Empty;
                      
            conexion = new OnTourDBEntities();
        }


        public bool agregarColegio()
        {
            try
            {
                COLEGIO cole = new COLEGIO();
                cole.Id = this.Id;
                cole.Nombre = this.Nombre;
                cole.Direccion = this.Direccion;
                cole.Telefono = this.Telefono;
                cole.Nombre_Rector = this.Nombre_Rector;
                cole.Telefono_Rector = this.Telefono_Rector;
                cole.Email_Rector = this.Email_Rector;
                cole.Id_curso = this.Curso.Id;
                cole.Id_Sigla = this.Sigla.Id;             
                cole.Participantes = this.Participantes;
                cole.Nombre_Representante = this.Nombre_Representante;
                cole.Telefono_Representante = this.Telefono_Representante;
                cole.Email_Representante = this.Email_Representante;

             

                conexion.COLEGIO.Add(cole);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public IEnumerable<object> ListarColegio() {
            try
            {
                var listado = (from a in conexion.COLEGIO
                               select new{
                                   ID = a.Id,
                                   NOMBRE = a.Nombre,
                                   DIRECCION = a.Direccion,
                                   TELEFONO= a.Telefono,
                                   NOMBRE_RECTOR = a.Nombre_Rector,
                                   TELEFONO_RECTOR = a.Telefono_Rector,
                                   NOMBRE_REPRESENTANTE = a.Nombre_Representante,
                                   CURSO = a.CURSO.Nombre,
                                   SIGLA = a.SIGLA.Nombre,
                                   PARTICIPANTES = a.Participantes



                }
                               ).ToList();
                return listado;
            }
            catch(Exception ex)
            {

                return null;
            }
        }
    }
}
