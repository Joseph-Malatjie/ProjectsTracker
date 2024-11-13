using Domain.Dto.Commands;

namespace Domain.Dto.Queries;

public class GetDevelopersDto
{
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string Gender { get; set; }
    public string Initials { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DateCreated { get; set; }
    public int Capacity { get; set; }
    public List<AddressDto> Addresses { get; set; }
    public List<ProjectDto>? Projects { get; set; }
}