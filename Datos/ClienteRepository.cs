using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class ClienteRepository
    {
        private readonly OracleConnection conexion;
        private readonly List<Cliente> clientes = new List<Cliente>();
        public ClienteRepository(ConnectionManager connection)
        {
            conexion = connection._conexion;
        }
        public int Guardar(Cliente persona)
        {
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"Insert Into cliente (identificacion,nombre,apellido,numerotelefono,edad,direccion)
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
        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "select identificacion,nombre,apellido,numerotelefono,edad,direccion from cliente";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToCliente(dataReader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
        public string VersionConexion()
        {
            return conexion.ServerVersion;
        }
        private Cliente DataReaderMapToCliente(DbDataReader dataReader)
        {
            if (!dataReader.HasRows)
            {
                return null;
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.identificacion = dataReader.GetString(0);
                cliente.nombre = dataReader.GetString(1);
                cliente.apellido = dataReader.GetString(2);
                cliente.numeroTelefono = dataReader.GetString(3);
                cliente.edad = dataReader.GetInt32(4);
                cliente.direccion = dataReader.GetString(5);
                return cliente;
            }
        }
        public Persona BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select identificacion,nombre,apellido,numerotelefono,edad,direccion from cliente where identificacion=:identificacion";
                command.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Persona persona = DataReaderMapToCliente(dataReader);
                return persona;
            }
        }


    }
}
