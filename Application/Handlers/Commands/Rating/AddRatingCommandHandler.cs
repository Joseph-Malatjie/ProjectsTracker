using Application.Requests.Commands.Rating;
using MediatR;
using Persistence;

namespace Application.Handlers.Commands.Rating;

public class AddRatingCommandHandler(DataContext context) : IRequestHandler<AddRatingCommand,Unit>
{
    public async Task<Unit> Handle(AddRatingCommand request, CancellationToken cancellationToken)
    {
        var project = context.Projects.FirstOrDefault(p => p.ProjectId == request.Rating.ProjectId);
        
        if(project == null)
            throw new Exception("Project not found");

        var Rating = new Domain.Rating.Rating()
        {
            RateId = Guid.NewGuid(),
            Rate = request.Rating.Rate,
            Comment = request.Rating.Comment,
            Project = project,
            UserId = request.Rating.UserId
        };
        
        await context.Ratings.AddAsync(Rating, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}