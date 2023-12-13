using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.Data.Domain;
using Reactivities.Persistence;

namespace Reactivities.Controller;

[ApiController]
[Route("api/activities")]
public class ActivitiesController : ControllerBase
{
    private readonly DataContext _context;

    public ActivitiesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetAll()
    {
        return await _context.Activities.ToListAsync();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Activity>> GetById([FromRoute] Guid id)
    {
        return await _context.Activities.FindAsync(id);
    }
}