namespace Zbw.Carrent.CarManagerment.Api.Models
{
    public record CarRequest(
            Guid Id,
        string Name,
        string Brand,
        string Type,
        string Category,
        decimal DalyFee
    );
}
