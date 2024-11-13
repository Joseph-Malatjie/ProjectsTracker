using Domain.Dto.Queries;
using MediatR;

namespace Application.Requests.Queries.Users;

public class GetUserByIdQuery : IRequest<GetUserByIdDto>
{
    public Guid UserId { get; set; }
}