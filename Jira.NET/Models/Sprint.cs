using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Jira.NET.Models
{
    public class Sprint
    {
        internal static readonly string DATE_FORMAT = "yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffK";

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("completeDate")]
        public DateTime? CompleteDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("originBoardId")]
        public int OriginBoardId { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("goal")]
        public string Goal { get; set; }

        public static Sprint FromBeanString(string bean)
        {
            Sprint sprint = null;
            var parts = bean.Split('[', ']');            
            if (parts.Length >= 2 && !string.IsNullOrEmpty(parts[1]))
            {
                sprint = new Sprint();
                foreach (var part in parts[1].Split(','))
                {
                    var kvp = part.Split('=');
                    if(kvp.Length == 2)
                    {
                        // id=2169,rapidViewId=296,state=FUTURE,name=Sprint 103 - Japan,startDate=<null>,endDate=<null>,completeDate=<null>,sequence=2169,goal=<null>

                        DateTime? ParseDateTime(string strDateTime)
                        {
                            if("<null>".Equals(strDateTime))
                            {
                                return null;
                            }
                            else
                            {
                                if(DateTime.TryParseExact(strDateTime, Sprint.DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
                                {
                                    return dt;
                                }
                                else
                                {
                                    return null;
                                }
                            }
                        }

                        switch (kvp[0])
                        {
                            case "id":
                                sprint.Id = kvp[1];
                                break;
                            case "name":
                                sprint.Name = kvp[1];
                                break;
                            case "goal":
                                sprint.Goal = kvp[1];
                                break;
                            case "state":
                                sprint.State = kvp[1];
                                break;
                            case "rapidViewId":
                                if(int.TryParse(kvp[1], out int boardid))
                                {
                                    sprint.OriginBoardId = boardid;
                                }
                                break;
                            case "startDate":
                                sprint.StartDate = ParseDateTime(kvp[1]);
                                break;
                            case "endDate":
                                sprint.EndDate = ParseDateTime(kvp[1]);
                                break;
                            case "completeDate":
                                sprint.CompleteDate = ParseDateTime(kvp[1]);
                                break;

                        }
                    }
                }
            }

            return sprint;
        }

        public override bool Equals(object obj)
        {
            return obj is Sprint sprint &&
                   Id == sprint.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
