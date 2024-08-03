using Dapper;

namespace Rent.A.Car.Api.Repositories
{
    public class VehicicleRepository : IVehicicleRepository
    {
        private readonly IDbContext db;
        public VehicicleRepository(IDbContext db) 
        {
            this.db = db;
        }
        public async Task<IEnumerable<Vehicicle>> GetAll()
        {
            using var conexao = db.GetConnection();
            return await conexao.QueryAsync<Vehicicle>("SELECT * FROM Vehicle");
        }
    }
}
