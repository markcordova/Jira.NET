using System;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    internal class AssigneeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AssigneeType) || t == typeof(AssigneeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "PROJECT_LEAD":
                    return AssigneeType.ProjectLead;
                case "UNASSIGNED":
                    return AssigneeType.Unassigned;
            }
            throw new Exception("Cannot unmarshal type AssigneeType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AssigneeType)untypedValue;
            switch (value)
            {
                case AssigneeType.ProjectLead:
                    serializer.Serialize(writer, "PROJECT_LEAD");
                    return;
                case AssigneeType.Unassigned:
                    serializer.Serialize(writer, "UNASSIGNED");
                    return;
            }
            throw new Exception("Cannot marshal type AssigneeType");
        }

        public static readonly AssigneeTypeConverter Singleton = new AssigneeTypeConverter();
    }
}
