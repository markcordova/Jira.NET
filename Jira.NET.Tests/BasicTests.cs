using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web.WebSockets;
using Jira.NET.Client;
using Jira.NET.Exceptions;
using Jira.NET.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestSharp;
using System.Linq;

namespace Jira.NET.Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestInitialize]
        public void Setup()
        {

        }


        [TestMethod]
        public async Task Test_GetFields_Successful()
        {
            var response = new RestResponse<List<FieldInfo>>();
            response.Data = new List<FieldInfo>() 
            { 
                new FieldInfo { Id = "1" },
                new FieldInfo { Id = "2" },
                new FieldInfo { Id = "3" }
            };
            response.StatusCode = HttpStatusCode.OK;
            response.ResponseStatus = ResponseStatus.Completed;

            var factory = CreateMockFactory_ExecuteAsync<List<FieldInfo>>(response, (r, c) => 
            {
                Assert.AreEqual(JiraClient.RESOURCE_GETFIELDS, r.Resource, $"Expected resource \"{JiraClient.RESOURCE_GETFIELDS}\" but got \"{r.Resource}\"");
                Assert.AreEqual(Method.GET, r.Method, $"Expected GET HTTP Method but got {r.Method}");
            });

            var jira = new JiraClient(factory);
            var results = await jira.GetFields();

            Assert.IsNotNull(results, $"Got NULL results");
            Assert.AreEqual(3, results.Count, $"Expected {response.Data.Count} data but got {results.Count}");
        }

        [TestMethod]
        public async Task Test_GetFields_ErrorCodes()
        {
            await Test_JiraOperation_HttpErrorCodes(async jira => await jira.GetFields());
        }

        [TestMethod]
        public async Task Test_GetSprints_ErrorCodes()
        {
            await Test_JiraOperation_HttpErrorCodes(async jira => await jira.GetSprints(296));
        }

        [TestMethod]
        public async Task Test_GetFavoriteFilters_ErrorCodes()
        {
            await Test_JiraOperation_HttpErrorCodes(async jira => await jira.GetFavoriteFilters());
        }

        [TestMethod]
        public async Task Test_SearchGenericFields_ErrorCodes()
        {
            await Test_JiraOperation_HttpErrorCodes(async jira => await jira.Search(new SearchRequest()));
        }

        [TestMethod]
        public async Task Test_SearchExtendedFields_ErrorCodes()
        {
            await Test_JiraOperation_HttpErrorCodes(async jira => await jira.Search<IssueFields>(new SearchRequest()));
        }

        
        public async Task Test_JiraOperation_HttpErrorCodes(Func<JiraClient, Task> operation)
        {
            // We are totally ignoring the context of many of the error messages here (like continue, moved, protocol switch, etc). For the most part though, this test should still be valid
            foreach (HttpStatusCode statuscode in Enum.GetValues(typeof(HttpStatusCode)).Cast<HttpStatusCode>().Where((code => ((int)code < 200 || (int)code >= 300) && !HttpStatusCode.Unauthorized.Equals(code))))
            {
                await this.Test_ExecuteAsync_ErrorHandling_WithErrorContent<List<FieldInfo>>(async jira => { await operation(jira); }, statuscode);
            }

            // Testing 401 separately as JIRA API doesn't return an error message in JSON format (it's an HTML for some reason)
            await this.Test_ExecuteAsync_ErrorHandling_WithErrorContent<List<FieldInfo>>(async jira => { await operation(jira); }, HttpStatusCode.Unauthorized, errorContent: "<html></html>");
        }

        private async Task Test_ExecuteAsync_ErrorHandling_WithErrorContent<T>(Func<JiraClient, Task> operation, HttpStatusCode statusCode, string errorContent = null, Action<IRestRequest, CancellationToken> restClientCallback = null)
        {
            if(string.IsNullOrEmpty(errorContent))
            {
                errorContent = "{\"message\":\"null for uri: https://www.contoso.com/jira/mockinstance/\",\"status-code\":404}";
            }

            var response = new RestResponse<T>();
            response.Content = errorContent;
            response.ResponseStatus = ResponseStatus.Completed;
            response.StatusCode = statusCode;

            var factory = CreateMockFactory_ExecuteAsync<T>(response, restClientCallback);
            var jira = new JiraClient(factory);

            await Assert.ThrowsExceptionAsync<ErrorResponseException>(async () => await operation(jira));
        }

        private IRestClientFactory CreateMockFactory_ExecuteAsync<T>(IRestResponse<T> response, Action<IRestRequest, CancellationToken> restClientCallback = null)
        {
            if(restClientCallback == null)
            {
                restClientCallback = new Action<IRestRequest, CancellationToken>((c, r) => { });
            }

            var client = new Mock<IRestClient>();
            client.Setup(c => c.ExecuteAsync<T>(It.IsAny<IRestRequest>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(response as IRestResponse<T>))
                .Callback<IRestRequest, CancellationToken>((r, c) =>
                 {
                     restClientCallback(r, c);
                 });
            
            var factory = new MockFactory(client.Object);
            return factory;
        }

    }

    class MockFactory : IRestClientFactory
    {
        public Uri BaseUri => throw new NotImplementedException();

        private readonly IRestClient client;

        public MockFactory(IRestClient client)
        {
            this.client = client;
        }

        public IRestClient Create()
        {
            return this.client;
        }
    }


}
