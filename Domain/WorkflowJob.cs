using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkflowJob
    {
        public long Id { get; set; }
        public long RunId { get; set; }
        public string Name { get; set; }
        public DateTime? QueuedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        // Todo: Add Runner Info
    }
}