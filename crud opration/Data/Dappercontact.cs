using System.Data;                      // Provides interfaces for database access (IDbConnection)
using Microsoft.Data.SqlClient;         // SQL Server database connectivity using ADO.NET
using Microsoft.Extensions.Configuration;  // Used to access configuration settings (appsettings.json)

namespace crud_opration.Data  // Namespace for organizing database-related classes
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;  // Holds configuration settings
        private readonly string _connectionString;       // Stores database connection string

        // Constructor: Injects IConfiguration to access appsettings.json
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        // Method: Creates and returns a new SQL database connection
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
