namespace Zbw.Carrent.CustomerManagement.Api
{
    using Microsoft.AspNetCore.Mvc;

    using Zbw.Carrent.CustomerManagement.Api.Models;
    using Zbw.Carrent.CustomerManagement.Domain;

    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController(ICustomerRepository repository)
        {
            ArgumentNullException.ThrowIfNull(repository);
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<CustomerResponse> Get()
        {
            var customers = _repository.GetAll();
            return customers.Select(c => ConvertToCustomerResponse(c));
        }

        [HttpGet("{id}")]
        public CustomerResponse Get(Guid id)
        {
            var customer = _repository.Get(id);
            return ConvertToCustomerResponse(customer);
        }

        [HttpPost]
        public CustomerResponse Post([FromBody] CustomerRequest customer)
        {
            var c = new Customer(
                Guid.NewGuid(),
                customer.CustomerNr,
                customer.Name,
                customer.Street,
                customer.HouseNumber,
                customer.Postalcode,
                customer.City
                );
            
            _repository.Add(c);

            return ConvertToCustomerResponse(c);
        }

        [HttpPut("{id}")]
        public CustomerResponse Put(Guid id, [FromBody] CustomerRequest request)
        {
            Customer c = ConvertToCustomer(request);
            _repository.Update(c);
            return ConvertToCustomerResponse(c);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Remove(id);
        }


        private static Customer ConvertToCustomer(CustomerRequest customer)
        {
            return new Customer(Guid.NewGuid(), customer.CustomerNr, customer.Name, customer.Street, customer.HouseNumber, customer.Postalcode, customer.City);
        }
        private static CustomerResponse ConvertToCustomerResponse(Customer customer)
        {
            return new CustomerResponse(customer.Id, customer.CustomerNr, customer.Name, customer.Street, customer.HouseNumber, customer.Postalcode, customer.City);
        }

        private readonly ICustomerRepository _repository;
    }
}
