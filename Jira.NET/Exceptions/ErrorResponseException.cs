using System;
using System.Net;

namespace Jira.NET.Exceptions
{
    public class ErrorResponseException : Exception
    {
        public HttpStatusCode? StatusCode { get; private set; } = null;

        public ErrorResponseException(string message, HttpStatusCode? statusCode = null) : base(message)
        {
            StatusCode = statusCode;
        }

        public ErrorResponseException(string message, Exception innerException, HttpStatusCode? statusCode = null) : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
