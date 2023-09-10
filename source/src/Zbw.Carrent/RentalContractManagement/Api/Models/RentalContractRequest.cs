using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.CustomerManagement.Domain;

namespace Zbw.Carrent.RentalContractManagement.Api.Models
{
    public record RentalContractRequest(
        Guid Id,
        int DurationInDays,
        decimal Cost,
        Customer Customer,
        Car Car
    );
}
