using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public class IssueLink
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public IssueLinkType Type { get; set; }


        [JsonProperty("outwardIssue", NullValueHandling = NullValueHandling.Ignore)]
        public Issue OutwardIssue { get; set; }

        [JsonProperty("inwardIssue", NullValueHandling = NullValueHandling.Ignore)]
        public Issue InwardIssue { get; set; }
    }
}
