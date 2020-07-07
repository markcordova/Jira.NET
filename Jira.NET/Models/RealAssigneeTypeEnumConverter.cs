using System;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    internal class RealAssigneeTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RealAssigneeTypeEnum) || t == typeof(RealAssigneeTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "COMPONENT_LEAD":
                    return RealAssigneeTypeEnum.ComponentLead;
                case "PROJECT_DEFAULT":
                    return RealAssigneeTypeEnum.ProjectDefault;
                case "PROJECT_LEAD":
                    return RealAssigneeTypeEnum.ProjectLead;
                case "UNASSIGNED":
                    return RealAssigneeTypeEnum.Unassigned;
            }
            throw new Exception("Cannot unmarshal type RealAssigneeTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RealAssigneeTypeEnum)untypedValue;
            switch (value)
            {
                case RealAssigneeTypeEnum.ComponentLead:
                    serializer.Serialize(writer, "COMPONENT_LEAD");
                    return;
                case RealAssigneeTypeEnum.ProjectDefault:
                    serializer.Serialize(writer, "PROJECT_DEFAULT");
                    return;
                case RealAssigneeTypeEnum.ProjectLead:
                    serializer.Serialize(writer, "PROJECT_LEAD");
                    return;
                case RealAssigneeTypeEnum.Unassigned:
                    serializer.Serialize(writer, "UNASSIGNED");
                    return;
            }
            throw new Exception("Cannot marshal type RealAssigneeTypeEnum");
        }

        public static readonly RealAssigneeTypeEnumConverter Singleton = new RealAssigneeTypeEnumConverter();
    }
}
