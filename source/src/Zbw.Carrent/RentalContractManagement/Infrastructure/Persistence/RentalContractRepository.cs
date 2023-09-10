using Zbw.Carrent.Common.Infrastructure.Persistence;
using Zbw.Carrent.CustomerManagement.Api.Models;
using Zbw.Carrent.CustomerManagement.Domain;
using Zbw.Carrent.RentalContractManagement.Api.Models;
using Zbw.Carrent.RentalContractManagement.Domain;

namespace Zbw.Carrent.RentalContractManagement.Infrastructure.Persistence
{
    public class RentalContractRepository : BaseRepository<RentalContract, RentalContractRequest, RentalContractResponse>, IRentalContractRepository<RentalContractRequest, RentalContractResponse>
    {
        public RentalContractRepository(CarRentDbContext context)
            : base(context)
        {
        }

        IEnumerable<RentalContractResponse> IRentalContractRepository<RentalContractRequest, RentalContractResponse>.GetAll()
        {
            return GetAll(c => c.Car, c => c.Customer);
        }

        protected override Func<Guid, RentalContractRequest, RentalContract> RequestConverter()
        {
            throw new NotImplementedException();
        }
        protected override Func<RentalContract, RentalContractResponse> ResponseConverter()
        {
            throw new NotImplementedException();
        }
    }
}