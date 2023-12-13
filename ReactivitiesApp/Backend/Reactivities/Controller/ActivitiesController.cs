using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Activities;
using Reactivities.Controller.Base;
using Reactivities.Data.Domain;
using Reactivities.Persistence;

namespace Reactivities.Controller;

[ApiController]
[Route("activities")]
public class ActivitiesController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetAll()
    {
        return await Mediator.Send(new List.Query());
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Activity>> GetById([FromRoute] Guid id)
    {
        return Ok();
    }
}