using System.Text.Json.Serialization;

namespace API.Interfaces
{
    public class IWebhookPayload
    {
        public string Action { get; set; }
        [JsonPropertyName("workflow_job")] public IWorkflowJob WorkflowJob { get; set; }
    }
}