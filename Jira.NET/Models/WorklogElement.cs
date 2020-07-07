using System;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class WorklogElement
    {
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public User Author { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("issueId", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
        public string Started { get; set; }

        [JsonProperty("timeSpent", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeSpent { get; set; }

        [JsonProperty("timeSpentSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeSpentSeconds { get; set; }

        [JsonProperty("updateAuthor", NullValueHandling = NullValueHandling.Ignore)]
        public User UpdateAuthor { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public Visibility Visibility { get; set; }
    }
}
