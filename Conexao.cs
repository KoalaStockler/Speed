using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SpeedlinePDV
{
    public static class Conexao
    {
        // Edit connection string in App.config or here
        public static string ConnectionString => System.Configuration.ConfigurationManager.ConnectionStrings["SpeedlineDB"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
