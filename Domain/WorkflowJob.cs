using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    // You might not be able to run SQL without specifying the schema if 
    // the tablename contains different cases. Ex: public."WorkflowJobs"
    // https://stackoverflow.com/questions/36753568/postgresql-tables-exists-but-getting-relation-does-not-exist-when-querying
    [Table("workflow_jobs")]
    public class WorkflowJob
    {
        [Column("id")] public long Id { get; set; }
        [Column("run_id")] public long RunId { get; set; }
        [Column("name")] public string Name { get; set; }
        [Column("org_name")] public string OrganizationName { get; set; }
        [Column("repo_name")] public string RepositoryName { get; set; }
        [Column("runner_name")] public string? RunnerName { get; set; }
        [Column("runner_group_name")] public string? RunnerGroupName { get; set; }
        [Column("queued_at")] public DateTime? QueuedAt { get; set; }
        [Column("started_at")] public DateTime? StartedAt { get; set; }
        [Column("completed_at")] public DateTime? CompletedAt { get; set; }
    }
}