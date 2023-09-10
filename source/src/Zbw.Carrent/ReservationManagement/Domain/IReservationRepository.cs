using Zbw.Carrent.Common.Infrastructure.Persistence;

namespace Zbw.Carrent.ReservationManagement.Domain
{
    public interface IReservationRepository<in TRequest, out TResponse> : IBaseRepository<Reservation, TRequest, TResponse>
    {
        IEnumerable<TResponse> GetAll();
    }
}
