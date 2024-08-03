namespace Rent.A.Car.Api.Repositories
{
    public interface IVehicicleRepository
    {
        Task<IEnumerable<Vehicicle>> GetAll();
    }
}
