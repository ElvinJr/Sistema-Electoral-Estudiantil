using System;
using System.Data.SqlClient;

namespace Conexion
{
    public class Servidor
    {
        private readonly string _connectionString;

        public Servidor()
        {
            // Conexión típica con Windows Authentication
            _connectionString = @"Data Source=DESKTOP-VE5IE91\SQLEXPRESS01;Initial Catalog=Votacion;Integrated Security=True;MultipleActiveResultSets=True;";
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public SqlConnection OpenConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
