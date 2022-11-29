using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.WorkflowJobs
{
    public class Create
    {
        public class Command : IRequest
        {
            public WorkflowJob WorkflowJob { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.WorkflowJobs.Add(request.WorkflowJob);

                await _context.SaveChangesAsync();

                return Unit.Value; // Same as nothing.. just tells the APIController we're done.
            }
        }
    }
}