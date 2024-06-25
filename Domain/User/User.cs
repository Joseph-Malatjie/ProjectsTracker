namespace Domain.User;

public abstract class User
{
	public int Id { get; set; }
	public Guid UserId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Title { get; set; }
	public string Gender { get; set; }
	public string Initials { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime DateCreated { get; set; }
}

