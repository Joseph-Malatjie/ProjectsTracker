using Application.Requests.Commands.Project;
using Application.Requests.Queries.Project;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ProjectController : BaseApiController
{
    [HttpGet("Projects")]
    public async Task<IActionResult> GetProjects() =>
        Ok(await Mediator.Send(new GetProjectsQuery())); 
    
    [HttpPost]
    public async Task<IActionResult> AddProject(AddProjectCommand command) =>
        Ok(await Mediator.Send(command)); 
}