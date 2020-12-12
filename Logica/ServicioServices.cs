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
    public class ServicioServices
    {
        private readonly ServicioRepository servicioRepository;
        private readonly ConnectionManager connection;
        public ServicioServices(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            servicioRepository = new ServicioRepository(connection);
        }
        public string Guardar(Servicio servicio)
        {
            try
            {
                connection.Open();
                if (servicioRepository.BuscarPorIdentificacion(servicio.idServicio) == null)
                {
                    servicioRepository.Guardar(servicio);
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
        public RespuestaServicios ConsultarTodos()
        {
            RespuestaServicios respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaServicios(servicioRepository.ConsultarTodos());
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaServicios("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public RespuestaServicio ConsultarIdentificacion(int identificacion)
        {
            RespuestaServicio respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaServicio(servicioRepository.BuscarPorIdentificacion(identificacion));
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaServicio("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }
        public string EliminarCliente(int identificacion)
        {
            try
            {
                connection.Open();
                if (servicioRepository.EliminarServicio(identificacion) > 0)
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
    public class RespuestaServicios
    {
        public List<Servicio> servicios { get; set; }
        public bool listaVacia { get; set; }
        public string mensaje { get; set; }
        public RespuestaServicios(List<Servicio> servicios)
        {
            this.servicios = servicios;
            this.listaVacia = false;
            this.mensaje = "lectura exitosa";
        }
        public RespuestaServicios(string mensaje)
        {
            this.listaVacia = true;
            this.mensaje = mensaje;
        }
    }
    public class RespuestaServicio
    {
        public Servicio servicio { get; set; }
        public bool listaVacia { get; set; }
        public string mensaje { get; set; }
        public RespuestaServicio(Servicio servicio)
        {
            this.servicio = servicio;
            this.listaVacia = false;
            this.mensaje = "lectura exitosa";
        }
        public RespuestaServicio(string mensaje)
        {
            this.listaVacia = true;
            this.mensaje = mensaje;
        }
    }
}
