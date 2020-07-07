using RestSharp;
using System;

namespace Jira.NET.Client
{
    public interface IRestClientFactory
    {
        Uri BaseUri { get; }
        IRestClient Create();
    }
}
