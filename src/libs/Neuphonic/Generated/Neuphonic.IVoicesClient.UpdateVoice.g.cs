#nullable enable

namespace Neuphonic
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update cloned voice<br/>
        /// Update a cloned voice's name, tags, or reference audio.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="newVoiceName"></param>
        /// <param name="newVoiceTags"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> UpdateVoiceAsync(
            string voiceId,

            global::Neuphonic.UpdateVoiceRequest request,
            string? newVoiceName = default,
            string? newVoiceTags = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update cloned voice<br/>
        /// Update a cloned voice's name, tags, or reference audio.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="newVoiceName"></param>
        /// <param name="newVoiceTags"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.VoiceMutationResponse>> UpdateVoiceAsResponseAsync(
            string voiceId,

            global::Neuphonic.UpdateVoiceRequest request,
            string? newVoiceName = default,
            string? newVoiceTags = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update cloned voice<br/>
        /// Update a cloned voice's name, tags, or reference audio.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="newVoiceName"></param>
        /// <param name="newVoiceTags"></param>
        /// <param name="newVoiceFile">
        /// New audio file to use as the voice reference sample.
        /// </param>
        /// <param name="newVoiceFilename">
        /// New audio file to use as the voice reference sample.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> UpdateVoiceAsync(
            string voiceId,
            string? newVoiceName = default,
            string? newVoiceTags = default,
            byte[]? newVoiceFile = default,
            string? newVoiceFilename = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}