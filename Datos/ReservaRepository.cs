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
        private readonly BarberoRepository barberoRepository;
        public ReservaRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
            barberoRepository = new BarberoRepository(connection);
        }
        public int Guardar(Reserva reserva)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"Insert Into reserva (IDRESERVA,DIARESERVA,VALORTOTALRESERVA,BARBERO_IDENTIFICACION,CLIENTE_IDENTIFICACION,ESTADO)
                values (:IDRESERVA,:DIARESERVA,:VALORTOTALRESERVA,:BARBERO_IDENTIFICACION,:CLIENTE_IDENTIFICACION,:ESTADO)";
                command.Parameters.Add("IDRESERVA", OracleDbType.Double).Value = reserva.idReserva;
                command.Parameters.Add("DIARESERVA", OracleDbType.Date).Value = reserva.diaReserva;
                command.Parameters.Add("VALORTOTALRESERVA", OracleDbType.Double).Value = reserva.valorTotalReserva;
                command.Parameters.Add("BARBERO_IDENTIFICACION", OracleDbType.Varchar2).Value = reserva.Barbero.identificacion;
                command.Parameters.Add("CLIENTE_IDENTIFICACION", OracleDbType.Varchar2).Value = reserva.idCliente;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public List<Reserva> ConsultarTodos()
        {
            List<Reserva> reservas = new List<Reserva>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "select IDRESERVA,DIARESERVA,VALORTOTALRESERVA,BARBERO_IDENTIFICACION,CLIENTE_IDENTIFICACION,ESTADO from reserva";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Reserva reserva = DataReaderMapToReserva(dataReader);
                        reservas.Add(reserva);
                    }
                }
            }
            return reservas;
        }
        public Reserva BuscarPorIdentificacion(string identificacion)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select IDRESERVA,DIARESERVA,VALORTOTALRESERVA,BARBERO_IDENTIFICACION,CLIENTE_IDENTIFICACION,ESTADO from reserva where IDRESERVA =:identificacion ";
                command.Parameters.Add("identificacion", OracleDbType.Double).Value = identificacion;
                var dataReader = command.ExecuteReader();
                dataReader.Read();
                Reserva reserva = DataReaderMapToReserva(dataReader);
                return reserva;
            }
        }

        private Reserva DataReaderMapToReserva(DbDataReader dataReader)
        {
            if (!dataReader.HasRows)
            {
                return null;
            }
            else
            {
                Reserva reserva = new Reserva();
                reserva.idReserva = dataReader.GetInt32(0);
                reserva.diaReserva = dataReader.GetDateTime(1);
                reserva.valorTotalReserva = dataReader.GetDouble(2);
                reserva.Barbero = barberoRepository.BuscarPorIdentificacion(dataReader.GetString(3));
                reserva.idCliente = dataReader.GetString(4);
                reserva.serviciosPrestados = null;
                reserva.estadoAtendido = dataReader.GetBoolean(6);
                return reserva;
            }
        }

    }
}
