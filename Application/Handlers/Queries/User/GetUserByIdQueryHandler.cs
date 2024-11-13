using Application.Requests.Queries.Users;
using Domain.Dto.Commands;
using Domain.Dto.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Handlers.Queries.User;

public class GetUserByIdQueryHandler(DataContext context) : IRequestHandler<GetUserByIdQuery,GetUserByIdDto>
{
    public async Task<GetUserByIdDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await context.Users.Include(a => a.Address).FirstOrDefaultAsync(u => u.UserId == request.UserId, cancellationToken: cancellationToken);

        var userDto = new GetUserByIdDto
        {
            UserId = user.UserId,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Title = user.Title,
            StartDate = user.StartDate,
            DateCreated = user.DateCreated,
            Address = user.Address.Select(a => new AddressDto()
            {
                StreetName = a.StreetName,
                City = a.City,
                PostalCode = a.PostalCode,
                Surburb = a.Surburb
            }).ToList(),
            Gender = user.Gender,
            Initials = user.Initials,
            UserType = user.UserType.ToString()
        };
        
        return userDto;
    }
}