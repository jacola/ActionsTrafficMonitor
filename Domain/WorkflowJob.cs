using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Data from webhook:
// "workflow_job": {
//     "id": 9635018158,
//     "run_id": 3521393938,
//     "run_url": "https://api.github.com/repos/jacola/actions-webhook-sandbox/actions/runs/3521393938",
//     "run_attempt": 1,
//     "node_id": "CR_kwDOIV0rDs8AAAACPkq1rg",
//     "head_sha": "6889a70b0d51d49086c1df9dbe1ba755a8fd1705",
//     "url": "https://api.github.com/repos/jacola/actions-webhook-sandbox/actions/jobs/9635018158",
//     "html_url": "https://github.com/jacola/actions-webhook-sandbox/actions/runs/3521393938/jobs/5903191872",
//     "status": "queued",
//     "conclusion": null,
//     "started_at": "2022-11-22T07:50:55Z",
//     "completed_at": null,
//     "name": "my-job-1",
//     "steps": [],
//     "check_run_url": "https://api.github.com/repos/jacola/actions-webhook-sandbox/check-runs/9635018158",
//     "labels": ["ubuntu-latest"],
//     "runner_id": null,
//     "runner_name": null,
//     "runner_group_id": null,
//     "runner_group_name": null
// }


namespace Domain
{
    public class WorkflowJob
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? QueuedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        // Todo: Add Runner Info
    }
}