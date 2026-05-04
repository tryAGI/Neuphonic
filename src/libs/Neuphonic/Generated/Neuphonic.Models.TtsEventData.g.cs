
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsEventData
    {
        /// <summary>
        /// Base64 encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public byte[]? Audio { get; set; }

        /// <summary>
        /// Text corresponding to the audio snippet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Sampling rate for the audio snippet.<br/>
        /// Example: 24000
        /// </summary>
        /// <example>24000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        public int? SamplingRate { get; set; }

        /// <summary>
        /// Whether this event terminates a streamed message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public bool? Stop { get; set; }

        /// <summary>
        /// Optional context ID supplied with the input text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEventData" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64 encoded audio bytes.
        /// </param>
        /// <param name="text">
        /// Text corresponding to the audio snippet.
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate for the audio snippet.<br/>
        /// Example: 24000
        /// </param>
        /// <param name="stop">
        /// Whether this event terminates a streamed message.
        /// </param>
        /// <param name="contextId">
        /// Optional context ID supplied with the input text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsEventData(
            byte[]? audio,
            string? text,
            int? samplingRate,
            bool? stop,
            string? contextId)
        {
            this.Audio = audio;
            this.Text = text;
            this.SamplingRate = samplingRate;
            this.Stop = stop;
            this.ContextId = contextId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEventData" /> class.
        /// </summary>
        public TtsEventData()
        {
        }
    }
}