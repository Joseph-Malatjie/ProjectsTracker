namespace Domain.Address;

public class Address
{
	public int Id { get; set; }
	public Guid AddressId { get; set; }
	public string StreetName { get; set; }
	public string Surburb { get; set; }
	public string City { get; set; }
	public string PostalCode { get; set; }
}	

