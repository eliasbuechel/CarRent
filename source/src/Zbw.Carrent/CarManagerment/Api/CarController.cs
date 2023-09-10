using Microsoft.AspNetCore.Mvc;
using Zbw.Carrent.CarManagerment.Api.Models;
using Zbw.Carrent.CarManagerment.Domain;

namespace Zbw.Carrent.CarManagerment.Api
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public CarController(ICarRepository<CarRequest, CarResponse> repository)
        {
            ArgumentNullException.ThrowIfNull(repository);
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<CarResponse> Get()
        {
            IEnumerable<CarResponse> carResponses = _repository.GetAll();
            return carResponses;
        }

        [HttpGet("{id}")]
        public CarResponse Get(Guid id)
        {
            CarResponse customerResponse = _repository.Get(id);
            return customerResponse;
        }

        [HttpPost]
        public CarResponse Post([FromBody] CarRequest request)
        {
            CarResponse response = _repository.Add(request);
            return response;
        }

        [HttpPut("{id}")]
        public CarResponse Put(Guid id, [FromBody] CarRequest request)
        {
            CarResponse response = _repository.Update(id, request);
            return response;
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Remove(id);
        }

        private readonly ICarRepository<CarRequest, CarResponse> _repository;
    }
}