using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.WorkflowJobs
{
    public class Edit
    {
        public class Command : IRequest
        {
            public WorkflowJob WorkflowJob { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public IMapper _mapper { get; }

            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var workflowJob = await _context.WorkflowJobs.FindAsync(request.WorkflowJob.Id);

                //Console.WriteLine(request.WorkflowJob);
                _mapper.Map(request.WorkflowJob, workflowJob);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}