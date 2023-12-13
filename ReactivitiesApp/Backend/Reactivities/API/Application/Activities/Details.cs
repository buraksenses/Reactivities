﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Data.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Activities;

public class Details
{
    public class Query : IRequest<Activity>
    {
        public Guid Id { get; set; }
    }
    
    public class Handler : IRequestHandler<Query,Activity>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Activities.FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}