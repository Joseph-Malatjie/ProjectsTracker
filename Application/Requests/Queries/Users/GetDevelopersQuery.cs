using Domain.Dto.Queries;
using MediatR;

namespace Application.Requests.Queries.Users;

public class GetDevelopersQuery : IRequest<List<GetDevelopersDto>>
{
    
}