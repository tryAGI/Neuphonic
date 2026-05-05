#nullable enable

namespace Neuphonic
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Clone voice<br/>
        /// Clone a new voice from an uploaded audio sample.
        /// </summary>
        /// <param name="voiceName"></param>
        /// <param name="voiceTags"></param>
        /// <param name="langCode">
        /// Default Value: en
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> CloneVoiceAsync(
            string voiceName,

            global::Neuphonic.CloneVoiceRequest request,
            string? voiceTags = default,
            string? langCode = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone voice<br/>
        /// Clone a new voice from an uploaded audio sample.
        /// </summary>
        /// <param name="voiceName"></param>
        /// <param name="voiceTags"></param>
        /// <param name="langCode">
        /// Default Value: en
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.VoiceMutationResponse>> CloneVoiceAsResponseAsync(
            string voiceName,

            global::Neuphonic.CloneVoiceRequest request,
            string? voiceTags = default,
            string? langCode = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone voice<br/>
        /// Clone a new voice from an uploaded audio sample.
        /// </summary>
        /// <param name="voiceName"></param>
        /// <param name="voiceTags"></param>
        /// <param name="langCode">
        /// Default Value: en
        /// </param>
        /// <param name="voiceFile">
        /// Audio file to use as the voice reference sample.
        /// </param>
        /// <param name="voiceFilename">
        /// Audio file to use as the voice reference sample.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> CloneVoiceAsync(
            string voiceName,
            byte[] voiceFile,
            string voiceFilename,
            string? voiceTags = default,
            string? langCode = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone voice<br/>
        /// Clone a new voice from an uploaded audio sample.
        /// </summary>
        /// <param name="voiceName"></param>
        /// <param name="voiceTags"></param>
        /// <param name="langCode">
        /// Default Value: en
        /// </param>
        /// <param name="voiceFile">
        /// Audio file to use as the voice reference sample.
        /// </param>
        /// <param name="voiceFilename">
        /// Audio file to use as the voice reference sample.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> CloneVoiceAsync(
            string voiceName,
            global::System.IO.Stream voiceFile,
            string voiceFilename,
            string? voiceTags = default,
            string? langCode = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone voice<br/>
        /// Clone a new voice from an uploaded audio sample.
        /// </summary>
        /// <param name="voiceName"></param>
        /// <param name="voiceTags"></param>
        /// <param name="langCode">
        /// Default Value: en
        /// </param>
        /// <param name="voiceFile">
        /// Audio file to use as the voice reference sample.
        /// </param>
        /// <param name="voiceFilename">
        /// Audio file to use as the voice reference sample.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.VoiceMutationResponse>> CloneVoiceAsResponseAsync(
            string voiceName,
            global::System.IO.Stream voiceFile,
            string voiceFilename,
            string? voiceTags = default,
            string? langCode = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}