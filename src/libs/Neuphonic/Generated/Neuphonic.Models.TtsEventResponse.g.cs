
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsEventResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Neuphonic.TtsEventData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Status code for the streamed event.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEventResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="metadata"></param>
        /// <param name="statusCode">
        /// Status code for the streamed event.<br/>
        /// Example: 200
        /// </param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsEventResponse(
            global::Neuphonic.TtsEventData? data,
            object? metadata,
            int? statusCode,
            global::System.Collections.Generic.IList<string>? errors)
        {
            this.Data = data;
            this.Metadata = metadata;
            this.StatusCode = statusCode;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEventResponse" /> class.
        /// </summary>
        public TtsEventResponse()
        {
        }
    }
}