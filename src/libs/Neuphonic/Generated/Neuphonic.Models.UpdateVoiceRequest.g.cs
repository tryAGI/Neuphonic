
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVoiceRequest
    {
        /// <summary>
        /// New audio file to use as the voice reference sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_voice_file")]
        public byte[]? NewVoiceFile { get; set; }

        /// <summary>
        /// New audio file to use as the voice reference sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_voice_filename")]
        public string? NewVoiceFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
        /// <param name="newVoiceFile">
        /// New audio file to use as the voice reference sample.
        /// </param>
        /// <param name="newVoiceFilename">
        /// New audio file to use as the voice reference sample.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVoiceRequest(
            byte[]? newVoiceFile,
            string? newVoiceFilename)
        {
            this.NewVoiceFile = newVoiceFile;
            this.NewVoiceFilename = newVoiceFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
        public UpdateVoiceRequest()
        {
        }
    }
}