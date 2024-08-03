using Microsoft.Data.SqlClient;
using System.Data;

namespace Rent.A.Car.Api
{
    public class DapperDbContext : IDbContext
    {
        private readonly string? connectionString;

        public DapperDbContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("RentConnection");
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
