using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.CarManagerment.Domain
{
    public class Car : Entity
    {
        public Car()
        {
            
        }
        public Car(Guid id, string name, string brand, string type, string category, decimal dalyFee)
            : base(id)
        {
            Name = name;
            Brand = brand;
            Type = type;
            Category = category;
            DalyFee = dalyFee;
        }

        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public decimal DalyFee { get; set; }
    }
}
