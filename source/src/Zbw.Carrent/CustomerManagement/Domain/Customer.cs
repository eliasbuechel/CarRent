using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.CustomerManagement.Domain
{
    public class Customer : Entity
    {
        public Customer()
        {

        }

        public Customer(Guid id, string customerNr, string name, string street, string houseNumber, string postalcode, string city)
            : base(id)
        {
            Id = Guid.NewGuid();
            CustomerNr = customerNr;
            Name = name;
            Street = street;
            HouseNumber = houseNumber;
            Postalcode = postalcode;
            City = city;
        }

        public string CustomerNr { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
    }
}
