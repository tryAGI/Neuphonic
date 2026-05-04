
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Neuphonic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.TtsRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.TtsRequestEncoding? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.TtsRequestOutputFormat? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.TtsEventResponse? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.TtsEventData? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.JwtTokenResponse? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.JwtTokenResponseData? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.ListVoicesResponse? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.ListVoicesResponseData? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Neuphonic.Voice>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.Voice? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.CloneVoiceRequest? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.UpdateVoiceRequest? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.VoiceMutationResponse? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.VoiceMutationResponseData? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.ListAgentsResponse? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.ListAgentsResponseData? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Neuphonic.Agent>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.Agent? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.GetAgentResponse? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.GetAgentResponseData? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.CreateAgentRequest? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.AgentMutationResponse? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.AgentMutationResponseData? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.HTTPValidationError? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Neuphonic.ValidationError>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.ValidationError? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Neuphonic.OneOf<string, int?>>? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Neuphonic.OneOf<string, int?>? Type36 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Neuphonic.Voice>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Neuphonic.Agent>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Neuphonic.ValidationError>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Neuphonic.OneOf<string, int?>>? ListType4 { get; set; }
    }
}