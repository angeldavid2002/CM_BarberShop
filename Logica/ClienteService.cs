using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
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
        public string ServerVersion()
        {
            try
            {
                connection.Open();
                return clienteRepository.VersionConexion();
            }
            catch (Exception e)
            {
                return "error en la app: " + e.Message;
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
}
