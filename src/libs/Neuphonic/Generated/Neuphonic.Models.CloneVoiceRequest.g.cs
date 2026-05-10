
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneVoiceRequest
    {
        /// <summary>
        /// Audio file to use as the voice reference sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] VoiceFile { get; set; }

        /// <summary>
        /// Audio file to use as the voice reference sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        /// <param name="voiceFile">
        /// Audio file to use as the voice reference sample.
        /// </param>
        /// <param name="voiceFilename">
        /// Audio file to use as the voice reference sample.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneVoiceRequest(
            byte[] voiceFile,
            string voiceFilename)
        {
            this.VoiceFile = voiceFile ?? throw new global::System.ArgumentNullException(nameof(voiceFile));
            this.VoiceFilename = voiceFilename ?? throw new global::System.ArgumentNullException(nameof(voiceFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        public CloneVoiceRequest()
        {
        }

    }
}