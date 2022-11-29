# Actions Traffic Monitor

This is a simple webhook to capture when workflow jobs are queued, started and completed. Gathering this data is helpful if you are using self hosted runners and want to know if jobs are getting queued for too long due to capacity constraints.

## Setup

1. Expects `GITHUB_WEBHOOK_SECRET` as an environment variable.
