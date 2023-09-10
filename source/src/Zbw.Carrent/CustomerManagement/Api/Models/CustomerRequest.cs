namespace Zbw.Carrent.CustomerManagement.Api.Models
{
    public record CustomerRequest(
            string CustomerNr,
            string Name,
            string Street,
            string HouseNumber,
            string Postalcode,
            string City
    );
}