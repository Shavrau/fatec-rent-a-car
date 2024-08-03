using Microsoft.AspNetCore.Mvc;
using Rent.A.Car.Api.Repositories;

namespace Rent.A.Car.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly ILogger<VehicleController> logger;
    private readonly IVehicicleRepository vehicicleRepository;

    public VehicleController(ILogger<VehicleController> logger, IVehicicleRepository vehicicleRepository)
    {
        this.logger = logger;
        this.vehicicleRepository = vehicicleRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Vehicicle>> Get()
    {
        logger.LogInformation("Get executado com sucesso");
        return await vehicicleRepository.GetAll();
    }
}
