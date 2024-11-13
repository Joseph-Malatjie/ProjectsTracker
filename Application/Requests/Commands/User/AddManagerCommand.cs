using Domain.Dto.Commands;
using MediatR;

namespace Application.Requests.Commands;

public class AddManagerCommand : IRequest<Unit>
{
    public AddManagerDto Manager { get; set; }
}