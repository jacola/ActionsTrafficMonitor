# Actions Traffic Monitor

This is a simple webhook to capture when workflow jobs are queued, started and completed. Gathering this data is helpful if you are using self hosted runners and want to know if jobs are getting queued for too long due to capacity constraints.

**Data example:**

```sql
SELECT
    id, run_id, name,
    ROUND(EXTRACT(EPOCH FROM started_at) - EXTRACT(EPOCH FROM queued_at), 1) AS queue_time,
	ROUND(EXTRACT(EPOCH FROM completed_at) - EXTRACT(EPOCH FROM started_at), 1) AS execution_time
FROM
    workflow_jobs;
```

| id          | run_id     | name     | queue_time | execution_time |
| ----------- | ---------- | -------- | ---------- | -------------- |
| 10745967808 | 3956372519 | my-job-1 | 7.0        | 14.0           |
| 10745973027 | 3956372519 | my-job-2 | 10.0       | 15.0           |
| 10745982475 | 3956378152 | my-job-1 | 6.0        | 14.0           |
| 10745987988 | 3956378152 | my-job-2 | 7.0        | 14.0           |

## Setup

1. The webhook receiver (this application) expects the following environment variables:

| Variable                | Description                |
| ----------------------- | -------------------------- |
| `GITHUB_WEBHOOK_SECRET` | Secret set for the webhook |
| `PG_SERVER`             | Postgres server url        |
| `PG_DATABASE`           | Postgres database name     |
| `PG_USERNAME`           | Postgres username          |
| `PG_USERNAME`           | Postgres password          |

2. Configure the webhook on GitHub as follows:

| Item                                                 | Details                                              |
| ---------------------------------------------------- | ---------------------------------------------------- |
| Payload URL                                          | `https://<your url>/api/workflowjobwebhook`          |
| Content type                                         | `application/json`                                   |
| Secret                                               | Your secret                                          |
| SSL verification                                     | `Enable SSL verification`                            |
| Which events would you like to trigger this webhook? | `Let me select individual events.` → `Workflow jobs` |

## Limitations

**Missing Events**

Workflows should fire webhook events in the following order: `workflow_job.queued` → `workflow_job.in_progress` → `workflow_job.completed`. However, if a job is processed too quickly (example just `run: echo "Hello World!"`) only two events fire: `workflow_job.queued` → `workflow_job.completed`
