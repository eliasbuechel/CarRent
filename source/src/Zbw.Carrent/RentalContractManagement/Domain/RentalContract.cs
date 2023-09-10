using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.Common.Domain;
using Zbw.Carrent.CustomerManagement.Domain;

namespace Zbw.Carrent.RentalContractManagement.Domain
{
    public class RentalContract : Entity
    {
        public RentalContract()
        {
            
        }
        public RentalContract(Guid id, int durationInDays, decimal cost, Customer customer, Car car)
            : base(id)
        {
            DurationInDays = durationInDays;
            Cost = cost;
            Customer = customer;
            Car = car;
        }

        public int DurationInDays { get; set; }
        public decimal Cost { get; set; }
        public virtual Customer Customer { get; set; } = new Customer();
        public virtual Car Car { get; set; } = new Car();
    }
}
