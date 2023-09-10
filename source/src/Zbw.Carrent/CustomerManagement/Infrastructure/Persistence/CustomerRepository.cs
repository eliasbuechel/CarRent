namespace Zbw.Carrent.CustomerManagement.Infrastructure.Persistence
{
    using System;
    using System.Collections.Generic;
    using Zbw.Carrent.Common.Infrastructure.Persistence;
    using Zbw.Carrent.CustomerManagement.Domain;

    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CarRentDbContext context)
            : base(context)
        {
            _customers = new List<Customer>()
            {
                //new("C00001", "Hans"),
                //new("C00002", "Fritz")
            };

        }

        private readonly List<Customer> _customers;
    }
}
