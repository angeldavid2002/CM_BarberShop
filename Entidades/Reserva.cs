using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Reserva:Mostrar
    {
        public int idReserva { get; set; }
        public DateTime horaReserva { get; set; }
        public List<Servicio> tipoServicio { get; set; }
        public double valorServicio { get; set; }

        public string MostrarDatos()
        {
            return "id reserva: "+idReserva+"\n"+
                    "hora reserva: "+horaReserva+"\n"+
                    "tipo servicio: "+tipoServicio+"\n"+
                    "valor servicio"+valorServicio +"";
        }
    }
}
