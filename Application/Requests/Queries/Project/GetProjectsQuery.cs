using Domain.Dto.Queries;
using MediatR;

namespace Application.Requests.Queries.Project;

public class GetProjectsQuery : IRequest<List<GetProjectsDto>>;