﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;

namespace Acumatica.Auth.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RootApi : BaseApi
    {
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="RootApi"/> class.
		/// </summary>
		/// <returns></returns>
		public RootApi(String basePath)
        {
            this.Configuration = new Configuration(basePath);

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RootApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RootApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }
		#endregion

		#region Public Methods

		/// <summary>
		/// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
		/// Available stating from 2019 R2 version of Acumatica ERP.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <returns>VersionAndEndpoints</returns>
		public VersionAndEndpoints RootGet()
        {
            ApiResponse<VersionAndEndpoints> localVarResponse = RootGetWithHttpInfo();
            return localVarResponse.Data;
        }
        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionAndEndpoints</returns>
        public async System.Threading.Tasks.Task<VersionAndEndpoints> RootGetAsync()
        {
            ApiResponse<VersionAndEndpoints> localVarResponse = await RootGetAsyncWithHttpInfo();
            return localVarResponse.Data;

        }

		#endregion

		#region Implementation
		/// <summary>
		/// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
		/// Available stating from 2019 R2 version of Acumatica ERP.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of VersionAndEndpoints</returns>
		protected ApiResponse<VersionAndEndpoints> RootGetWithHttpInfo()
        {

            var localVarPath = "/entity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, ComposeAcceptHeaders(HeaderContentType.Xml | HeaderContentType.Json), localVarFormParams, localVarFileParams,
                localVarPathParams, ComposeContentHeaders(HeaderContentType.None));

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RootGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return DeserializeResponseGeneric<VersionAndEndpoints>(localVarResponse, localVarStatusCode);
        }



        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionAndEndpoints)</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<VersionAndEndpoints>> RootGetAsyncWithHttpInfo()
        {
            var localVarPath = "/entity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, ComposeAcceptHeaders(HeaderContentType.Json | HeaderContentType.Xml), localVarFormParams, localVarFileParams,
                localVarPathParams, ComposeContentHeaders(HeaderContentType.None));

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RootGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return DeserializeResponseGeneric<VersionAndEndpoints>(localVarResponse, localVarStatusCode); 
        }
		#endregion
	}
}