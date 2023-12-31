﻿using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Activities;
using Reactivities.Controller.Base;
using Reactivities.Data.Domain;

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
        return await Mediator.Send(new Details.Query { Id = id });
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Activity activity)
    {
        await Mediator.Send(new Create.Command { Activity = activity });
        
        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> Edit(Guid id,Activity activity)
    {
        activity.Id = id;

        await Mediator.Send(new Edit.Command { Activity = activity });

        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await Mediator.Send(new Delete.Command { Id = id });

        return Ok();
    }
}