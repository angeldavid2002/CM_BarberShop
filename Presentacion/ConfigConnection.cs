using System.Configuration;
namespace Presentacion
{
    public static class ConfigConnection
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["CNX_BARBERO"].ConnectionString;
    }
}
