using System.Text.Json.Serialization;

namespace API.Interfaces
{
    public class IWorkflowJob
    {
        public long Id { get; set; }
        [JsonPropertyName("run_id")] public long RunId { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("started_at")] public DateTime StartedAt { get; set; }
        [JsonPropertyName("completed_at")] public DateTime? CompletedAt { get; set; }
        public List<IStep> Steps { get; set; }
        [JsonPropertyName("runner_name")] public string RunnerName { get; set; }
        [JsonPropertyName("runner_group_name")] public string RunnerGroupName { get; set; }
        [JsonPropertyName("labels")] public string[] Labels { get; set; }
    }
}