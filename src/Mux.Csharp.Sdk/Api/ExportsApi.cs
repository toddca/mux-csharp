/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Mux.Csharp.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List property video view export links
        /// </summary>
        /// <remarks>
        /// The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListExportsResponse</returns>
        [Obsolete]
        ListExportsResponse ListExports();

        /// <summary>
        /// List property video view export links
        /// </summary>
        /// <remarks>
        /// The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListExportsResponse</returns>
        [Obsolete]
        ApiResponse<ListExportsResponse> ListExportsWithHttpInfo();
        /// <summary>
        /// List available property view exports
        /// </summary>
        /// <remarks>
        /// Lists the available video view exports along with URLs to retrieve them.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListVideoViewExportsResponse</returns>
        ListVideoViewExportsResponse ListExportsViews();

        /// <summary>
        /// List available property view exports
        /// </summary>
        /// <remarks>
        /// Lists the available video view exports along with URLs to retrieve them.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListVideoViewExportsResponse</returns>
        ApiResponse<ListVideoViewExportsResponse> ListExportsViewsWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List property video view export links
        /// </summary>
        /// <remarks>
        /// The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListExportsResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ListExportsResponse> ListExportsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List property video view export links
        /// </summary>
        /// <remarks>
        /// The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListExportsResponse)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<ListExportsResponse>> ListExportsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List available property view exports
        /// </summary>
        /// <remarks>
        /// Lists the available video view exports along with URLs to retrieve them.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListVideoViewExportsResponse</returns>
        System.Threading.Tasks.Task<ListVideoViewExportsResponse> ListExportsViewsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List available property view exports
        /// </summary>
        /// <remarks>
        /// Lists the available video view exports along with URLs to retrieve them.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListVideoViewExportsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListVideoViewExportsResponse>> ListExportsViewsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportsApi : IExportsApiSync, IExportsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExportsApi : IExportsApi
    {
        private Mux.Csharp.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportsApi(string basePath)
        {
            this.Configuration = Mux.Csharp.Sdk.Client.Configuration.MergeConfigurations(
                Mux.Csharp.Sdk.Client.GlobalConfiguration.Instance,
                new Mux.Csharp.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExportsApi(Mux.Csharp.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            this.Configuration = Mux.Csharp.Sdk.Client.Configuration.MergeConfigurations(
                Mux.Csharp.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ExportsApi(Mux.Csharp.Sdk.Client.ISynchronousClient client, Mux.Csharp.Sdk.Client.IAsynchronousClient asyncClient, Mux.Csharp.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (asyncClient == null) throw new ArgumentNullException(nameof(asyncClient));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Mux.Csharp.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Mux.Csharp.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Mux.Csharp.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Mux.Csharp.Sdk.Client.ExceptionFactory ExceptionFactory
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

        /// <summary>
        /// List property video view export links The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListExportsResponse</returns>
        [Obsolete]
        public ListExportsResponse ListExports()
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListExportsResponse> localVarResponse = ListExportsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List property video view export links The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListExportsResponse</returns>
        [Obsolete]
        public Mux.Csharp.Sdk.Client.ApiResponse<ListExportsResponse> ListExportsWithHttpInfo()
        {
            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListExportsResponse>("/data/v1/exports", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListExports", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List property video view export links The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListExportsResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ListExportsResponse> ListExportsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListExportsResponse> localVarResponse = await ListExportsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List property video view export links The API has been replaced by the list-exports-views API call.  Lists the available video view exports along with URLs to retrieve them. 
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListExportsResponse)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<Mux.Csharp.Sdk.Client.ApiResponse<ListExportsResponse>> ListExportsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListExportsResponse>("/data/v1/exports", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListExports", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List available property view exports Lists the available video view exports along with URLs to retrieve them.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ListVideoViewExportsResponse</returns>
        public ListVideoViewExportsResponse ListExportsViews()
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListVideoViewExportsResponse> localVarResponse = ListExportsViewsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List available property view exports Lists the available video view exports along with URLs to retrieve them.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ListVideoViewExportsResponse</returns>
        public Mux.Csharp.Sdk.Client.ApiResponse<ListVideoViewExportsResponse> ListExportsViewsWithHttpInfo()
        {
            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListVideoViewExportsResponse>("/data/v1/exports/views", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListExportsViews", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List available property view exports Lists the available video view exports along with URLs to retrieve them.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListVideoViewExportsResponse</returns>
        public async System.Threading.Tasks.Task<ListVideoViewExportsResponse> ListExportsViewsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListVideoViewExportsResponse> localVarResponse = await ListExportsViewsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List available property view exports Lists the available video view exports along with URLs to retrieve them.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListVideoViewExportsResponse)</returns>
        public async System.Threading.Tasks.Task<Mux.Csharp.Sdk.Client.ApiResponse<ListVideoViewExportsResponse>> ListExportsViewsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListVideoViewExportsResponse>("/data/v1/exports/views", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListExportsViews", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
