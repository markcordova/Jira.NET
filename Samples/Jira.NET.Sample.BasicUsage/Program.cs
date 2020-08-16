using Jira.NET.Client;
using System;
using System.Threading.Tasks;

namespace Jira.NET.Sample.BasicUsage
{
    class Program
    {
        private readonly static string JIRA_BASEURL_VPN = "_YOUR_JIRA_ENDPOINT_";
        private readonly static string JIRA_USERNAME = "_YOUR_USERNAME_";
        private readonly static string JIRA_PASSWORD = "_YOUR_PASSWORD_";
        private readonly static string JIRA_SAMPLE_JQL = "assignee = currentUser() and status = Open";

        static async Task Main(string[] args)
        {
            // Not much to document as basic usage is super easy. Just create a new JIRA client and pass along 
            // the base URL and credentials...
            var jira = new JiraClient(JIRA_BASEURL_VPN, JIRA_USERNAME, JIRA_PASSWORD);

            // Then search for issues using basic JQL:
            var myissues = await jira.Search(JIRA_SAMPLE_JQL);
        }
    }
}
