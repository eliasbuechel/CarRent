using Microsoft.AspNetCore.Mvc;
using Zbw.Carrent.CarManagerment.Api.Models;
using Zbw.Carrent.CarManagerment.Domain;

namespace Zbw.Carrent.CarManagerment.Api
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public CarController(ICarRepository repository)
        {
            ArgumentNullException.ThrowIfNull(repository);
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<CarResponse> Get()
        {
            var customers = _repository.GetAll();
            return customers.Select(c => ConvertToCarResponse(c));
        }

        [HttpGet("{id}")]
        public CarResponse Get(Guid id)
        {
            var customer = _repository.Get(id);
            return ConvertToCarResponse(customer);
        }

        [HttpPost]
        public CarResponse Post([FromBody] CarRequest car)
        {
            var c = ConvertToCar(car);
            _repository.Add(c);
            return ConvertToCarResponse(c);
        }

        [HttpPut("{id}")]
        public CarResponse Put(Guid id, [FromBody] CarRequest request)
        {
            Car c = ConvertToCar(request);
            _repository.Update(c);
            return ConvertToCarResponse(c);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Remove(id);
        }

        private static Car ConvertToCar(CarRequest car)
        {
            return new Car(
                Guid.NewGuid(),
                car.Name,
                car.Brand,
                car.Type,
                car.Category,
                car.DalyFee
                );
        }
        private static CarResponse ConvertToCarResponse(Car car)
        {
            return new CarResponse(
                car.Id,
                car.Name,
                car.Brand,
                car.Type,
                car.Category,
                car.DalyFee
                );
        }

        private readonly ICarRepository _repository;
    }
}
