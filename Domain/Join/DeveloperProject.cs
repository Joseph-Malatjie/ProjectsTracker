using Domain.User;

namespace Domain.Join;

public class DeveloperProject
{
    public int Id { get; set; }
    public Guid ProjectId { get; set; }
    public Guid UserId { get; set; }
    public Developer Developer { get; set; }
    public Project.Project Project { get; set; }
}