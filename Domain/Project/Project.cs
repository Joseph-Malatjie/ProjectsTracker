using Domain.User;

namespace Domain.Project;

public class Project
{
	public int Id { get; set; }
	public Guid ProjectId { get; set; }
	public string Name { get; set; }
	public string Duration { get; set; }
	public int Capacity { get; set; }
	public string Status { get; set; }
	public string ProjectManagerFullName { get; set; }
	public ICollection<Developer>? Developers { get; set; }
	public ICollection<Rating.Rating>? Ratings { get; set; }
}

