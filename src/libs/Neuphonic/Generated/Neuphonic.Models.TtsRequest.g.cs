
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsRequest
    {
        /// <summary>
        /// Text to synthesize.<br/>
        /// Example: Hello, world!
        /// </summary>
        /// <example>Hello, world!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Playback speed. Values are snapped by the service to slow, normal, or fast.<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Randomness introduced into text-to-speech generation.<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Language code for the desired language.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang_code")]
        public string? LangCode { get; set; }

        /// <summary>
        /// Voice ID to use for synthesis.<br/>
        /// Example: e564ba7e-aa8d-46a2-96a8-8dffedade48f
        /// </summary>
        /// <example>e564ba7e-aa8d-46a2-96a8-8dffedade48f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Sampling rate of returned audio.<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        public int? SamplingRate { get; set; }

        /// <summary>
        /// Encoding of returned audio.<br/>
        /// Default Value: pcm_linear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neuphonic.JsonConverters.TtsRequestEncodingJsonConverter))]
        public global::Neuphonic.TtsRequestEncoding? Encoding { get; set; }

        /// <summary>
        /// Optional output format for generated audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neuphonic.JsonConverters.TtsRequestOutputFormatJsonConverter))]
        public global::Neuphonic.TtsRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRequest" /> class.
        /// </summary>
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
        /// <param name="langCode">
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRequest(
            string text,
            double? speed,
            double? temperature,
            string? langCode,
            string? voiceId,
            int? samplingRate,
            global::Neuphonic.TtsRequestEncoding? encoding,
            global::Neuphonic.TtsRequestOutputFormat? outputFormat)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Speed = speed;
            this.Temperature = temperature;
            this.LangCode = langCode;
            this.VoiceId = voiceId;
            this.SamplingRate = samplingRate;
            this.Encoding = encoding;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRequest" /> class.
        /// </summary>
        public TtsRequest()
        {
        }
    }
}