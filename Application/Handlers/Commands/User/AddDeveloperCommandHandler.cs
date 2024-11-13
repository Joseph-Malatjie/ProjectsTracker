using Application.Requests.Commands.User;
using Domain.User;
using MediatR;
using Persistence;

namespace Application.Handlers.Commands.User;

public class AddDeveloperCommandHandler(DataContext dataContext) : IRequestHandler<AddDeveloperCommand,Unit>
{
    public async Task<Unit> Handle(AddDeveloperCommand request, CancellationToken cancellationToken)
    {
        var address = Helper.Addresses(request.Developer.Address);

        var developer = new Developer
        {
            UserId = Guid.NewGuid(),
            FirstName = request.Developer.FirstName,
            LastName = request.Developer.LastName,
            Title = request.Developer.Title,
            Address = address,
            Capacity = request.Developer.Capacity,
            DateCreated = request.Developer.DateCreated,
            Gender = request.Developer.Gender,
            Initials = request.Developer.Initials,
            StartDate = request.Developer.StartDate,
            UserType = UserType.Developer
        };
        
        await dataContext.Developers.AddAsync(developer, cancellationToken);
        await dataContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
    
}