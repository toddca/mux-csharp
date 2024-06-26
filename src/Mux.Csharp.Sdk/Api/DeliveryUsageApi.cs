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
    public interface IDeliveryUsageApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Usage
        /// </summary>
        /// <remarks>
        /// Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <returns>ListDeliveryUsageResponse</returns>
        ListDeliveryUsageResponse ListDeliveryUsage(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>));

        /// <summary>
        /// List Usage
        /// </summary>
        /// <remarks>
        /// Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <returns>ApiResponse of ListDeliveryUsageResponse</returns>
        ApiResponse<ListDeliveryUsageResponse> ListDeliveryUsageWithHttpInfo(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliveryUsageApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Usage
        /// </summary>
        /// <remarks>
        /// Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListDeliveryUsageResponse</returns>
        System.Threading.Tasks.Task<ListDeliveryUsageResponse> ListDeliveryUsageAsync(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Usage
        /// </summary>
        /// <remarks>
        /// Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListDeliveryUsageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListDeliveryUsageResponse>> ListDeliveryUsageWithHttpInfoAsync(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliveryUsageApi : IDeliveryUsageApiSync, IDeliveryUsageApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeliveryUsageApi : IDeliveryUsageApi
    {
        private Mux.Csharp.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryUsageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliveryUsageApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryUsageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliveryUsageApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DeliveryUsageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeliveryUsageApi(Mux.Csharp.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DeliveryUsageApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DeliveryUsageApi(Mux.Csharp.Sdk.Client.ISynchronousClient client, Mux.Csharp.Sdk.Client.IAsynchronousClient asyncClient, Mux.Csharp.Sdk.Client.IReadableConfiguration configuration)
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
        /// List Usage Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <returns>ListDeliveryUsageResponse</returns>
        public ListDeliveryUsageResponse ListDeliveryUsage(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListDeliveryUsageResponse> localVarResponse = ListDeliveryUsageWithHttpInfo(page, limit, assetId, liveStreamId, timeframe);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Usage Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <returns>ApiResponse of ListDeliveryUsageResponse</returns>
        public Mux.Csharp.Sdk.Client.ApiResponse<ListDeliveryUsageResponse> ListDeliveryUsageWithHttpInfo(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>))
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

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (assetId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asset_id", assetId));
            }
            if (liveStreamId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "live_stream_id", liveStreamId));
            }
            if (timeframe != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "timeframe[]", timeframe));
            }

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListDeliveryUsageResponse>("/video/v1/delivery-usage", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDeliveryUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Usage Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListDeliveryUsageResponse</returns>
        public async System.Threading.Tasks.Task<ListDeliveryUsageResponse> ListDeliveryUsageAsync(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListDeliveryUsageResponse> localVarResponse = await ListDeliveryUsageWithHttpInfoAsync(page, limit, assetId, liveStreamId, timeframe, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Usage Returns a list of delivery usage records and their associated Asset IDs or Live Stream IDs.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Offset by this many pages, of the size of &#x60;limit&#x60; (optional, default to 1)</param>
        /// <param name="limit">Number of items to include in the response (optional, default to 100)</param>
        /// <param name="assetId">Filter response to return delivery usage for this asset only. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="liveStreamId">Filter response to return delivery usage for assets for this live stream. You cannot specify both the &#x60;asset_id&#x60; and &#x60;live_stream_id&#x60; parameters together. (optional)</param>
        /// <param name="timeframe">Time window to get delivery usage information. timeframe[0] indicates the start time, timeframe[1] indicates the end time in seconds since the Unix epoch. Default time window is 1 hour representing usage from 13th to 12th hour from when the request is made. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListDeliveryUsageResponse)</returns>
        public async System.Threading.Tasks.Task<Mux.Csharp.Sdk.Client.ApiResponse<ListDeliveryUsageResponse>> ListDeliveryUsageWithHttpInfoAsync(int? page = default(int?), int? limit = default(int?), string assetId = default(string), string liveStreamId = default(string), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (assetId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asset_id", assetId));
            }
            if (liveStreamId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("", "live_stream_id", liveStreamId));
            }
            if (timeframe != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "timeframe[]", timeframe));
            }

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListDeliveryUsageResponse>("/video/v1/delivery-usage", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDeliveryUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
