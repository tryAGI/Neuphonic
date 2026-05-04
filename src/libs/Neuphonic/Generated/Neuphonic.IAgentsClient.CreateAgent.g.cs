#nullable enable

namespace Neuphonic
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create agent<br/>
        /// Create a Neuphonic conversational agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AgentMutationResponse> CreateAgentAsync(

            global::Neuphonic.CreateAgentRequest request,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent<br/>
        /// Create a Neuphonic conversational agent.
        /// </summary>
        /// <param name="name">
        /// Agent name.
        /// </param>
        /// <param name="prompt">
        /// System prompt for the agent.
        /// </param>
        /// <param name="greeting">
        /// Initial greeting for the agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neuphonic.AgentMutationResponse> CreateAgentAsync(
            string name,
            string? prompt = default,
            string? greeting = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}