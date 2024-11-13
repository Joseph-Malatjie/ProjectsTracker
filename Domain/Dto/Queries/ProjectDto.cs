namespace Domain.Dto.Queries;

public class ProjectDto
{
    public Guid ProjectId { get; set; }
    public string Name { get; set; }
    public string Duration { get; set; }
    public int Capacity { get; set; }
    public string Status { get; set; }
    public string ProjectManagerFullName { get; set; }
}