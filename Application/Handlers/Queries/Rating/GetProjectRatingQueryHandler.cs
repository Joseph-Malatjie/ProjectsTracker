using Application.Requests.Queries.Rating;
using Domain.Dto.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Handlers.Queries.Rating;

public class GetProjectRatingQueryHandler(DataContext context) : IRequestHandler<GetProjectRatingQuery,GetRatingDto>
{
    public async Task<GetRatingDto> Handle(GetProjectRatingQuery request, CancellationToken cancellationToken)
    {
        var rating = await context.Ratings
            .FirstOrDefaultAsync(r => r.UserId == request.UserId && r.Project.ProjectId == request.ProjectId, cancellationToken: cancellationToken);

        if (rating == null)
            return new GetRatingDto();
        
        var ratingDto = new GetRatingDto
        {
            Rate = rating.Rate,
            Comment = rating.Comment
        };

        return ratingDto;
    }
}