using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using Infraestructura;
namespace Logica
{
    public class BarberoServices
    {
        private readonly BarberoRepository barberoRepository;
        private readonly ConnectionManager connection;
        public BarberoServices(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            barberoRepository = new BarberoRepository(connection);
        }
        public RespuestaBarberos ConsultarTodos()
        {
            RespuestaBarberos respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaBarberos(barberoRepository.ConsultarTodos());
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaBarberos("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public RespuestaBarbero ConsultarIdentificacion(string identificacion)
        {
            RespuestaBarbero respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaBarbero(barberoRepository.BuscarPorIdentificacion(identificacion));
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaBarbero("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public RespuestaBarberos ConsultarNombre(string nombre)
        {
            RespuestaBarberos respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaBarberos(barberoRepository.BuscarPorNombre(nombre));
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaBarberos("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public string Guardar(Barbero barbero)
        {
            try
            {
                connection.Open();
                if (barberoRepository.BuscarPorIdentificacion(barbero.identificacion) == null)
                {
                    barberoRepository.Guardar(barbero);
                    return "Se guardaron los datos exitosamente";
                }
                else
                {
                    return "el cliente ya existe";
                }
            }
            catch (Exception e)
            {
                return "Error de la aplicacion: " + e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        public string GenerarPdf(List<Cliente> clientes, string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarPdf(clientes, filename);
                return "Se generó el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error al crear docuemnto" + e.Message;
            }
        }
        public string EliminarBarbero(String identificacion)
        {
            try
            {
                connection.Open();
                if (barberoRepository.EliminarCliente(identificacion) > 0)
                {
                    return "se eliminaron los datos exitosamente";
                }
                else
                {
                    return "el cliente no existe";
                }
            }
            catch (Exception e)
            {
                return "error de la app: " + e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
    public class RespuestaBarberos
    {
        public List<Barbero> barberos { get; set; }
        public bool listaVacia { get; set; }
        public string mensaje { get; set; }
        public RespuestaBarberos(List<Barbero> barberos)
        {
            this.barberos = barberos;
            this.listaVacia = false;
            this.mensaje = "lectura exitosa";
        }
        public RespuestaBarberos(string mensaje)
        {
            this.listaVacia = true;
            this.mensaje = mensaje;
        }
    }
    public class RespuestaBarbero
    {
        public Barbero barbero { get; set; }
        public bool listaVacia { get; set; }
        public string mensaje { get; set; }
        public RespuestaBarbero(Barbero barbero)
        {
            this.barbero = barbero;
            this.listaVacia = false;
            this.mensaje = "lectura exitosa";
        }
        public RespuestaBarbero(string mensaje)
        {
            this.listaVacia = true;
            this.mensaje = mensaje;
        }
    }
}
