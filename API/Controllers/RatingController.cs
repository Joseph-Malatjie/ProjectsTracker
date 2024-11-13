using Application.Requests.Commands.Rating;
using Application.Requests.Queries.Rating;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class RatingController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetProjectRating([FromQuery] GetProjectRatingQuery query) =>
        Ok(await Mediator.Send(query));
    
    [HttpPost]
    public async Task<IActionResult> AddRating(AddRatingCommand command) =>
        Ok(await Mediator.Send(command));
}