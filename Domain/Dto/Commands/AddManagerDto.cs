namespace Domain.Dto.Commands;

public class AddManagerDto
{
    public AddManagerDto()
    {
        
    }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string Gender { get; set; }
    public string Initials { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DateCreated { get; set; }
    public List<AddressDto> Address { get; set; }
}