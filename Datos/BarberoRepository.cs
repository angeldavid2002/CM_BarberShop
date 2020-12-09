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
    class BarberoRepository
    {
        private readonly OracleConnection conexion;
        private readonly List<Barbero> barberos = new List<Barbero>();
        public BarberoRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }
        public int Guardar(Barbero persona)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"Insert Into barbero (identificacion,nombre,apellido,numerotelefono,edad,direccion)
                values (:identificacion,:nombre,:edad,:apellido,:direccion,:numerotelefono)";
                command.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = persona.identificacion;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = persona.nombre;
                command.Parameters.Add("apellido", OracleDbType.Varchar2).Value = persona.apellido;
                command.Parameters.Add("numerotelefono", OracleDbType.Varchar2).Value = persona.numeroTelefono;
                command.Parameters.Add("edad", OracleDbType.Decimal).Value = persona.edad;
                command.Parameters.Add("direccion", OracleDbType.Varchar2).Value = persona.direccion;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public List<Barbero> ConsultarTodos()
        {
            List<Barbero> barberos = new List<Barbero>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "select identificacion,nombre,apellido,numerotelefono,edad,direccion from barbero";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Barbero barbero = DataReaderMapToBarbero(dataReader);
                        barberos.Add(barbero);
                    }
                }
            }
            return barberos;
        }
        public string VersionConexion()
        {
            return conexion.ServerVersion;
        }
        private Barbero DataReaderMapToBarbero(DbDataReader dataReader)
        {
            if (!dataReader.HasRows)
            {
                return null;
            }
            else
            {
                Barbero barbero = new Barbero();
                barbero.identificacion = dataReader.GetString(0);
                barbero.nombre = dataReader.GetString(1);
                barbero.apellido = dataReader.GetString(2);
                barbero.numeroTelefono = dataReader.GetString(3);
                barbero.edad = dataReader.GetInt32(4);
                barbero.direccion = dataReader.GetString(5);
                return barbero;
            }
        }
        public Barbero BuscarPorIdentificacion(string identificacion)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select identificacion,nombre,apellido,numerotelefono,edad,direccion from barbero where identificacion =:identificacion ";
                command.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                var dataReader = command.ExecuteReader();
                dataReader.Read();
                Barbero barbero = DataReaderMapToBarbero(dataReader);
                return barbero;
            }
        }
        public List<Barbero> BuscarPorNombre(string nombre)
        {
            List<Barbero> barberos = new List<Barbero>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select identificacion,nombre,apellido,numerotelefono,edad,direccion from barbero where nombre =:nombre ";
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Barbero barbero = DataReaderMapToBarbero(dataReader);
                        barberos.Add(barbero);
                    }
                }
            }
            return barberos;
        }
        public int EliminarCliente(string identificacion)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"delete from barbero where identificacion=:identificacion";
                command.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
