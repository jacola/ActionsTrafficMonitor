using System.Text.Json.Serialization;

namespace API.Interfaces
{
    public class IRepository
    {
        // public long Id { get; set; }
        // [JsonPropertyName("node_id")] public string NodeId { get; set; }
        // public string Name { get; set; }
        [JsonPropertyName("full_name")] public string FullName { get; set; }
        // public bool Private { get; set; }
        // public IUser Owner { get; set; }
        // [JsonPropertyName("html_url")] public string HtmlUrl { get; set; }
        // public string Description { get; set; }
        // public bool Fork { get; set; }
        // public string Url { get; set; }
        // [JsonPropertyName("forks_url")] public string ForksUrl { get; set; }
        // [JsonPropertyName("keys_url")] public string KeysUrl { get; set; }
        // [JsonPropertyName("collaborators_url")] public string CollaboratorsUrl { get; set; }
        // [JsonPropertyName("teams_url")] public string TeamsUrl { get; set; }
        // [JsonPropertyName("hooks_url")] public string HooksUrl { get; set; }
        // [JsonPropertyName("issue_events_url")] public string IssueEventsUrl { get; set; }
        // [JsonPropertyName("events_url")] public string EventsUrl { get; set; }
        // [JsonPropertyName("assignees_url")] public string AssigneesUrl { get; set; }
        // [JsonPropertyName("branches_url")] public string BranchesUrl { get; set; }
        // [JsonPropertyName("tags_url")] public string TagsUrl { get; set; }
        // [JsonPropertyName("blobs_url")] public string BlobsUrl { get; set; }
        // [JsonPropertyName("git_tags_url")] public string GitTagsUrl { get; set; }
        // [JsonPropertyName("git_refs_url")] public string GitRefsUrl { get; set; }
        // [JsonPropertyName("trees_url")] public string TreesUrl { get; set; }
        // [JsonPropertyName("statuses_url")] public string StatusesUrl { get; set; }
        // [JsonPropertyName("languages_url")] public string LanguageUurl { get; set; }
        // [JsonPropertyName("stargazers_url")] public string StargazersUrl { get; set; }
        // [JsonPropertyName("contributors_url")] public string ContributorsUrl { get; set; }
        // [JsonPropertyName("subscribers_url")] public string SubscribersUrl { get; set; }
        // [JsonPropertyName("subscription_url")] public string SubscriptionUrl { get; set; }
        // [JsonPropertyName("commits_url")] public string CommitsUrl { get; set; }
        // [JsonPropertyName("git_commits_url")] public string GitCommitsUrl { get; set; }
        // [JsonPropertyName("comments_url")] public string CommentsUrl { get; set; }
        // [JsonPropertyName("issue_comment_url")] public string IssueCommentUrl { get; set; }
        // [JsonPropertyName("contents_url")] public string ContentsUrl { get; set; }
        // [JsonPropertyName("compare_url")] public string CompareUrl { get; set; }
        // [JsonPropertyName("merges_url")] public string MergesUrl { get; set; }
        // [JsonPropertyName("archive_url")] public string ArchiveUrl { get; set; }
        // [JsonPropertyName("downloads_url")] public string DownloadsUrl { get; set; }
        // [JsonPropertyName("issues_url")] public string IssuesUrl { get; set; }
        // [JsonPropertyName("pulls_url")] public string PullsUrl { get; set; }
        // [JsonPropertyName("milestones_url")] public string MilestonesUrl { get; set; }
        // [JsonPropertyName("notifications_url")] public string NotificationsUrl { get; set; }
        // [JsonPropertyName("labels_url")] public string LabelsUrl { get; set; }
        // [JsonPropertyName("releases_url")] public string ReleasesUrl { get; set; }
        // [JsonPropertyName("deployments_url")] public string DeploymentsUrl { get; set; }
        // [JsonPropertyName("created_at")] public string CreatedAt { get; set; }
        // [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }
        // [JsonPropertyName("pushed_at")] public DateTime PushedAt { get; set; }
        // [JsonPropertyName("git_url")] public string GitUrl { get; set; }
        // [JsonPropertyName("ssh_url")] public string SshUrl { get; set; }
        // [JsonPropertyName("clone_url")] public string CloneUrl { get; set; }
        // [JsonPropertyName("svn_url")] public string SvnUrl { get; set; }
        // public string? Homepage { get; set; }
        // public int Size { get; set; }
        // [JsonPropertyName("stargazers_count")] public int StargazersCount { get; set; }
        // [JsonPropertyName("watchers_count")] public int WatchersCount { get; set; }
        // public string? Language { get; set; }
        // [JsonPropertyName("has_issues")] public bool HasIssues { get; set; }
        // [JsonPropertyName("has_projects")] public bool HasProjects { get; set; }
        // [JsonPropertyName("has_downloads")] public bool HasDownloads { get; set; }
        // [JsonPropertyName("has_wiki")] public bool HasWiki { get; set; }
        // [JsonPropertyName("has_pages")] public bool HasPages { get; set; }
        // [JsonPropertyName("has_discussions")] public bool HasDiscussions { get; set; }
        // [JsonPropertyName("forks_count")] public int ForksCount { get; set; }
        // [JsonPropertyName("mirror_url")] public string? MirrorUrl { get; set; }
        // [JsonPropertyName("archived")] public bool Archived { get; set; }
        // [JsonPropertyName("disabled")] public bool Disabled { get; set; }
        // [JsonPropertyName("open_issues_count")] public int OpenIssuesCount { get; set; }
        // public string? License { get; set; }
        // [JsonPropertyName("allow_forking")] public bool AllowForking { get; set; }
        // [JsonPropertyName("is_template")] public bool IsTemplate { get; set; }
        // [JsonPropertyName("web_commit_signoff_required")] public bool WebCommitSignoffRequired { get; set; }
        // public string[] Topics { get; set; }
        // public string Visibility { get; set; }
        // public int Forks { get; set; }
        // [JsonPropertyName("open_issues")] public int OpenIssues { get; set; }
        // public int Watchers { get; set; }
        // [JsonPropertyName("default_branch")] public string DefaultBranch { get; set; }
    }
}