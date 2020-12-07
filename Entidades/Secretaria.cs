using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Secretaria:Persona,Mostrar
    {
        public Secretaria()
        {

        }
        public string user { get; set; }
        public string contraseña { get; set; }

        public string MostrarDatos()
        {
            return "nombre: " + nombre + "\n" +
                    "apellido: " + apellido + "\n" +
                    "identificacion: " + identificacion + "\n" +
                    "numero telefono: " + numeroTelefono + "\n" +
                    "edad: " + edad + "\n" +
                    "direccion: " + direccion + "";
        }
        public string ValidarUsuario(string user, string contraseña)
        {
            if (this.user.Equals(user))
            {
                if (this.contraseña.Equals(contraseña))
                {
                    return "logueo exitoso";
                }
                else
                {
                    return "contraseña incorrecta";
                }
            }
            else
            {
                return "usuario incorrecto";
            }
        }
        public String CambiarContraseña(string nuevaContraseña)
        {
            this.contraseña = contraseña;
            return "se cambio contraseña exitosamente";
        }
    }
}
