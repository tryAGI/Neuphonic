
#nullable enable

namespace Neuphonic
{
    /// <summary>
    /// Optional output format for generated audio.
    /// </summary>
    public enum TtsRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsRequestOutputFormat value)
        {
            return value switch
            {
                TtsRequestOutputFormat.Mp3 => "mp3",
                TtsRequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => TtsRequestOutputFormat.Mp3,
                "wav" => TtsRequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}