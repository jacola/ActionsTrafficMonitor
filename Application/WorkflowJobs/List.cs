using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.WorkflowJobs
{
    public class List
    {
        public class Query : IRequest<List<WorkflowJob>> { }

        public class Handler : IRequestHandler<Query, List<WorkflowJob>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<WorkflowJob>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.WorkflowJobs.ToListAsync(cancellationToken);
            }
        }
    }
}