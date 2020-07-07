using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Jira.NET.Models
{
    public partial class IssueFields
    {

    }

    public partial class IssueFields
    {
        [JsonProperty("fixVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Version> FixVersions { get; set; }
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public Resolution Resolution { get; set; }
        [JsonProperty("lastViewed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastViewed { get; set; }
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public Priority Priority { get; set; }
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<String> Labels { get; set; }
        [JsonProperty("timeestimate", NullValueHandling = NullValueHandling.Ignore)]
        public Decimal RemainingEstimate { get; set; }
        [JsonProperty("aggregatetimeoriginalestimate", NullValueHandling = NullValueHandling.Ignore)]
        public Decimal ΣOriginalEstimate { get; set; }
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Version> AffectsVersions { get; set; }
        [JsonProperty("issuelinks", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueLink> LinkedIssues { get; set; }
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public User Assignee { get; set; }
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Component> Components { get; set; }
        [JsonProperty("issuekey", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }
        [JsonProperty("aggregatetimeestimate", NullValueHandling = NullValueHandling.Ignore)]
        public Decimal ΣRemainingEstimate { get; set; }
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public User Creator { get; set; }
        [JsonProperty("subtasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueLink> SubTasks { get; set; }
        [JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        public User Reporter { get; set; }
        [JsonProperty("aggregateprogress", NullValueHandling = NullValueHandling.Ignore)]
        public Progress ΣProgress { get; set; }
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public Progress Progress { get; set; }
        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore)]
        public Votes Votes { get; set; }
        [JsonProperty("issuetype", NullValueHandling = NullValueHandling.Ignore)]
        public IssueType IssueType { get; set; }
        [JsonProperty("timespent", NullValueHandling = NullValueHandling.Ignore)]
        public Decimal TimeSpent { get; set; }
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public Project Project { get; set; }
        [JsonProperty("aggregatetimespent", NullValueHandling = NullValueHandling.Ignore)]
        public Decimal ΣTimeSpent { get; set; }
        [JsonProperty("resolutiondate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Resolved { get; set; }
        [JsonProperty("workratio", NullValueHandling = NullValueHandling.Ignore)]
        public Decimal WorkRatio { get; set; }
        [JsonProperty("watches", NullValueHandling = NullValueHandling.Ignore)]
        public Watches Watchers { get; set; }
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }
        [JsonProperty("timeoriginalestimate", NullValueHandling = NullValueHandling.Ignore)]
        public Decimal OriginalEstimate { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public String Description { get; set; }
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public String Summary { get; set; }
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public String Environment { get; set; }
        [JsonProperty("duedate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Issue Parent { get; set; }

        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> Attachment { get; set; }

        [JsonProperty("worklog", NullValueHandling = NullValueHandling.Ignore)]
        public List<Worklog> LogWork { get; set; }

        [JsonProperty("timetracking", NullValueHandling = NullValueHandling.Ignore)]
        public TimeTracking TimeTracking { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public String Images { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public CommentsList Comments { get; set; }

        [JsonProperty("security", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityListLevel SecurityLevel { get; set; }

        [JsonExtensionData]
        public JObject AdditionalData { get; set; }
    }
}
