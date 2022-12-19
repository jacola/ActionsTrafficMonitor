using System.Text.Json.Serialization;

namespace API.Interfaces
{
    // TODO: Check if these are the correct values
    public enum UserType
    {
        User,
        Organization, // Need to confirm this along with other possible values.
    }

    public class IUser
    {
        public long Id;
        [JsonPropertyName("login")] public string Login { get; set; }
        [JsonPropertyName("node_id")] public string NodeId { get; set; }
        [JsonPropertyName("avatar_url")] public string AvatarUrl { get; set; }
        [JsonPropertyName("gravatar_id")] public string GravatarId { get; set; }
        [JsonPropertyName("url")] public string Url { get; set; }
        [JsonPropertyName("html_url")] public string HtmlUrl { get; set; }
        [JsonPropertyName("followers_url")] public string FollowersUrl { get; set; }
        [JsonPropertyName("following_url")] public string FollowingUrl { get; set; }
        [JsonPropertyName("gists_url")] public string GistsUrl { get; set; }
        [JsonPropertyName("starred_url")] public string StarredUrl { get; set; }
        [JsonPropertyName("subscriptions_url")] public string SubscriptionsUrl { get; set; }
        [JsonPropertyName("organizations_url")] public string OrganizationsUrl { get; set; }
        [JsonPropertyName("repos_url")] public string ReposUrl { get; set; }
        [JsonPropertyName("events_url")] public string EventsUrl { get; set; }
        [JsonPropertyName("received_events_url")] public string ReceivedEventsUrl { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))] public UserType Type { get; set; }
        [JsonPropertyName("site_admin")] public bool SiteAdmin { get; set; }
    }
}