namespace Zbw.Carrent.CustomerManagement.Api.Models
{
    public record CustomerResponse(
            Guid Id,
            string CustomerNr,
            string Name,
            string Street,
            string HouseNumber,
            string Postalcode,
            string City
    );
}
