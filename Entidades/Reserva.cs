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
        public double valorReserva { get; set; }
        public Barbero barbero { get; set; }

        public string MostrarDatos()
        {
            return "id reserva: "+idReserva+"\n"+
                    "hora reserva: "+horaReserva+"\n"+
                    "valor Reserva: "+valorReserva +"\n"+
                    "nombre Barbero: "+barbero+"";
        }
    }
}
