#nullable enable

namespace Neuphonic
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Create SSE JWT token<br/>
        /// Exchange an API key for a short-lived JWT token for lower-latency SSE requests.
        /// </summary>
        /// <param name="expiration">
        /// Default Value: 3600
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.JwtTokenResponse> CreateSseJwtTokenAsync(
            int? expiration = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}