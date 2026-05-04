#nullable enable

namespace Neuphonic
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete cloned voice<br/>
        /// Delete a cloned voice by voice ID.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> DeleteVoiceAsync(
            string voiceId,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}