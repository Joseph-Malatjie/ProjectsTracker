namespace Domain.Rating;

public class Rating
{
	public int Id { get; set; }
	public Guid RateId { get; set; }
	public Guid UserId { get; set; }
	public int Rate { get; set; }
	public string Comment { get; set; }
	public Project.Project Project { get; set; }
}