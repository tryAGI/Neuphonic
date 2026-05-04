
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Neuphonic.JsonConverters.TtsRequestEncodingJsonConverter),

            typeof(global::Neuphonic.JsonConverters.TtsRequestEncodingNullableJsonConverter),

            typeof(global::Neuphonic.JsonConverters.TtsRequestOutputFormatJsonConverter),

            typeof(global::Neuphonic.JsonConverters.TtsRequestOutputFormatNullableJsonConverter),

            typeof(global::Neuphonic.JsonConverters.OneOfJsonConverter<string, int?>),

            typeof(global::Neuphonic.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.TtsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.TtsRequestEncoding), TypeInfoPropertyName = "TtsRequestEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.TtsRequestOutputFormat), TypeInfoPropertyName = "TtsRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.TtsEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.TtsEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.JwtTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.JwtTokenResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.ListVoicesResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neuphonic.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.UpdateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.VoiceMutationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.VoiceMutationResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.ListAgentsResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neuphonic.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.GetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.GetAgentResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.AgentMutationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.AgentMutationResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neuphonic.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neuphonic.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neuphonic.OneOf<string, int?>), TypeInfoPropertyName = "OneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neuphonic.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neuphonic.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neuphonic.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neuphonic.OneOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}