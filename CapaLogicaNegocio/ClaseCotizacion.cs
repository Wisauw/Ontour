using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class ClaseCotizacion
    {
        public int Id { get; set; }
        public string Nombre_completo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Nombre_Colegio { get; set; }
        public string Origen { get; set; }
        public DateTime Ida { get; set; }
        public DateTime Vuelta { get; set; }
        public int Cantidad_Alumnos { get; set; }
        public int Cantidad_profesores { get; set; }
        public string Mensaje { get; set; }
        public Paquete PaqueteTuristico { get; set; }
        public Region Region { get; set; }
        public Comuna Comuna { get; set; }
        public Servicio Servicio { get; set; }

        private OnTourDBEntities conexion;


        public ClaseCotizacion()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre_completo = String.Empty;
            Email = String.Empty;
            Telefono = String.Empty;
            Nombre_Colegio = String.Empty;
            Origen = String.Empty;
            Ida = new DateTime();
            Vuelta = new DateTime();
            Cantidad_Alumnos = 0;
            Cantidad_profesores = 0;
            Mensaje = String.Empty;
            PaqueteTuristico = new Paquete();
            Region = new Region();
            Comuna = new Comuna();
            Servicio = new Servicio();

            conexion = new OnTourDBEntities();
        }

        public bool agregarCotizacion()
        {
            try
            {
                COTIZACION coti = new COTIZACION();
                coti.Id = this.Id;
                coti.Nombre_Completo = this.Nombre_completo;
                coti.Email = this.Email;
                coti.Telefono = this.Telefono;
                coti.Nombre_Colegio = this.Nombre_Colegio;
                coti.Id_Region = this.Region.Id;
                coti.Id_comuna = this.Comuna.Id;
                coti.Origen = this.Origen;         
                coti.Ida = this.Ida;
                coti.Vuelta = this.Vuelta;
                coti.Cantidad_Alumnos = this.Cantidad_Alumnos;
                coti.Cantidad_Profesores = this.Cantidad_profesores;
                coti.Id_Paquete_Turistico = this.PaqueteTuristico.Id;
                coti.Id_Servicio = this.Servicio.Id;
                coti.Mensaje = this.Mensaje;

                conexion.COTIZACION.Add(coti);
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
