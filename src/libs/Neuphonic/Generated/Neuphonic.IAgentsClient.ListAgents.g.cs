#nullable enable

namespace Neuphonic
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agents<br/>
        /// List agents that belong to the caller.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.ListAgentsResponse> ListAgentsAsync(
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agents<br/>
        /// List agents that belong to the caller.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.ListAgentsResponse>> ListAgentsAsResponseAsync(
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}