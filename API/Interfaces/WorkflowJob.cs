using System.Text.Json.Serialization;

namespace API.Interfaces
{
    public class WorkflowJob
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("started_at")] public DateTime StartedAt { get; set; }
        [JsonPropertyName("completed_at")] public DateTime? CompletedAt { get; set; }
    }
}