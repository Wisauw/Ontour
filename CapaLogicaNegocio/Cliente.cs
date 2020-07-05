using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;

namespace CapaLogicaNegocio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre_completo { get; set; }
        public string Email { get; set; }
        public Colegio Colegio { get; set; }
        public Ejecutivo Ejecutivo { get; set; }
        public Paquete PaqueteTuristico { get; set; }
        public Region Region { get; set; }
        private OnTourDBEntities conexion;

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
            conexion = new OnTourDBEntities();
        }


        public bool agregarCliente()
        {
            try
            {
                CLIENTE cli = new CLIENTE();
                cli.COLEGIO.Nombre = this.Colegio.Nombre;
                cli.COLEGIO.Direccion = this.Colegio.Direccion;
                cli.COLEGIO.Telefono = this.Colegio.Telefono;
                cli.COLEGIO.Nombre_Rector = this.Colegio.Nombre_Rector;
                cli.COLEGIO.Email_Rector = this.Colegio.Email_Rector;
                cli.COLEGIO.CURSO.Id = this.Colegio.Curso.Id;
                
                cli.COLEGIO.Participantes = this.Colegio.Participantes;
                cli.COLEGIO.Nombre_Representante = this.Colegio.Nombre_Representante;
                cli.COLEGIO.Telefono_Representante = this.Colegio.Telefono_Representante;
                cli.COLEGIO.Email_Representante = this.Colegio.Email_Representante;
                
                cli.Id_Region = this.Region.Id;

                conexion.CLIENTE.Add(cli);
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
