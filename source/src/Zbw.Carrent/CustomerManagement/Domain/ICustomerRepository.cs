using Azure;
using Zbw.Carrent.Common.Domain;
using Zbw.Carrent.CustomerManagement.Api.Models;

namespace Zbw.Carrent.CustomerManagement.Domain
{
    public interface ICustomerRepository<TRequest, TResponse> : IBaseRepository<Customer, TRequest, TResponse>
    {
        IEnumerable<TResponse>GetAll();
    }
}