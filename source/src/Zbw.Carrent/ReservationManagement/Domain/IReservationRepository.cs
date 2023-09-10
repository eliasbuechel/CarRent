using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.ReservationManagement.Domain
{
    public interface IReservationRepository<TRequest, TResponse> : IBaseRepository<Reservation, TRequest, TResponse>
    {
        IEnumerable<TResponse> GetAll();
    }
}
