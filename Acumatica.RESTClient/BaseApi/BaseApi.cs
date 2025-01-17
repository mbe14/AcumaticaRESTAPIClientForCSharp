﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using System.Threading;
using Acumatica.RESTClient.Model;

namespace Acumatica.RESTClient.Api
{
    /// <summary>
    /// Represents a base class with common logic for all Api classes.
    /// </summary>
    public abstract class BaseApi : IApiAccessor
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BaseApi(String basePath, int timeout = 100000,
            Action<RestRequest, RestClient> requestInterceptor = null,
            Action<RestRequest, RestResponse, RestClient> responseInterceptor = null)
        {
            Configuration = new Configuration(basePath, timeout, requestInterceptor, responseInterceptor);

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BaseApi(Configuration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }
            Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath.ToString();
        }
        private const string ApplicationJsonAcceptContentType = "application/json";
        private const string TextJsonAcceptContentType = "text/json";
        private const string ApplicationXmlAcceptContentType = "application/xml";
        private const string TextXmlAcceptContentType = "text/xml";
        private const string WwwFormEncoded = "application/x-www-form-urlencoded";
        private const string OctetStream = "application/octet-stream";
        private const string AnyAcceptContentType = "*/*";
        [Flags]
        protected enum HeaderContentType : short
        {
            None = 0,
            Json = 1,
            Xml = 2,
            Any = 4,
            WwwForm = 8,
            OctetStream = 16
        };
        protected string ComposeContentHeaders(HeaderContentType contentTypes)
        {
            // to determine the Content-Type header
            string[] localVarHttpContentTypes = ComposeHeadersArray(contentTypes);
            return this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
        }
        protected Dictionary<string, string> ComposeAcceptHeaders(HeaderContentType contentTypes)
        {
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = ComposeHeadersArray(contentTypes);
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            return localVarHeaderParams;
        }

        private static string[] ComposeHeadersArray(HeaderContentType contentTypes)
        {
            List<string> headers = new List<string>();
            if ((contentTypes & HeaderContentType.Json) == HeaderContentType.Json)
            {
                headers.Add(ApplicationJsonAcceptContentType);
                headers.Add(TextJsonAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Xml) == HeaderContentType.Xml)
            {
                headers.Add(ApplicationXmlAcceptContentType);
                headers.Add(TextXmlAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Any) == HeaderContentType.Any)
            {
                headers.Add(AnyAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.WwwForm) == HeaderContentType.WwwForm)
            {
                headers.Add(WwwFormEncoded);
            }

            if ((contentTypes & HeaderContentType.OctetStream) == HeaderContentType.OctetStream)
            {
                headers.Add(OctetStream);
            }
            String[] localVarHttpHeaderAccepts = headers.ToArray();
            return localVarHttpHeaderAccepts;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }
        protected Dictionary<string, FileParameter> ComposeEmptyFileParams()
        {
            return new Dictionary<String, FileParameter>();
        }
        protected List<KeyValuePair<string, string>> ComposeEmptyQueryParams()
        {
            return new List<KeyValuePair<String, String>>();
        }
        protected Dictionary<string, string> ComposeEmptyPathParams()
        {
            return new Dictionary<String, String>();
        }
        protected Dictionary<string, string> ComposeEmptyFormParams()
        {
            return new Dictionary<String, String>();
        }
        protected object ComposeBody(object objectForRequestBody)
        {
            object postBody = null;

            if (objectForRequestBody != null && objectForRequestBody.GetType() != typeof(byte[]))
            {
                postBody = this.Configuration.ApiClient.Serialize(objectForRequestBody); // http body (model) parameter
            }
            else
            {
                postBody = objectForRequestBody; // byte array
            }

            return postBody;
        }
        protected ApiResponse<T> DeserializeResponse<T>(RestResponse response)
        {
            int localVarStatusCode = (int)response.StatusCode;

            return new ApiResponse<T>(localVarStatusCode,
                GetHeadersExceptCookies(response),
                (T)this.Configuration.ApiClient.Deserialize<T>(response));
        }

        protected ApiResponse<object> GetResponseHeaders(RestResponse response)
        {
            int localVarStatusCode = (int)response.StatusCode;

            return new ApiResponse<object>(localVarStatusCode,
                GetHeadersExceptCookies(response),
                null);
        }

        private static Dictionary<string, string> GetHeadersExceptCookies(RestResponse response)
        {
            return response.Headers
                            .Where(x => x.Name != "Set-Cookie")
                            .ToDictionary(x => x.Name, x => x.Value.ToString());
        }

        protected void VerifyResponse<T>(RestResponse response, string methodName)
        {
            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory(methodName, response, typeof(T));
                if (exception != null) throw exception;
            }
        }

        protected void VerifyResponse(RestResponse response, string methodName)
        {
            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory(methodName, response, null);
                if (exception != null) throw exception;
            }
        }

        protected void ThrowMissingParameter(string methodName, string paramName)
        {
            throw new ApiException(400, $"Missing required parameter '{paramName}' when calling {methodName}");
        }

        protected ExceptionFactory _exceptionFactory = (name, response, type) => null;

        #endregion
    }
}
