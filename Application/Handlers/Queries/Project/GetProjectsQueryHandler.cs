using Application.Requests.Queries.Project;
using Domain.Dto.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Handlers.Queries.Project;

public class GetProjectsQueryHandler(DataContext context) : IRequestHandler<GetProjectsQuery, List<GetProjectsDto>>
{
    public async Task<List<GetProjectsDto>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
    {
        var projects = await context.Projects.ToListAsync(cancellationToken: cancellationToken);
        
        var projectDtos = projects.Select(project => new GetProjectsDto()
        {
            ProjectId = project.ProjectId,
            Name = project.Name,
            Capacity = project.Capacity,
            Duration = project.Duration,
            Status = project.Status,
            ProjectManagerFullName = project.ProjectManagerFullName
        }).ToList();

        return projectDtos;
    }
}