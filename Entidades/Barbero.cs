using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Barbero:Persona
    {
        public List<Reserva> reservas {get;set;}
        public int numeroClientesAtendidos { get; set; }
        public double salario { get; set; }
        public string CalcularSalario(double pagoPorCliente)
        {
            salario = numeroClientesAtendidos * pagoPorCliente;
            reiniciarNumeroClientes();
            return "su salario el salario es de: " + salario;
        }
        public void reiniciarNumeroClientes()
        {
            this.numeroClientesAtendidos = 0;
        }

    }
}
