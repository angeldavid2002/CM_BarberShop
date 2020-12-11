﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
        public Reserva(string idCliente,ServicioPrestado servicioPrestado, Barbero barbero, DateTime diaReserva, int cantidadServicio)
        {
            this.idCliente = idCliente;
            this.servicioPrestado = servicioPrestado;
            this.Barbero = barbero;
            this.diaReserva = diaReserva;
            this.cantidadServicio = cantidadServicio;
        }
        public string idCliente { get; set; }
        public int idReserva { get; set; }
        public Boolean estadoAtendido { get; set; }
        public DateTime diaReserva { get; set; }
        public ServicioPrestado servicioPrestado { get; set; }
        public int cantidadServicio { get; set; }
        public double valorTotalReserva { get { return valorTotalReserva = cantidadServicio * servicioPrestado.valorMomento; } set { valorTotalReserva = value; } }
        public Barbero Barbero { get; set; }
    }
}
