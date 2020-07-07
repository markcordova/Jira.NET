﻿using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public class IssueLinkType
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("outward", NullValueHandling = NullValueHandling.Ignore)]
        public string Outward { get; set; }

        [JsonProperty("inward", NullValueHandling = NullValueHandling.Ignore)]
        public string Inward { get; set; }
    }
}
