using Application.Requests.Queries.Users;
using Domain.Dto.Commands;
using Domain.Dto.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Handlers.Queries.User;

public class GetUsersQueryHandler(DataContext context) : IRequestHandler<GetUsersQuery, List<GetUsersDto>>
{
    public async Task<List<GetUsersDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var user = await context.Users.Include(a => a.Address).ToListAsync(cancellationToken: cancellationToken);

        var users = user.Select(item => new GetUsersDto
        {
            UserId = item.UserId,
            FirstName = item.FirstName,
            LastName = item.LastName,
            Title = item.Title,
            StartDate = item.StartDate,
            DateCreated = item.DateCreated,
            Gender = item.Gender,
            Initials = item.Initials,
            Address = item.Address.Select(a => new AddressDto
            {
                City = a.City,
                PostalCode = a.PostalCode,
                StreetName = a.StreetName,
                Surburb = a.Surburb
            }).ToList(),
            UserType = item.UserType.ToString(),
        }).ToList();
        return users;
    }
    
}