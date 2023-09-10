using Zbw.Carrent.Common.Infrastructure.Persistence;
using Zbw.Carrent.CustomerManagement.Api.Models;
using Zbw.Carrent.CustomerManagement.Domain;

namespace Zbw.Carrent.CustomerManagement.Infrastructure.Persistence
{
    public class CustomerRepository : BaseRepository<Customer, CustomerRequest, CustomerResponse>, ICustomerRepository<CustomerRequest, CustomerResponse>
    {
        public CustomerRepository(CarRentDbContext context)
        : base(context)
        {}

        IEnumerable<CustomerResponse> ICustomerRepository<CustomerRequest, CustomerResponse>.GetAll()
        {
            return base.GetAll();
        }

        protected override Func<Guid, CustomerRequest, Customer> RequestConverter()
        {
            return (Guid id, CustomerRequest request) => new Customer(id, request.CustomerNr, request.Name, request.Street, request.HouseNumber, request.Postalcode, request.City);
        }
        protected override Func<Customer, CustomerResponse> ResponseConverter()
        {
            return c => new CustomerResponse(c.Id, c.CustomerNr, c.Name, c.Street, c.HouseNumber, c.Postalcode, c.City);
        }
    }
}