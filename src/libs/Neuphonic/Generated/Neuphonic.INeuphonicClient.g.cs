
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// Focused manual OpenAPI source for Neuphonic's public Text-to-Speech, voice,<br/>
    /// and agent management HTTP APIs.<br/>
    /// Neuphonic also exposes WebSocket APIs at `wss://api.neuphonic.com/speak/{lang_code}`<br/>
    /// and `wss://api.neuphonic.com/agents`; those transports are documented here for<br/>
    /// completeness, but this OpenAPI document only models HTTP and SSE operations.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface INeuphonicClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Neuphonic.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Neuphonic.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Agent management endpoints.
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// Text-to-speech endpoints.
        /// </summary>
        public TtsClient Tts { get; }

        /// <summary>
        /// Voice library and voice cloning endpoints.
        /// </summary>
        public VoicesClient Voices { get; }

    }
}