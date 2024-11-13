using Application.Requests.Commands.User;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Handlers.Commands.User;

public class AssignProjectToDeveloperCommandHandler(DataContext context) : IRequestHandler<AssignProjectToDeveloperCommand,Unit>
{
    public async Task<Unit> Handle(AssignProjectToDeveloperCommand request, CancellationToken cancellationToken)
    {
        var Project = await context.Projects.FirstOrDefaultAsync(p => p.ProjectId == request.ProjectId, cancellationToken: cancellationToken);

        var Developer = await context.Developers.FirstOrDefaultAsync(d => d.UserId == request.UserId , cancellationToken: cancellationToken);
        
        Developer.Projects ??= new List<Domain.Project.Project>();
        
        Developer.Projects.Add(Project);
        Developer.Capacity -= Project.Capacity;
        
        if(Developer.Capacity < 0)
            throw new Exception("Developer capacity exceeded");
        
        await context.SaveChangesAsync(cancellationToken: cancellationToken);
        
        return Unit.Value;
    }
}