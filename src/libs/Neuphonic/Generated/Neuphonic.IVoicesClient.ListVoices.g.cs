#nullable enable

namespace Neuphonic
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List voices<br/>
        /// List voices available in the caller's voice library.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.ListVoicesResponse> ListVoicesAsync(
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List voices<br/>
        /// List voices available in the caller's voice library.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.ListVoicesResponse>> ListVoicesAsResponseAsync(
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}