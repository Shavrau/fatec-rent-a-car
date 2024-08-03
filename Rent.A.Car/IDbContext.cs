using System.Data;

namespace Rent.A.Car.Api
{
    public interface IDbContext
    {
        IDbConnection GetConnection();
    }
}
