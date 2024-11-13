using Application.Requests.Commands.Project;
using MediatR;
using Persistence;

namespace Application.Handlers.Commands.Project;

public class AddProjectCommandHandler(DataContext context) : IRequestHandler<AddProjectCommand,Unit>
{
    public async Task<Unit> Handle(AddProjectCommand request, CancellationToken cancellationToken)
    {
        var project = new Domain.Project.Project()
        {
            ProjectId = Guid.NewGuid(),
            Name = request.Project.Name,
            Capacity = request.Project.Capacity,
            Duration = request.Project.Duration,
            Status = request.Project.Status,
            ProjectManagerFullName = request.Project.ProjectManagerFullName
        };
        
        await context.Projects.AddAsync(project, cancellationToken);
        await context.SaveChangesAsync(cancellationToken:cancellationToken);

        return Unit.Value;
    }
}