using Zbw.Carrent.Common.Infrastructure.Persistence;
using Zbw.Carrent.ReservationManagement.Api.Models;
using Zbw.Carrent.ReservationManagement.Domain;

namespace Zbw.Carrent.ReservationManagement.Infrastructure.Persistence
{
    public class ReservationRepository : BaseRepository<Reservation, ReservationRequest, ReservationResponse>, IReservationRepository<ReservationRequest, ReservationResponse>
    {
        public ReservationRepository(CarRentDbContext context) : base(context)
        {
        }
        IEnumerable<ReservationResponse> IReservationRepository<ReservationRequest, ReservationResponse>.GetAll()
        {
            throw new NotImplementedException();
        }

        protected override Func<Guid, ReservationRequest, Reservation> RequestConverter()
        {
            throw new NotImplementedException();
        }
        protected override Func<Reservation, ReservationResponse> ResponseConverter()
        {
            throw new NotImplementedException();
        }
    }
}
