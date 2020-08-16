using Jira.NET.Client;
using Jira.NET.Exceptions;
using Jira.NET.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jira.NET
{
    public class JiraClient
    {
        public static readonly string RESOURCE_GETFIELDS = "rest/api/latest/field";

        private readonly IRestClientFactory clientFactory;
        private List<FieldInfo> fields = null;

        // Strictly speaking this is bad design, we shouldn't be coupling this class with a concrete implementation of it's dependency.
        // However, we will err on the side of user convenience over textbook cleanliness (I hope I don't regret this in the future).
        public JiraClient(string baseurl, string username, string password) : this(new RestClientFactory(baseurl, username, password))
        {

        }

        public JiraClient(IRestClientFactory factory)
        {
            clientFactory = factory;
        }

        public async Task<List<FieldInfo>> GetFields()
        {
            if (fields == null)
            {
                var client = clientFactory.Create();
                var request = new RestRequest(RESOURCE_GETFIELDS, Method.GET);
                var response = await ExecuteAsync<List<FieldInfo>>(client, request);

                fields = response.Data;
            }

            return fields;
        }

        public async Task<List<Sprint>> GetSprints(int boardId)
        {
            List<Sprint> sprints = new List<Sprint>();
            int startAt = 0;
            while (true)
            {
                var request = new RestRequest($"rest/agile/1.0/board/{boardId}/sprint", Method.GET);
                request.AddParameter("maxResults", 50, ParameterType.QueryString);
                request.AddParameter("startAt", startAt, ParameterType.QueryString);
                request.DateFormat = Sprint.DATE_FORMAT;

                var client = clientFactory.Create();
                var response = await ExecuteAsync<SimpleValuesListWrapper<Sprint>>(client, request);

                var data = response.Data;
                sprints.AddRange(data.Values);

                if (data.IsLast)
                {
                    break;
                }
                else
                {
                    startAt = startAt + data.Values.Count;
                }
            }

            return sprints;
        }

        public async Task<List<Filter>> GetFavoriteFilters()
        {
            var client = clientFactory.Create();
            var request = new RestRequest("rest/api/2/filter/favourite/", Method.GET);

            var response = await ExecuteAsync<List<Filter>>(client, request);
            return response.Data;
        }

        public async Task<User> GetUser(string username)
        {
            var client = clientFactory.Create();
            var request = new RestRequest("rest/api/2/user");
            request.AddParameter("username", username);
            request.AddParameter("expand", "groups,applicationRoles");

            var response = await ExecuteAsync<User>(client, request);
            var data = JsonConvert.DeserializeObject<User>(response.Content);

            return data;
        }


        public async Task<List<Issue>> Search(SearchRequest searchRequest)
        {
            var results = new List<Issue>();
            var searchResults = await Search<IssueFields>(searchRequest);
            searchResults.ForEach(r => results.Add(r as Issue<IssueFields>));

            return results;
        }


        public async Task<List<Issue<T>>> Search<T>(SearchRequest searchRequest)
        {
            var results = new List<Issue<T>>();
            var client = clientFactory.Create();

            int startAt = searchRequest.StartAt.HasValue ? searchRequest.StartAt.Value : 0;
            while (true)
            {
                if (startAt > 0)
                {
                    searchRequest.StartAt = startAt;
                }

                var request = new RestRequest("rest/api/2/search/", Method.POST);
                request.UseNewtonsoftJson();
                request.AddJsonBody(searchRequest);

                // manually deserializing as RestSharp doesnt seem to support JsonExtensionData
                // var response = await client.ExecuteAsync<SearchResults>(request);
                // var data = response.Data;
                var response = await ExecuteAsync(client, request);
                var data = JsonConvert.DeserializeObject<SearchResults<T>>(response.Content);

                results.AddRange(data.Issues);
                startAt += data.Issues.Count;
                if (startAt >= data.Total)
                {
                    break;
                }

            }

            return results;
        }


        private async Task<IRestResponse> ExecuteAsync(IRestClient client, IRestRequest request)
        {
            return (IRestResponse)await ExecuteAsync<string>(client, request);
        }

        private async Task<IRestResponse<T>> ExecuteAsync<T>(IRestClient client, IRestRequest request)
        {
            if (request == null)
            {
                throw new ErrorResponseException($"Request is NULL. Why?");
            }

            IRestResponse<T> response;
            try
            {
                response = await client.ExecuteAsync<T>(request);
            }
            catch (Exception e)
            {
                throw new ErrorResponseException($"Caught exception while executing request for resource: {request.Resource}", e);
            }

            if (response == null)
            {
                // Will this ever happen?
                throw new ErrorResponseException($"Got a NULL response while executing request for resource: {request.Resource}");
            }
            else if (response.IsSuccessful)
            {
                return response;
            }

            string message = string.Empty;
            if (!string.IsNullOrEmpty(response.Content))
            {
                try
                {
                    var error = JsonConvert.DeserializeObject<ErrorMessage>(response.Content);
                    message = error.Message;
                }
                catch
                {
                    // Hmmm... API is a bit inconsistent, on some error scenarios the response message does not map to the error response schema
                }
            }

            if (string.IsNullOrEmpty(message))
            {
                message = response.StatusCode.ToString();
            }

            throw new ErrorResponseException($"[ERROR]: {message}", response.StatusCode);
        }
    }
}
