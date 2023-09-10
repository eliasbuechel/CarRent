using Zbw.Carrent.CarManagerment.Api.Models;
using Zbw.Carrent.CustomerManagement.Api.Models;

namespace Zbw.Carrent.RentalContractManagement.Api.Models
{
    public record RentalContractResponse(
        Guid Id,
        int DurationInDays,
        decimal Cost,
        CustomerResponse Customer,
        CarResponse Car
    );
}
