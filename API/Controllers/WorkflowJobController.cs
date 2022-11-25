using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using API.Interfaces;
//using Application.WorkflowJobs;

namespace API.Controllers
{
    public class WorkflowJobController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> UpdateWorkflowJob(WebhookPayload payload)
        {
            switch (payload.Action)
            {
                // Create
                case "queued":
                    Console.WriteLine($"id: {payload.WorkflowJob.Id}\tStatus: Queued\tTime: {payload.WorkflowJob.StartedAt.ToLocalTime()}");
                    break;
                // Update
                case "in_progress":
                    Console.WriteLine($"id: {payload.WorkflowJob.Id}\tStatus: In Progress\tTime: {payload.WorkflowJob.StartedAt.ToLocalTime()}");
                    break;
                case "completed":
                    Console.WriteLine($"id: {payload.WorkflowJob.Id}\tStatus: Completed\tTime: {payload.WorkflowJob.CompletedAt.Value.ToLocalTime()}");
                    break;
                default:
                    Console.WriteLine(payload.Action);
                    break;
            }

            return Ok();
            //return Ok(await Mediator.Send(new Create.Command { Activity = activity }));
        }
    }
}