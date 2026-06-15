#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class VoicesUpdateVoiceCommandApiCommand
{
    private static Argument<string> VoiceId { get; } = new(
        name: @"voice-id")
    {
        Description = @"Voice ID.",
    };

    private static Option<string?> NewVoiceName { get; } = new(
        name: @"--new-voice-name")
    {
        Description = @"Updated voice name.",
    };

    private static Option<string?> NewVoiceTags { get; } = new(
        name: @"--new-voice-tags")
    {
        Description = @"Updated comma-separated voice tags.",
    };

    private static Option<byte[]?> NewVoiceFile { get; } = new(
        name: @"--new-voice-file")
    {
        Description = @"New audio file to use as the voice reference sample.",
    };

    private static Option<string?> NewVoiceFilename { get; } = new(
        name: @"--new-voice-filename")
    {
        Description = @"New audio file to use as the voice reference sample.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
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
        var command = new Command(@"update-voice", @"Update cloned voice
Update a cloned voice's name, tags, or reference audio.");
                        command.Arguments.Add(VoiceId);
                        command.Options.Add(NewVoiceName);
                        command.Options.Add(NewVoiceTags);
                        command.Options.Add(NewVoiceFile);
                        command.Options.Add(NewVoiceFilename);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Neuphonic.UpdateVoiceRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Neuphonic.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                        var newVoiceName = parseResult.GetValue(NewVoiceName);
                        var newVoiceTags = parseResult.GetValue(NewVoiceTags);
                        var newVoiceFile = CliRuntime.WasSpecified(parseResult, NewVoiceFile) ? parseResult.GetValue(NewVoiceFile) : (__requestBase is { } __NewVoiceFileBaseValue ? __NewVoiceFileBaseValue.NewVoiceFile : default);
                        var newVoiceFilename = CliRuntime.WasSpecified(parseResult, NewVoiceFilename) ? parseResult.GetValue(NewVoiceFilename) : (__requestBase is { } __NewVoiceFilenameBaseValue ? __NewVoiceFilenameBaseValue.NewVoiceFilename : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Voices.UpdateVoiceAsync(
                                    voiceId: voiceId,
                                    newVoiceName: newVoiceName,
                                    newVoiceTags: newVoiceTags,
                                    newVoiceFile: newVoiceFile,
                                    newVoiceFilename: newVoiceFilename,
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