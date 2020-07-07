using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Filter
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("jql", NullValueHandling = NullValueHandling.Ignore)]
        public string Jql { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public User Owner { get; set; }

        [JsonProperty("searchUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SearchUrl { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("sharedUsers", NullValueHandling = NullValueHandling.Ignore)]
        public UserBeanListWrapper SharedUsers { get; set; }

        [JsonProperty("sharePermissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<FilterPermission> SharePermissions { get; set; }

        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public FilterSubscriptionBeanListWrapper Subscriptions { get; set; }

        [JsonProperty("viewUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ViewUrl { get; set; }
    }
}
