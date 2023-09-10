namespace Zbw.Carrent.CarManagerment.Api.Models
{
    public record CarResponse(
            Guid Id,
        string Name,
        string Brand,
        string Type,
        string Category,
        decimal DalyFee
    );
}
