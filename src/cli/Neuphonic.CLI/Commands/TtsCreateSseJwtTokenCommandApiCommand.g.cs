#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class TtsCreateSseJwtTokenCommandApiCommand
{
    private static Option<int?> Expiration { get; } = new(
        name: @"--expiration")
    {
        Description = @"Token lifetime in seconds.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Neuphonic.JwtTokenResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Neuphonic.JwtTokenResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-sse-jwt-token", @"Create SSE JWT token
Exchange an API key for a short-lived JWT token for lower-latency SSE requests.");
                        command.Options.Add(Expiration);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var expiration = parseResult.GetValue(Expiration);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tts.CreateSseJwtTokenAsync(
                                    expiration: expiration,
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