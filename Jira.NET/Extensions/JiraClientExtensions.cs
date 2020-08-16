using Jira.NET.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jira.NET
{
    public static class JiraClientExtensions
    {
        // Convenience methods for when we are feeling especially lazy and only want to run the most basic of JQLs..
        public static Task<List<Issue<Issue>>> Search(this JiraClient client, string jql)
        {
            return client.Search<Issue>(jql);
        }

        public static Task<List<Issue<T>>> Search<T>(this JiraClient client, string jql)
        {
            return client.Search<T>(new SearchRequest { Jql = jql });
        }
    }
}
