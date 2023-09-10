using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.CarManagerment.Domain
{
    public interface ICarRepository<TRequest, TResponse> : IBaseRepository<Car, TRequest, TResponse>
    {
        IEnumerable<TResponse> GetAll();
    }
}
