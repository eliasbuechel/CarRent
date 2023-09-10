using Zbw.Carrent.Common.Infrastructure.Persistence;

namespace Zbw.Carrent.CustomerManagement.Domain
{
    public interface ICustomerRepository<in TRequest, out TResponse> : IBaseRepository<Customer, TRequest, TResponse>
    {
        IEnumerable<TResponse>GetAll();
    }
}