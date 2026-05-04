#nullable enable

namespace Neuphonic.JsonConverters
{
    /// <inheritdoc />
    public sealed class TtsRequestEncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neuphonic.TtsRequestEncoding>
    {
        /// <inheritdoc />
        public override global::Neuphonic.TtsRequestEncoding Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Neuphonic.TtsRequestEncodingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neuphonic.TtsRequestEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neuphonic.TtsRequestEncoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neuphonic.TtsRequestEncoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Neuphonic.TtsRequestEncodingExtensions.ToValueString(value));
        }
    }
}
