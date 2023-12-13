using MediatR;
using Reactivities.Data.Domain;

namespace Reactivities.Application.Activities;

public class Edit
{
    public class Command : IRequest
    {
        public Activity Activity { get; set; }
    }
}