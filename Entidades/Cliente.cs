using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona,Mostrar
    {
        public List<Reserva> reservas { get; set; }
        public string MostrarDatos()
        {
            return "nombre: " + nombre + "\n" +
                    "apellido: " + apellido + "\n" +
                    "identificacion: " + identificacion + "\n" +
                    "numero telefono: " + numeroTelefono + "\n" +
                    "edad: " + edad + "\n" +
                    "direccion: " + direccion + "";
        }
        public Cliente()
        {
                
        }
    }
}
