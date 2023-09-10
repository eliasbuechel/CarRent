using Microsoft.AspNetCore.Mvc;
using Zbw.Carrent.CustomerManagement.Api.Models;
using Zbw.Carrent.CustomerManagement.Domain;

namespace Zbw.Carrent.CustomerManagement.Api
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController(ICustomerRepository<CustomerRequest, CustomerResponse> repository)
        {
            ArgumentNullException.ThrowIfNull(repository);
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<CustomerResponse> Get()
        {
            IEnumerable<CustomerResponse> customers = _repository.GetAll();
            return customers;
        }

        [HttpGet("{id}")]
        public CustomerResponse Get(Guid id)
        {
            CustomerResponse response = _repository.Get(id);
            return response;
        }

        [HttpPost]
        public CustomerResponse Post([FromBody] CustomerRequest request)
        {
            CustomerResponse response = _repository.Add(request);
            return response;
        }

        [HttpPut("{id}")]
        public CustomerResponse Put(Guid id, [FromBody] CustomerRequest request)
        {
            CustomerResponse updatedCusomter = _repository.Update(id, request);
            return updatedCusomter;
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Remove(id);
        }

        private readonly ICustomerRepository<CustomerRequest, CustomerResponse> _repository;
    }
}
