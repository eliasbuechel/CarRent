using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.Common.Infrastructure.Persistence;

namespace Zbw.Carrent.CarManagerment.Infrastructure.Persistence
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(CarRentDbContext context) : base(context)
        {
        }
    }
}
