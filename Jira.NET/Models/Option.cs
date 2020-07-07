using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Jira.NET.Models
{
    public class Option
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }        

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonExtensionData]
        internal JObject AdditionalData { get; set; }
    }
}
