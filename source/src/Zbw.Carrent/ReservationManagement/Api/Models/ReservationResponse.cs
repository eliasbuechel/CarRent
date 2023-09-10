using Zbw.Carrent.CarManagerment.Domain;
using Zbw.Carrent.CustomerManagement.Domain;

namespace Zbw.Carrent.ReservationManagement.Api.Models
{
    public record ReservationResponse(
        Guid Id,
        int DurationInDays,
        decimal Cost,
        Customer Customer,
        Car Car
    );
}
