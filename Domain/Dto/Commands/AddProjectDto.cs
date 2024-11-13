namespace Domain.Dto.Commands;

public class AddProjectDto
{
    public string Name { get; set; }
    public string Duration { get; set; }
    public int Capacity { get; set; }
    public string Status { get; set; }
    public string ProjectManagerFullName { get; set; }
}