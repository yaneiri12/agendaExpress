using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaElectronicaWF
{
    internal class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Movil { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
