using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;
namespace Datos
{
    public class ReservaRepository
    {
        private readonly OracleConnection conexion;
        private readonly List<Reserva> reservas = new List<Reserva>();
        public ReservaRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }
        public int Guardar(Reserva reserva)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"Insert Into reserva (IDRESERVA,DIARESERVA,CANTIDADSERVICIO,VALORTOTALRESERVA,BARBERO_IDENTIFICACION,CLIENTE_IDENTIFICACION,SERVICIOPRESTADO_IDSERVICIOPRESTADO,ESTADO)
                values (:IDRESERVA,:DIARESERVA,:CANTIDADSERVICIO,:VALORTOTALRESERVA,:BARBERO_IDENTIFICACION,:CLIENTE_IDENTIFICACION,:SERVICIOPRESTADO_IDSERVICIOPRESTADO,:ESTADO)";
                command.Parameters.Add("IDRESERVA", OracleDbType.Double).Value = reserva.idReserva;
                command.Parameters.Add("DIARESERVA", OracleDbType.Date).Value = reserva.diaReserva;
                command.Parameters.Add("CANTIDADSERVICIO", OracleDbType.Double).Value = reserva.cantidadServicio;
                command.Parameters.Add("VALORTOTALRESERVA", OracleDbType.Double).Value = reserva.valorTotalReserva;
                command.Parameters.Add("BARBERO_IDENTIFICACION", OracleDbType.Varchar2).Value = reserva.Barbero.identificacion;
                command.Parameters.Add("CLIENTE_IDENTIFICACION", OracleDbType.Varchar2).Value = reserva.idCliente;
                command.Parameters.Add("CLIENTE_IDENTIFICACIONSERVICIOPRESTADO_IDSERVICIOPRESTADO", OracleDbType.Double).Value = reserva.servicioPrestado.idServicioPrestado;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


    }
}
