namespace Domain.User;

public class Developer : User
{
	public int Id { get; set; }
	public int Capacity { get; set; }
	public ICollection<Project.Project>? Projects { get; set; }
}

