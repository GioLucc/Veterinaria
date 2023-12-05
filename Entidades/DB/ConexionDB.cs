using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.DB
{
    public abstract class ConexionDB
    {
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string _connectionString;

        static ConexionDB()
        {
            _connectionString = "Server=.;Database=Veterinaria;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);

            _command = _connection.CreateCommand();
            _command.CommandType = CommandType.Text;
            

        }
        protected static SqlConnection ObtenerConexion()
        {
            return _connection;
        }
    }
}
