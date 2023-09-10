using Zbw.Carrent.CarManagerment.Api.Models;
using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.Common.Infrastructure.Persistence;

namespace Zbw.Carrent.CarManagerment.Infrastructure.Persistence
{
    public class CarRepository : BaseRepository<Car, CarRequest, CarResponse>, ICarRepository<CarRequest, CarResponse>
    {
        public CarRepository(CarRentDbContext context) : base(context)
        {
        }

        IEnumerable<CarResponse> ICarRepository<CarRequest, CarResponse>.GetAll()
        {
            return base.GetAll();
        }

        protected override Func<Guid, CarRequest, Car> RequestConverter()
        {
            return (id, c) => new Car(
                id,
                c.Name,
                c.Brand,
                c.Type,
                c.Category,
                c.DalyFee
                );
        }
        protected override Func<Car, CarResponse> ResponseConverter()
        {
            return c => new CarResponse(
                c.Id,
                c.Name,
                c.Brand,
                c.Type,
                c.Category,
                c.DalyFee
                );
        }

    }
}
