namespace Zbw.Carrent.RentalContractManagement.Api.Models
{
    public record RentalContractRequest(
        int DurationInDays,
        decimal Cost,
        Guid CustomerId,
        Guid CarId
    );
}