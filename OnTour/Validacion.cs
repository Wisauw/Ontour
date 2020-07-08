using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour
{
    class Validacion
    {
        public static bool ValidarCampoDeTextoObligatorio(string texto, string campo)
        {
            string mensaje = string.Format("El campo '{0}' es obligatorio, ", campo);

            if (string.IsNullOrEmpty(texto))
            {
                Mensaje.Mostrar(mensaje + "y no puede estar vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(texto))
            {
                Mensaje.Mostrar(mensaje + "y no puede contener sólo espacios en blanco");
                return false;
            }
            return true;
        }
    }
}
