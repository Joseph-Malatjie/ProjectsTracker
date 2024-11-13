using Domain.Dto.Commands;
using MediatR;

namespace Application.Requests.Commands.User;

public class AddDeveloperCommand : IRequest<Unit>
{
    public AddDeveloperDto Developer { get; set; }
}