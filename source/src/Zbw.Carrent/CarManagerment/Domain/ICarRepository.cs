using Zbw.Carrent.Common.Infrastructure.Persistence;

namespace Zbw.Carrent.CarManagerment.Domain
{
    public interface ICarRepository<in TRequest, out TResponse> : IBaseRepository<Car, TRequest, TResponse>
    {
        IEnumerable<TResponse> GetAll();
    }
}
