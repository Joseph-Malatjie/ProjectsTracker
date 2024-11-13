using Domain.Dto.Queries;
using MediatR;

namespace Application.Requests.Queries.Users;

public class GetUsersQuery : IRequest<List<GetUsersDto>>
{
    
}