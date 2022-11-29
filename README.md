# Actions Traffic Monitor

This is a simple webhook to capture when workflow jobs are queued, started and completed. Gathering this data is helpful if you are using self hosted runners and want to know if jobs are getting queued for too long due to capacity constraints.

**Data example:**
```sql
SELECT
    Id, RunId, Name,
    ROUND((JULIANDAY(StartedAt) - JULIANDAY(QueuedAt)) * 86400) as QueueTime,
    ROUND((JULIANDAY(CompletedAt) - JULIANDAY(StartedAt)) * 86400) as ExecutionTime
FROM
    WorkflowJobs;
```
|Id | RunId | Name | QueueTime | ExecutionTime
| --- | --- | --- | --- | ---
|9764454429 | 3572133535 | my-job-1 | 8.0 | 19.0
|9764463439 | 3572133535 | my-job-2 | 9.0 | 1.0

## Setup

1. Expects `GITHUB_WEBHOOK_SECRET` as an environment variable.
