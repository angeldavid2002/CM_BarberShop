using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Barbero:Persona,Mostrar
    {
        public List<Reserva> reservas {get;set;}
        public int numeroClientesAtendidos { get; set; }
        public double salario { get; set; }
        public string MostrarDatos()
        {
            return "nombre: " + nombre + "\n" +
                    "apellido: " + apellido + "\n" +
                    "identificacion: " + identificacion + "\n" +
                    "numero telefono: " + numeroTelefono + "\n" +
                    "edad: " + edad + "\n" +
                    "direccion: " + direccion + "\n"+
                    "numero clientes atendidos: "+numeroClientesAtendidos+"\n"+
                    "salario: "+salario+"";
        }
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
