using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Reactivities.Controller.Base;

[ApiController]
[Route("api")]
public class BaseApiController : ControllerBase
{
    private IMediator _mediator;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); 
    
}