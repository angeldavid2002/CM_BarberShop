using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace Datos
{
    public class ConnectionManager
    {
        internal OracleConnection _conexion;
        public ConnectionManager(string connectionString)
        {
            _conexion = new OracleConnection(connectionString);
        }
        public void Open()
        {
            _conexion.Open();
        }
        public void Close()
        {
            _conexion.Close();
        }
    }
}
