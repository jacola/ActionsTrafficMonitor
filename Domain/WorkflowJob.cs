using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("workflow_jobs")]
    public class WorkflowJob
    {
        public long Id { get; set; }
        public long RunId { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }
        public string RepositoryName { get; set; }
        public string? RunnerName { get; set; }
        public string? RunnerGroupName { get; set; }
        public DateTime? QueuedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}