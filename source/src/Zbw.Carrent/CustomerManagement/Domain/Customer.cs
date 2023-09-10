using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.CustomerManagement.Domain
{
    public class Customer : Entity
    {
        public Customer()
        {

        }

        public Customer(string customerNr, string name, string street, string houseNumber, string postalcode, string city)
            : base(Guid.NewGuid())
        {
            CustomerNr = customerNr;
            Name = name;
            Street = street;
            HouseNumber = houseNumber;
            Postalcode = postalcode;
            City = city;
        }

        public Customer(Guid id, string customerNr, string name, string street, string houseNumber, string postalcode, string city)
            : base(id)
        {
            CustomerNr = customerNr;
            Name = name;
            Street = street;
            HouseNumber = houseNumber;
            Postalcode = postalcode;
            City = city;
        }

        public string CustomerNr { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string Postalcode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
