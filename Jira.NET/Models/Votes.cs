using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public class Votes 
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore)]
        public int NumVotes { get; set; }

        [JsonProperty("hasVoted", NullValueHandling = NullValueHandling.Ignore)]
        public bool HasVoted { get; set; }

    }

}
