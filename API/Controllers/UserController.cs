using Application.Requests.Commands.User;
using Application.Requests.Queries.Users;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class UserController() : BaseApiController()
{
    [HttpGet("Users")]
    public async Task<IActionResult> GetUsers() =>
        Ok(await Mediator.Send(new GetUsersQuery()));
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetUserById(Guid id) =>
        Ok(await Mediator.Send(new GetUserByIdQuery { UserId = id }));
    
    [HttpGet("developers")]
    public async Task<ActionResult> GetDevelopers() =>
        Ok(await Mediator.Send(new GetDevelopersQuery()));
    
    [HttpPost("developer")]
    public async Task<ActionResult> AddDeveloper(AddDeveloperCommand command) =>
        Ok(await Mediator.Send(command));
    
    [HttpPost("manager")]
    public async Task<ActionResult> AddManager(AddManagerCommand command) =>
        Ok(await Mediator.Send(command));
    
    [HttpPut("assign-project-to-developer")]
    public async Task<ActionResult> AssignProject(AssignProjectToDeveloperCommand command) =>
        Ok(await Mediator.Send(command));
    
}