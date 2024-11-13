namespace Domain.Dto.Commands;

public class AddRatingDto
{
    public Guid ProjectId { get; set; }
    public Guid UserId { get; set; }
    public int Rate { get; set; }
    public string Comment { get; set; }
}