using Domain.Dto.Commands;
using MediatR;

namespace Application.Requests.Commands;

public class AddDeveloperCommand : IRequest<Unit>
{
    public AddDeveloperDto Developer { get; set; }
}