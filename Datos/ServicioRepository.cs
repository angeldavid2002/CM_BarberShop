using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;
using Entidades;
namespace Datos
{
    public class ServicioRepository
    {
        private readonly OracleConnection conexion;
        private readonly List<Barbero> barberos = new List<Barbero>();
        public ServicioRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }
        public int Guardar(Servicio servicio)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"Insert Into servicio (IDSERVICIO,NOMBRESERVICIO,DESCRIPCIONSERVICIO,VALORSERVICIO)
                values (:IDSERVICIO,:nombre,:descripcion,:valor)";
                command.Parameters.Add("IDSERVICIO", OracleDbType.Double).Value = servicio.idServicio;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = servicio.nombreServicio;
                command.Parameters.Add("descripcion", OracleDbType.Varchar2).Value = servicio.descripcionServicio;
                command.Parameters.Add("valor", OracleDbType.Varchar2).Value = servicio.valorServicio;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public List<Servicio> ConsultarTodos()
        {
            List<Servicio> servicios = new List<Servicio>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "select IDSERVICIO,NOMBRESERVICIO,DESCRIPCIONSERVICIO,VALORSERVICIO from servicio";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Servicio servicio = DataReaderMapToServicio(dataReader);
                        servicios.Add(servicio);
                    }
                }
            }
            return servicios;
        }
        public Servicio BuscarPorIdentificacion(int identificacion)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select IDSERVICIO,NOMBRESERVICIO,DESCRIPCIONSERVICIO,VALORSERVICIO from servicio where IDSERVICIO =:identificacion ";
                command.Parameters.Add("identificacion", OracleDbType.Int32).Value = identificacion;
                var dataReader = command.ExecuteReader();
                dataReader.Read();
                Servicio servicio = DataReaderMapToServicio(dataReader);
                return servicio;
            }
        }
        private Servicio DataReaderMapToServicio(DbDataReader dataReader)
        {
            if (!dataReader.HasRows)
            {
                return null;
            }
            else
            {
                Servicio servicio = new Servicio();
                servicio.idServicio= dataReader.GetInt32(0);
                servicio.nombreServicio = dataReader.GetString(1);
                servicio.descripcionServicio = dataReader.GetString(2);
                servicio.valorServicio = dataReader.GetDouble(3);
                return servicio;
            }
        }

        public int EliminarServicio(int identificacion)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"delete from servicio where IDSERVICIO=:identificacion";
                command.Parameters.Add("identificacion", OracleDbType.Double).Value =Convert.ToInt32(identificacion);
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

    }
}
