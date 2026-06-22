using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics;

namespace Pulperia.Data
{
    public class DbContext
    {
        private readonly string? _connectionString;



        /*public DbContext(string rutaBaseDatos)
        {


            if (string.IsNullOrWhiteSpace(rutaBaseDatos))
                throw new ArgumentNullException(nameof(rutaBaseDatos), "La base de datos no ha sido configurada.");


            _connectionString = $"Data Source={rutaBaseDatos};";

        }*/


        public DbContext(string connectionString) 
        {
            _connectionString = connectionString;
        }


        

        public IDbConnection ObtenerConexion()
        {

            

            var connection = new SqliteConnection(_connectionString);

            connection.Open();

            Debug.WriteLine($"==> CONECTADO A: {Path.GetFullPath(connection.DataSource)}");


            using (var command = connection.CreateCommand())
            {
                command.CommandText = "PRAGMA foreign_keys = ON;";

                command.ExecuteNonQuery();


            }


            return connection;
        }

    }
}
