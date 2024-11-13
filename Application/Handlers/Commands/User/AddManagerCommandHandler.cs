using Application.Requests.Commands.User;
using Domain.User;
using MediatR;
using Persistence;

namespace Application.Handlers.Commands.User;

public class AddManagerCommandHandler(DataContext dataContext) : IRequestHandler<AddManagerCommand, Unit>
{
    private readonly DataContext _dataContext = dataContext;

    public async Task<Unit> Handle(AddManagerCommand request, CancellationToken cancellationToken)
    {
        var address = Helper.Addresses(request.Manager.Address);
        
        var manager = new Manager()
        {
            UserId = Guid.NewGuid(),
            FirstName = request.Manager.FirstName,
            LastName = request.Manager.LastName,
            Title = request.Manager.Title,
            Address = address,
            DateCreated = request.Manager.DateCreated,
            Gender = request.Manager.Gender,
            Initials = request.Manager.Initials,
            StartDate = request.Manager.StartDate,
            UserType = UserType.Manager
        };
        
        await dataContext.Managers.AddAsync(manager, cancellationToken);
        await dataContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}