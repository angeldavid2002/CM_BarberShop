using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.IO;
using Infraestructura;
namespace Logica
{
    public class ClienteService
    {

        private readonly ClienteRepository clienteRepository;
        private readonly ConnectionManager connection;
        public ClienteService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            clienteRepository = new ClienteRepository(connection);
        }
        public RespuestaClientes ConsultarTodos()
        {
            RespuestaClientes respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaClientes(clienteRepository.ConsultarTodos());
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaClientes("Error en la aplicacion: "+e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public RespuestaCliente ConsultarIdentificacion(string identificacion)
        {
            RespuestaCliente respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaCliente(clienteRepository.BuscarPorIdentificacion(identificacion));
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaCliente("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public RespuestaClientes ConsultarNombre(string nombre)
        {
            RespuestaClientes respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaClientes(clienteRepository.BuscarPorNombre(nombre));
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaClientes("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public string Guardar(Cliente cliente)
        {
            try
            {
                connection.Open();
                if (clienteRepository.BuscarPorIdentificacion(cliente.identificacion) == null)
                {
                    clienteRepository.Guardar(cliente);
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
        public string EnviarEmail(string ruta)
        {
            Email email = new Email();
            string mensajeEmail;
            string correo = "anyambolano@unicesar.edu.co";
            try
            {
                mensajeEmail = email.EnviarEmail(correo,ruta);
                return "se envio el email exitosamente " + mensajeEmail;
            }
            catch (Exception e)
            {
                return "error en la app: "+e.Message;
            }
        }
        public string GenerarPdf(List<Cliente> clientes, string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarPdf(clientes,filename);
                return "Se generó el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error al crear docuemnto" + e.Message;
            }
        }
        public string EliminarCliente(String identificacion)
        {
            try
            {
                connection.Open();
                if (clienteRepository.EliminarCliente(identificacion) > 0)
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
    public class RespuestaClientes{
        public List<Cliente> clientes { get; set; }
        public bool listaVacia { get; set; }
        public string mensaje { get; set; }
        public RespuestaClientes(List<Cliente> clientes)
        {
            this.clientes = clientes;
            this.listaVacia = false;
            this.mensaje = "lectura exitosa";
        }
        public RespuestaClientes(string mensaje)
        {
            this.listaVacia = true;
            this.mensaje = mensaje;
        }
    }
    public class RespuestaCliente
    {
        public Cliente cliente { get; set; }
        public bool listaVacia { get; set; }
        public string mensaje { get; set; }
        public RespuestaCliente(Cliente cliente)
        {
            this.cliente = cliente;
            this.listaVacia = false;
            this.mensaje = "lectura exitosa";
        }
        public RespuestaCliente(string mensaje)
        {
            this.listaVacia = true;
            this.mensaje = mensaje;
        }
    }

}
