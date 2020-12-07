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
        public string Guardar(Cliente cliente)
        {
            try
            {
                connection.Open();
                if (clienteRepository.BuscarPorIdentificacion(cliente.identificacion)==null)
                {
                    return "Secretaria guardaron los datos exitosamente";
                }
                else
                {
                    return "el cliente ya existe";
                }
            }
            catch (Exception e)
            {
                return "Error de la aplicacion: "+e.Message;
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
                return "error en la app: "+e.Message;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
