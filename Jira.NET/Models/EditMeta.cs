using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class EditMeta
    {
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public EditmetaFields Fields { get; set; }
    }
}
