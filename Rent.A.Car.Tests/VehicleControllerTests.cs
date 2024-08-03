using Microsoft.Extensions.Logging;
using Moq;
using Rent.A.Car.Api.Repositories;
using Rent.A.Car.Controllers;

namespace Rent.A.Car.Tests
{
    public class VehicleControllerTests
    {
        VehicleController subject;
        Mock<IVehicicleRepository> repository;
        public VehicleControllerTests()
        {
            repository = new Mock<IVehicicleRepository>();
            subject = new VehicleController(
               Mock.Of<ILogger<VehicleController>>(),
               repository.Object
               );
        }
        [Fact]
        public async Task GETShouldReturnVehicicleList()
        {
            //ACT
            var vehicicles = await subject.Get();
            //ASSERT
            Assert.IsAssignableFrom<IEnumerable<Vehicicle>>(vehicicles);
        }

        [Fact]
        public async Task GETShouldReturnVehicicleListFromRepository()
        {
            //ARRANGE
            var expected = new List<Vehicicle>();
            repository.Setup(r => r.GetAll()).ReturnsAsync(expected);
            //ACT
            var vehicicles = await subject.Get();
            //ASSERT
            Assert.Same(expected, vehicicles);
        }
    }
}