using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Version
    {
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("moveUnfixedIssuesTo", NullValueHandling = NullValueHandling.Ignore)]
        public Uri MoveUnfixedIssuesTo { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<SimpleLink> Operations { get; set; }

        [JsonProperty("overdue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overdue { get; set; }

        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public string Project { get; set; }

        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProjectId { get; set; }

        [JsonProperty("released", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Released { get; set; }

        [JsonProperty("remotelinks", NullValueHandling = NullValueHandling.Ignore)]
        public List<RemoteEntityLink> Remotelinks { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("userReleaseDate", NullValueHandling = NullValueHandling.Ignore)]
        public string UserReleaseDate { get; set; }

        [JsonProperty("userStartDate", NullValueHandling = NullValueHandling.Ignore)]
        public string UserStartDate { get; set; }
    }
}
