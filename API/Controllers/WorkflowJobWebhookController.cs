using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using API.Interfaces;
using Application;
using Application.WorkflowJobs;

namespace API.Controllers
{
    public class WorkflowJobWebhookController : BaseApiController
    {
        private readonly ILogger<WorkflowJobWebhookController> _logger;

        public WorkflowJobWebhookController(ILogger<WorkflowJobWebhookController> logger) =>
            _logger = logger;


        [HttpPost]
        public async Task<IActionResult> UpdateWorkflowJob(IWebhookPayload payload)
        {
            switch (payload.Action)
            {
                // Create
                case ActionType.Queued:
                    _logger.LogInformation($"id: {payload.WorkflowJob.Id}\tStatus: Queued\tTime: {payload.WorkflowJob.StartedAt.ToLocalTime()}");
                    string[] repoInfo = payload.Repository.FullName.Split('/');

                    return Ok(await Mediator.Send(new Create.Command
                    {
                        WorkflowJob = new WorkflowJob
                        {
                            Id = payload.WorkflowJob.Id,
                            RunId = payload.WorkflowJob.RunId,
                            Name = payload.WorkflowJob.Name,
                            QueuedAt = payload.WorkflowJob.StartedAt,
                            OrganizationName = repoInfo[0],
                            RepositoryName = repoInfo[1],
                        }
                    }));
                // Update
                case ActionType.In_Progress:
                    _logger.LogInformation($"id: {payload.WorkflowJob.Id}\tStatus: In Progress\tTime: {payload.WorkflowJob.StartedAt.ToLocalTime()}");
                    return Ok(await Mediator.Send(new Edit.Command
                    {
                        WorkflowJob = new WorkflowJob
                        {
                            Id = payload.WorkflowJob.Id,
                            RunId = payload.WorkflowJob.RunId,
                            Name = payload.WorkflowJob.Name,
                            StartedAt = payload.WorkflowJob.StartedAt,
                        }
                    }));
                case ActionType.Completed:
                    _logger.LogInformation($"id: {payload.WorkflowJob.Id}\tStatus: Completed\tTime: {payload.WorkflowJob.CompletedAt.Value.ToLocalTime()}");
                    return Ok(await Mediator.Send(new Edit.Command
                    {
                        WorkflowJob = new WorkflowJob
                        {
                            Id = payload.WorkflowJob.Id,
                            RunId = payload.WorkflowJob.RunId,
                            Name = payload.WorkflowJob.Name,
                            CompletedAt = payload.WorkflowJob.CompletedAt,
                            RunnerName = payload.WorkflowJob.RunnerName,
                            RunnerGroupName = payload.WorkflowJob.RunnerGroupName,
                        }
                    }));
                default:
                    _logger.LogWarning($"Unexpected status: {payload.Action}");
                    return NotFound();
            }
        }
    }
}