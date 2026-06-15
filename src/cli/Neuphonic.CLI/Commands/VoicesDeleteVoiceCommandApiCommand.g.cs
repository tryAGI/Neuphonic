#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class VoicesDeleteVoiceCommandApiCommand
{
    private static Argument<string> VoiceId { get; } = new(
        name: @"voice-id")
    {
        Description = @"Voice ID.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Neuphonic.VoiceMutationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Neuphonic.VoiceMutationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-voice", @"Delete cloned voice
Delete a cloned voice by voice ID.");
                        command.Arguments.Add(VoiceId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Voices.DeleteVoiceAsync(
                                    voiceId: voiceId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Neuphonic.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}