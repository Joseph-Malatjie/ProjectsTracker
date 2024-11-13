using Domain.Dto.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Requests.Queries.Rating;

public class GetProjectRatingQuery : IRequest<GetRatingDto>
{
    [FromQuery] public Guid UserId { get; set; }
    [FromQuery] public Guid ProjectId { get; set; }
}