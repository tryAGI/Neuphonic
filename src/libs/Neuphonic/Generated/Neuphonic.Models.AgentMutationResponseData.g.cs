
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentMutationResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMutationResponseData" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="agentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMutationResponseData(
            string? message,
            string? agentId)
        {
            this.Message = message;
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMutationResponseData" /> class.
        /// </summary>
        public AgentMutationResponseData()
        {
        }
    }
}