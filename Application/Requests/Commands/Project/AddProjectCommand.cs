using Domain.Dto.Commands;
using MediatR;

namespace Application.Requests.Commands.Project;

public class AddProjectCommand : IRequest<Unit>
{
    public AddProjectDto Project { get; set; }
}