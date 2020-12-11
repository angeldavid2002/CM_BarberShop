using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        public List<Reserva> reservas { get; set; }
        public string email { get; set; }
    }
}
