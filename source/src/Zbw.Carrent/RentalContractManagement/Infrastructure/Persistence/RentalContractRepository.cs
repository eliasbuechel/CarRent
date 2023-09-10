using Zbw.Carrent.Common.Infrastructure.Persistence;
using Zbw.Carrent.RentalContractManagement.Domain;

namespace Zbw.Carrent.RentalContractManagement.Infrastructure.Persistence
{
    public class RentalContractRepository : BaseRepository<RentalContract>, IRentalContractRepository
    {
        public RentalContractRepository(CarRentDbContext context)
            : base(context)
        {
        }
    }
}
