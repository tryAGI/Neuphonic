#nullable enable

namespace Neuphonic
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Text to speech over SSE<br/>
        /// Generate speech from text using Server-Sent Events. Each event contains<br/>
        /// base64 encoded audio plus the source text and sampling rate.
        /// </summary>
        /// <param name="langCode">
        /// Example: en
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="jwtToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Neuphonic.TtsEventResponse> SpeakWithSseAsync(
            string langCode,

            global::Neuphonic.TtsRequest request,
            string? apiKey = default,
            string? jwtToken = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to speech over SSE<br/>
        /// Generate speech from text using Server-Sent Events. Each event contains<br/>
        /// base64 encoded audio plus the source text and sampling rate.
        /// </summary>
        /// <param name="langCode">
        /// Example: en
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="jwtToken"></param>
        /// <param name="text">
        /// Text to synthesize.<br/>
        /// Example: Hello, world!
        /// </param>
        /// <param name="speed">
        /// Playback speed. Values are snapped by the service to slow, normal, or fast.<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="temperature">
        /// Randomness introduced into text-to-speech generation.<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="requestLangCode">
        /// Language code for the desired language.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to use for synthesis.<br/>
        /// Example: e564ba7e-aa8d-46a2-96a8-8dffedade48f
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate of returned audio.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="encoding">
        /// Encoding of returned audio.<br/>
        /// Default Value: pcm_linear
        /// </param>
        /// <param name="outputFormat">
        /// Optional output format for generated audio.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Neuphonic.TtsEventResponse> SpeakWithSseAsync(
            string langCode,
            string text,
            string? apiKey = default,
            string? jwtToken = default,
            double? speed = default,
            double? temperature = default,
            string? requestLangCode = default,
            string? voiceId = default,
            int? samplingRate = default,
            global::Neuphonic.TtsRequestEncoding? encoding = default,
            global::Neuphonic.TtsRequestOutputFormat? outputFormat = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}