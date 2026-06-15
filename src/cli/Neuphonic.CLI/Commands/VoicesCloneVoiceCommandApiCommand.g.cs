#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class VoicesCloneVoiceCommandApiCommand
{
    private static Option<string> VoiceName { get; } = new(
        name: @"--voice-name")
    {
        Description = @"Name for the cloned voice.",
        Required = true,
    };

    private static Option<string?> VoiceTags { get; } = new(
        name: @"--voice-tags")
    {
        Description = @"Comma-separated tags describing the voice.",
    };

    private static Option<string?> LangCode { get; } = new(
        name: @"--lang-code")
    {
        Description = @"Language code for the voice sample.",
    };

    private static Option<byte[]> VoiceFile { get; } = new(
        name: @"--voice-file")
    {
        Description = @"Audio file to use as the voice reference sample.",
        Required = true,
    };

    private static Option<string> VoiceFilename { get; } = new(
        name: @"--voice-filename")
    {
        Description = @"Audio file to use as the voice reference sample.",
        Required = true,
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
        var command = new Command(@"clone-voice", @"Clone voice
Clone a new voice from an uploaded audio sample.");
                        command.Options.Add(VoiceName);
                        command.Options.Add(VoiceTags);
                        command.Options.Add(LangCode);
                        command.Options.Add(VoiceFile);
                        command.Options.Add(VoiceFilename);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var voiceName = parseResult.GetRequiredValue(VoiceName);
                        var voiceTags = parseResult.GetValue(VoiceTags);
                        var langCode = parseResult.GetValue(LangCode);
                        var voiceFile = parseResult.GetRequiredValue(VoiceFile);
                        var voiceFilename = parseResult.GetRequiredValue(VoiceFilename);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Voices.CloneVoiceAsync(
                                    voiceName: voiceName,
                                    voiceTags: voiceTags,
                                    langCode: langCode,
                                    voiceFile: voiceFile,
                                    voiceFilename: voiceFilename,
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