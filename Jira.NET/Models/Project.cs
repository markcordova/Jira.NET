using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Project
    {
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        [JsonProperty("assigneeType", NullValueHandling = NullValueHandling.Ignore)]
        public AssigneeType? AssigneeType { get; set; }

        [JsonProperty("avatarUrls", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectAvatarUrls AvatarUrls { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Component> Components { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("issueTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueType> IssueTypes { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public User Lead { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("projectCategory", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectCategory ProjectCategory { get; set; }

        [JsonProperty("projectKeys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProjectKeys { get; set; }

        [JsonProperty("projectTypeKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectTypeKey { get; set; }

        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public Roles Roles { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Version> Versions { get; set; }
    }
}
