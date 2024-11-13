using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Requests.Commands.User;

public class AssignProjectToDeveloperCommand : IRequest<Unit>
{
    [FromQuery] public Guid ProjectId { get; set; }
    [FromQuery] public Guid UserId { get; set; }
}