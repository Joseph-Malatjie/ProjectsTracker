using Application.Requests.Commands;
using MediatR;
using Persistence;

namespace Application.Handlers.Commands.User;

public class AddUserCommandHandler(DataContext dataContext) : IRequestHandler<AddDeveloperCommand,Unit>
{
    public async Task<Unit> Handle(AddDeveloperCommand request, CancellationToken cancellationToken)
    {
        await dataContext.Users.AddAsync(request.Developer, cancellationToken);
        await dataContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}