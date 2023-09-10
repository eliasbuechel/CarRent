using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.CarManagerment.Domain
{
    public class Car : Entity
    {
        public Car()
        {
            
        }
        public Car(string name, string brand, string type, string category, decimal dalyFee)
            : base(Guid.NewGuid())
        {
            Name = name;
            Brand = brand;
            Type = type;
            Category = category;
            DalyFee = dalyFee;
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

        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal DalyFee { get; set; }
    }
}
