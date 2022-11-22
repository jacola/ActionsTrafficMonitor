using System.Text.Json.Serialization;

namespace API.Interfaces
{
    public class WebhookPayload
    {
        public string Action { get; set; }
        [JsonPropertyName("workflow_job")] public WorkflowJob WorkflowJob { get; set; }
    }
}