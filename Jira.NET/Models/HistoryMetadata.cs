using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class HistoryMetadata
    {
        [JsonProperty("activityDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityDescription { get; set; }

        [JsonProperty("activityDescriptionKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityDescriptionKey { get; set; }

        [JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
        public HistoryMetadataParticipant Actor { get; set; }

        [JsonProperty("cause", NullValueHandling = NullValueHandling.Ignore)]
        public HistoryMetadataParticipant Cause { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("descriptionKey", NullValueHandling = NullValueHandling.Ignore)]
        public string DescriptionKey { get; set; }

        [JsonProperty("emailDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailDescription { get; set; }

        [JsonProperty("emailDescriptionKey", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailDescriptionKey { get; set; }

        [JsonProperty("extraData", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraData ExtraData { get; set; }

        [JsonProperty("generator", NullValueHandling = NullValueHandling.Ignore)]
        public HistoryMetadataParticipant Generator { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
