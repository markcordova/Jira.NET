using System;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Component
    {
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public User Assignee { get; set; }

        [JsonProperty("assigneeType", NullValueHandling = NullValueHandling.Ignore)]
        public RealAssigneeTypeEnum? AssigneeType { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("isAssigneeTypeValid")]
        public bool IsAssigneeTypeValid { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public User Lead { get; set; }

        [JsonProperty("leadUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadUserName { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public string Project { get; set; }

        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProjectId { get; set; }

        [JsonProperty("realAssignee", NullValueHandling = NullValueHandling.Ignore)]
        public User RealAssignee { get; set; }

        [JsonProperty("realAssigneeType", NullValueHandling = NullValueHandling.Ignore)]
        public RealAssigneeTypeEnum? RealAssigneeType { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }
    }
}
