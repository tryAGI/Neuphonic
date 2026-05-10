
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neuphonic.Agent Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseData" /> class.
        /// </summary>
        /// <param name="agent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentResponseData(
            global::Neuphonic.Agent agent)
        {
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseData" /> class.
        /// </summary>
        public GetAgentResponseData()
        {
        }

    }
}