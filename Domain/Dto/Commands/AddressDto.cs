namespace Domain.Dto.Commands;

public class AddressDto
{
    public AddressDto()
    {
        
    }
    public string StreetName { get; set; }
    public string Surburb { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
}