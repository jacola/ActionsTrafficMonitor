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

1. The webhook receiver (this application) expects the following environment variables:

| Variable | Description 
| --- | ---
| `GITHUB_WEBHOOK_SECRET` | Secret set for the webhook
| `PG_SERVER` | Postgres server url
| `PG_DATABASE` | Postgres database name
| `PG_USERNAME` | Postgres username
| `PG_USERNAME` | Postgres password

2. Configure the webhook on GitHub as follows:

| Item | Details
| ---  | ---
| Payload URL | `https://<your url>/api/workflowjobwebhook`
| Content type | `application/json`
| Secret | Your secret
| SSL verification | `Enable SSL verification`
| Which events would you like to trigger this webhook? | `Let me select individual events.` → `Workflow jobs`
