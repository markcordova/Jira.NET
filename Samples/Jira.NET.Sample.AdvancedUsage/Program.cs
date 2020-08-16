using Jira.NET.Client;
using Jira.NET.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira.NET.Sample.AdvancedUsage
{
    class Program
    {
        private readonly static string JIRA_BASEURL_VPN = "_YOUR_JIRA_ENDPOINT_";
        private readonly static string JIRA_USERNAME = "_YOUR_USERNAME_";
        private readonly static string JIRA_PASSWORD = "_YOUR_PASSWORD_";
        private readonly static string JIRA_SAMPLE_JQL = "assignee = currentUser() and status = Open";

        static async Task Main(string[] args)
        {
            // The motivations behind this library are illustrated by this sample:
            // 1. Accessing my company's JIRA server via VPN requires additional 'tweaks'. Not the scope 
            //    of this library or sample, but it requires 'harvesting' VPN authentication cookies via
            //    a browser and then injecting them into the underlying REST client. I suspect this is
            //    not the norm but if you need to do something similar, simply implement a custom rest
            //    client factory that creates and pre-configures RestSharp instances:
            var myFactory = new MyRestClientFactory(JIRA_BASEURL_VPN, JIRA_USERNAME, JIRA_PASSWORD);
            var jira = new JiraClient(myFactory);

            // The second reason why this library exists:
            // 2. JIRA defines standard fields like "Fix Versions" or "Assignee". Howver, it's also 
            //    possible to define custom fields that are specific to your company's JIRA instance. 
            //    The problem is that these custom fields are listed together with the standard fields
            //    in the JSON response and keyed with names like "customfield_11200". This makes it 
            //    impossible to model consistently in a statically-typed language and even then, it would
            //    make data processing (like LINQ) unweildy. To work around this, you can define and
            //    use a subclass of the "IssueFields" class where you can manually define the mapping 
            //    of the custom fields. From this point onwards, you can access/manipulate/store your
            //    company's defined custom fields as though they were standard fields.

            //    Side-Note: If you only need to run very basic JQLs, you may as well use the extension 
            //    method that accepts the JQL string. If however, you need the JIRA server to return 
            //    additional fields or page the results, you can do so by using the full 'SearchRequest'
            //    object:
            var searchRequest = new SearchRequest { Jql = JIRA_SAMPLE_JQL };
            searchRequest.MaxResults = 100;
            searchRequest.Fields.Add("changelog");

            var myIssues = await jira.Search<MyCustomIssueFields>(new SearchRequest { Jql = JIRA_SAMPLE_JQL });

            // Third and final reason is:
            // 3. My main use-case is to periodically query JIRA using either JQL or executing my 
            //    "favorite" filters. Unfortunately the data objects returned by the official JIRA
            //    .NET library creates circular dependencies when serializing them to JSON. It may have
            //    been possible to manually map the results to POCOs before serializing, but for the 
            //    overhead work to do so, we may as well create a custom library instead.
            var jsonStrMyIssues = JsonConvert.SerializeObject(myIssues, Formatting.Indented);
        }
    }

    class MyRestClientFactory : IRestClientFactory
    {
        public Uri BaseUri { get; private set; }
        private IAuthenticator Authenticator { get; set; }

        public MyRestClientFactory(string baseurl, string username, string password) 
        {
            Authenticator = new HttpBasicAuthenticator(username, password);
        }

        public virtual IRestClient Create()
        {
            // Instantiate and setup RestSharp clients as necessary...
            var client = new RestClient(BaseUri);
            if (Authenticator != null)
            {
                client.Authenticator = Authenticator;
            }

            return client;
        }
    }

    class MyCustomIssueFields: IssueFields
    {
        // NOTE: These field definitions are totally arbitrary and are probably going to be very different 
        //       from how your JIRA instance defined them. Refer to your company's documentation, the 
        //       mapping based on the output of the "fields" method, and the raw JSON response to find out
        //       the correct mapping values!

        [JsonProperty("customfield_11200", NullValueHandling = NullValueHandling.Ignore)]
        public List<String> TimesheetTaskID { get; set; }
        
        [JsonProperty("customfield_13500", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Version PlannedRelease { get; set; }
        
        [JsonProperty("customfield_13103", NullValueHandling = NullValueHandling.Ignore)]
        public String Timeframe { get; set; }
        
        [JsonProperty("customfield_12800", NullValueHandling = NullValueHandling.Ignore)]
        public String ProjectCategory { get; set; }
        
        [JsonProperty("customfield_10507", NullValueHandling = NullValueHandling.Ignore)]
        public User Requester { get; set; }

    }
}
