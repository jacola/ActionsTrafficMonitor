using System.Text.Json.Serialization;

namespace API.Interfaces
{
    public enum ActionType
    {
        Queued,
        In_Progress,
        Completed
    }

    public class IWebhookPayload
    {
        [JsonConverter(typeof(JsonStringEnumConverter))] public ActionType Action { get; set; }
        // public IEnterprise? Enterprise { get; set; }
        // installation
        // public IOrganization? Organization { get; set; }
        [JsonPropertyName("repository")] public IRepository Repository { get; set; }
        //public IUser sender { get; set; }
        [JsonPropertyName("workflow_job")] public IWorkflowJob WorkflowJob { get; set; }
        // deployment
    }
}