using System.Text.Json.Serialization;

namespace API.Interfaces
{
    public enum ConclusionType
    {
        Action_Required,
        Cancelled,
        Failure,
        Neutral,
        Skipped,
        Stale,
        Success,
        Timed_Out,
        In_Progress,
        Queued,
        Requested,
        Waiting,
        Completed,
    }

    public enum StatusType
    {
        Completed,
        In_Progress,
        Pending,
        Queued,
        Waiting
    }

    public class IStep
    {
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))] public StatusType Status { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))] public ConclusionType? Conclusion { get; set; }
        public long Number { get; set; }
        [JsonPropertyName("started_at")] public DateTime? StartedAt { get; set; }
        [JsonPropertyName("completed_at")] public DateTime? CompletedAt { get; set; }
    }
}