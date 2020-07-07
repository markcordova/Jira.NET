using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public class Issue<T> : Issue
    {
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public new T Fields { get; set; }
    }

    public class Issue
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("changelog", NullValueHandling = NullValueHandling.Ignore)]
        public Changelog Changelog { get; set; }

        [JsonProperty("editmeta", NullValueHandling = NullValueHandling.Ignore)]
        public EditMeta Editmeta { get; set; }

        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public virtual IssueFields Fields { get; set; }

        [JsonProperty("fieldsToInclude", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> FieldsToInclude { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
        public Names Names { get; set; }

        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public Opsbar Operations { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Properties Properties { get; set; }

        [JsonProperty("renderedFields", NullValueHandling = NullValueHandling.Ignore)]
        public RenderedFields RenderedFields { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public Schema Schema { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("transitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Transition> Transitions { get; set; }

        [JsonProperty("versionedRepresentations", NullValueHandling = NullValueHandling.Ignore)]
        public VersionedRepresentations VersionedRepresentations { get; set; }
    }
}
