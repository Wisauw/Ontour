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
        public bool eliminarColegio() {
            try
            {
                
                conexion.COLEGIO.Remove(conexion.COLEGIO.Find(this.Id));
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public List<Colegio> ListarColegio()
        {
            try
            {
                var listado = (from a in conexion.COLEGIO
                               select new Colegio
                               {
                                   Id = a.Id,
                                   Nombre = a.Nombre,
                                   Direccion = a.Direccion,
                                   Telefono = a.Telefono,
                                   Nombre_Rector = a.Nombre_Rector,
                                   Telefono_Rector = a.Telefono_Rector,
                                   Nombre_Representante = a.Nombre_Representante,
                                   Telefono_Representante = a.Telefono_Representante,
                                   Curso = new Curso() { Id = a.Id_curso, Nombre = a.CURSO.Nombre },
                                   Sigla = new Sigla() { Id = a.Id_Sigla, Nombre = a.SIGLA.Nombre },
                                   Participantes = a.Participantes.Value,
                                   Email_Rector= a.Email_Rector,
                                   Email_Representante= a.Email_Representante


                               }
                               ).ToList();
                return listado;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public List<Colegio> FiltrarCurso(int idcurso)
        {
            try
            {
                var listado = (from a in conexion.COLEGIO where a.Id_curso == idcurso
                               select new Colegio
                               {
                                   Id = a.Id,
                                   Nombre = a.Nombre,
                                   Direccion = a.Direccion,
                                   Telefono = a.Telefono,
                                   Nombre_Rector = a.Nombre_Rector,
                                   Telefono_Rector = a.Telefono_Rector,
                                   Nombre_Representante = a.Nombre_Representante,
                                   Telefono_Representante = a.Telefono_Representante,
                                   Curso = new Curso() { Id = a.Id_curso, Nombre = a.CURSO.Nombre },
                                   Sigla = new Sigla() { Id = a.Id_Sigla, Nombre = a.SIGLA.Nombre },
                                   Participantes = a.Participantes.Value,
                                   Email_Rector = a.Email_Rector,
                                   Email_Representante = a.Email_Representante



                               }
                               ).ToList();
                return listado;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public List<Colegio> FiltrarNombre(string nombre)
        {
            try
            {
                var listado = (from a in conexion.COLEGIO
                               where a.Nombre.Contains(nombre)
                               select new Colegio
                               {
                                   Id = a.Id,
                                   Nombre = a.Nombre,
                                   Direccion = a.Direccion,
                                   Telefono = a.Telefono,
                                   Nombre_Rector = a.Nombre_Rector,
                                   Telefono_Rector = a.Telefono_Rector,
                                   Nombre_Representante = a.Nombre_Representante,
                                   Telefono_Representante = a.Telefono_Representante,
                                   Curso = new Curso() { Id = a.Id_curso, Nombre = a.CURSO.Nombre },
                                   Sigla = new Sigla() { Id = a.Id_Sigla, Nombre = a.SIGLA.Nombre },
                                   Participantes = a.Participantes.Value,
                                   Email_Rector = a.Email_Rector,
                                   Email_Representante = a.Email_Representante



                               }
                               ).ToList();
                return listado;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public List<Colegio> FiltrarRepresentante(string nombre)
        {
            try
            {
                var listado = (from a in conexion.COLEGIO
                               where a.Nombre_Representante.Contains(nombre)
                               select new Colegio
                               {
                                   Id = a.Id,
                                   Nombre = a.Nombre,
                                   Direccion = a.Direccion,
                                   Telefono = a.Telefono,
                                   Nombre_Rector = a.Nombre_Rector,
                                   Telefono_Rector = a.Telefono_Rector,
                                   Nombre_Representante = a.Nombre_Representante,
                                   Telefono_Representante = a.Telefono_Representante,
                                   Curso = new Curso() { Id = a.Id_curso, Nombre = a.CURSO.Nombre },
                                   Sigla = new Sigla() { Id = a.Id_Sigla, Nombre = a.SIGLA.Nombre },
                                   Participantes = a.Participantes.Value,
                                   Email_Rector = a.Email_Rector,
                                   Email_Representante = a.Email_Representante



                               }
                               ).ToList();
                return listado;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        

        public List<Colegio> FiltrarId(int id)
        {
            try
            {
                var listado = (from a in conexion.COLEGIO
                               where a.Id == id
                               select new Colegio
                               {
                                   Id = a.Id,
                                   Nombre = a.Nombre,
                                   Direccion = a.Direccion,
                                   Telefono = a.Telefono,
                                   Nombre_Rector = a.Nombre_Rector,
                                   Telefono_Rector = a.Telefono_Rector,
                                   Nombre_Representante = a.Nombre_Representante,
                                   Telefono_Representante = a.Telefono_Representante,
                                   Curso = new Curso() { Id = a.Id_curso, Nombre = a.CURSO.Nombre },
                                   Sigla = new Sigla() { Id = a.Id_Sigla, Nombre = a.SIGLA.Nombre },
                                   Participantes = a.Participantes.Value,
                                   Email_Rector = a.Email_Rector,
                                   Email_Representante = a.Email_Representante



                               }
                               ).ToList();
                return listado;
            }
            catch (Exception ex)
            {

                return null;
            }
        }


        public bool EliminarColegio()
        {
            try
            {
                conexion.COLEGIO.Remove(conexion.COLEGIO.Find(this.Id));
                conexion.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
