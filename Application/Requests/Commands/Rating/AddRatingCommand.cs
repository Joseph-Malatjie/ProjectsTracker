using Domain.Dto.Commands;
using MediatR;

namespace Application.Requests.Commands.Rating;

public class AddRatingCommand : IRequest<Unit>
{
    public AddRatingDto Rating { get; set; }
}