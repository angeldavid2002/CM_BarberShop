using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Logica
{
    public class ReservaService
    {
        private readonly ReservaRepository reservaRepository;
        private readonly ConnectionManager connection;
        public ReservaService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            reservaRepository = new ReservaRepository(connection);
        }

        public RespuestaReservas ConsultarTodos()
        {
            RespuestaReservas respuesta;
            try
            {
                connection.Open();
                respuesta = new RespuestaReservas(reservaRepository.ConsultarTodos());
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta = new RespuestaReservas("Error en la aplicacion: " + e.Message);
                return respuesta;
            }
            finally
            {
                connection.Close();
            }
        }

    }
    public class RespuestaReservas
    {
        public List<Reserva> reservas { get; set; }
        public bool listaVacia { get; set; }
        public string mensaje { get; set; }
        public RespuestaReservas(List<Reserva> reservas)
        {
            this.reservas = reservas;
            this.listaVacia = false;
            this.mensaje = "lectura exitosa";
        }
        public RespuestaReservas(string mensaje)
        {
            this.listaVacia = true;
            this.mensaje = mensaje;
        }
    }
}
