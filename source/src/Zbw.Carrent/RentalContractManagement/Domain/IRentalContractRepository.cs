using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.RentalContractManagement.Domain
{
    public interface IRentalContractRepository<TRequest, TResponse> : IBaseRepository<RentalContract, TRequest, TResponse>
    {
        IEnumerable<TResponse> GetAll();
    }
}
