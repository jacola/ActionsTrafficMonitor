using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("/")]
    public class HealthCheckController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices
            .GetService<IMediator>();

        [HttpGet]
        public async Task<IActionResult> HealthCheck()
        {
            // Make Ok() use await to get rid of CS1998 warning.
            return await Task.Run(() => Ok());
        }
    }
}