using Zbw.Carrent.Common.Infrastructure.Persistence;

namespace Zbw.Carrent.RentalContractManagement.Domain
{
    public interface IRentalContractRepository<in TRequest, TResponse> : IBaseRepository<RentalContract, TRequest, TResponse>
    {
        IEnumerable<TResponse> GetAll();
    }
}
