#nullable enable

namespace Neuphonic
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Ping
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PingAsync(
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ping
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AutoSDKHttpResponse<string>> PingAsResponseAsync(
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}