using Domain.Dto.Commands;
using MediatR;

namespace Application.Requests.Commands.User;

public class AddManagerCommand : IRequest<Unit>
{
    public AddManagerDto Manager { get; set; }
}