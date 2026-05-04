
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// Encoding of returned audio.<br/>
    /// Default Value: pcm_linear
    /// </summary>
    public enum TtsRequestEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        PcmLinear,
        /// <summary>
        /// 
        /// </summary>
        PcmMulaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsRequestEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestEncoding value)
        {
            return value switch
            {
                TtsRequestEncoding.PcmLinear => "pcm_linear",
                TtsRequestEncoding.PcmMulaw => "pcm_mulaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_linear" => TtsRequestEncoding.PcmLinear,
                "pcm_mulaw" => TtsRequestEncoding.PcmMulaw,
                _ => null,
            };
        }
    }
}