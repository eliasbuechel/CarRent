using Zbw.Carrent.Common.Infrastructure.Persistence;
using Zbw.Carrent.ReservationManagement.Domain;

namespace Zbw.Carrent.ReservationManagement.Infrastructure.Persistence
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(CarRentDbContext context) : base(context)
        {
        }
    }
}
