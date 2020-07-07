using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;

namespace Jira.NET.Client
{
    public class RestClientFactory : IRestClientFactory
    {
        public Uri BaseUri { get; private set; }
        protected CookieContainer CookieContainer { get; private set; }
        private IAuthenticator Authenticator { get; set; }

        public RestClientFactory(string baseurl, string username, string password) : this(baseurl)
        {
            Authenticator = new HttpBasicAuthenticator(username, password);
        }

        public RestClientFactory(string baseurl)
        {
            CookieContainer = new CookieContainer();
            BaseUri = new Uri(baseurl);
        }

        public virtual IRestClient Create()
        {
            var client = new RestClient(BaseUri);
            if(Authenticator != null)
            {
                client.Authenticator = Authenticator;
            }

            client.CookieContainer = CookieContainer;

            return client;
        }
    }
}
