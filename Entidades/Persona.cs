using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string identificacion { get; set; }
        public string numeroTelefono { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }

        public Persona()
        {

        }

    }
}
