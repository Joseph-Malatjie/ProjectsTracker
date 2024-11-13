using Application.Requests.Queries.Users;
using Domain.Dto.Commands;
using Domain.Dto.Queries;
using Domain.Rating;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Handlers.Queries.User;

public class GetDevelopersQueryHandler(DataContext context) : IRequestHandler<GetDevelopersQuery,List<GetDevelopersDto>>
{
    public async Task<List<GetDevelopersDto>> Handle(GetDevelopersQuery request, CancellationToken cancellationToken)
    {
        var developers = await context.Developers
                .Include(d => d.Address)
                .Include(d => d.Projects!)
                .ToListAsync(cancellationToken: cancellationToken);

        var developersDto = developers.Select(developer => new GetDevelopersDto
        {
            UserId = developer.UserId,
            FirstName = developer.FirstName,
            LastName = developer.LastName,
            Title = developer.Title,
            StartDate = developer.StartDate,
            DateCreated = developer.DateCreated,
            Addresses = developer.Address.Select(a => new AddressDto
            {
                City = a.City,
                PostalCode = a.PostalCode,
                StreetName = a.StreetName,
                Surburb = a.Surburb
            }).ToList(),
            Gender = developer.Gender,
            Initials = developer.Initials,
            Capacity = developer.Capacity,
            Projects = developer.Projects.Select(project => new ProjectDto
            {
                ProjectId = project.ProjectId,
                Name = project.Name,
                Duration = project.Duration,
                Capacity = project.Capacity,
                Status = project.Status,
                ProjectManagerFullName = project.ProjectManagerFullName
            }).ToList()
        }).ToList();

        return developersDto;
    }
}