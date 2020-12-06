using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura;
using Entidades;
using Datos;
namespace Logica
{
    public class PersonaService
    {
        PersonaRepository personaRepository = new PersonaRepository();
        public string EnviarEmail(Cliente persona)
        {
            Email email = new Email();
            string mensajeEmail = "disculpe la demora profe";
            try
            {
                mensajeEmail = email.EnviarEmail(persona);
                return "se guardaron los datos satisfactoriamente de " + persona.nombre + " y se envio desde su email: " + persona.email;
            }
            catch (Exception e)
            {
                return "error datos: " + e.Message;
            }
        }
    }
}
