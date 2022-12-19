using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Utilities;
using Microsoft.Extensions.Primitives;
using System.Text;

namespace API.Middleware
{
    public class WebhookValidation
    {
        private readonly RequestDelegate _next;

        public WebhookValidation(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var Request = context.Request;

            Request.Headers.TryGetValue("X-Hub-Signature-256", out StringValues signature);

            // If the header is missing 
            if (StringValues.IsNullOrEmpty(signature))
            {
                context.Response.Clear();
                context.Response.StatusCode = (int)StatusCodes.Status401Unauthorized;
                return;
            }

            string payloadText;
            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                payloadText = await reader.ReadToEndAsync().ConfigureAwait(false);
            }

            // Reset our body so it can be processed later..
            byte[] requestData = Encoding.UTF8.GetBytes(payloadText);
            Request.Body = new MemoryStream(requestData);

            string secret = Environment.GetEnvironmentVariable("GITHUB_WEBHOOK_SECRET");

            // Require a secret. Reject cases where the secret is blank on both sides.
            if (StringValues.IsNullOrEmpty(secret))
            {
                context.Response.Clear();
                context.Response.StatusCode = (int)StatusCodes.Status401Unauthorized;
                return;
            }

            var calcSig = Util.CalculateSignature(payloadText, signature, secret, "sha256=");

            // Error if the signature is invalid.
            if (calcSig != signature)
            {
                context.Response.Clear();
                context.Response.StatusCode = (int)StatusCodes.Status401Unauthorized;
                return;
            }

            await _next(context);
        }
    }

    public static class WebhookValidationExtensions
    {
        public static IApplicationBuilder UseWebhookValidation(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<WebhookValidation>();
        }
    }
}