using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
        public Reserva(string idCliente,List<ServicioPrestado> servicioPrestados, Barbero barbero, DateTime diaReserva)
        {
            this.serviciosPrestados = servicioPrestados;
            this.idCliente = idCliente;
            this.Barbero = barbero;
            this.diaReserva = diaReserva;
        }
        public Reserva()
        {
        }
        public string idCliente { get; set; }
        public int idReserva { get; set; }
        public Boolean estadoAtendido { get; set; }
        public DateTime diaReserva { get; set; }
        public List<ServicioPrestado> serviciosPrestados { get; set; }
        public Barbero Barbero { get; set; }
        public double valorTotalReserva { get { return calcularValorTotal(); } set { valorTotalReserva = value; } }
        private double calcularValorTotal()
        {
            return serviciosPrestados.Sum(x=> x.valorTotal);
        }
        
    }
}
