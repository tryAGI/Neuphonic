#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Neuphonic.CLI.Commands;

internal static partial class TtsSpeakWithSseCommandApiCommand
{
    private static Argument<string> LangCode { get; } = new(
        name: @"lang-code")
    {
        Description = @"Language code for the desired language.",
    };

    private static Option<string?> ApiKey { get; } = new(
        name: @"--api-key")
    {
        Description = @"Optional API key query parameter supported by the SSE transport.",
    };

    private static Option<string?> JwtToken { get; } = new(
        name: @"--jwt-token")
    {
        Description = @"Optional JWT token query parameter returned by the SSE auth endpoint.",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"Text to synthesize.",
        Required = true,
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"Playback speed. Values are snapped by the service to slow, normal, or fast.",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"Randomness introduced into text-to-speech generation.",
    };

    private static Option<string?> RequestLangCode { get; } = new(
        name: @"--lang-code")
    {
        Description = @"Language code for the desired language.",
    };

    private static Option<string?> VoiceId { get; } = new(
        name: @"--voice-id")
    {
        Description = @"Voice ID to use for synthesis.",
    };

    private static Option<int?> SamplingRate { get; } = new(
        name: @"--sampling-rate")
    {
        Description = @"Sampling rate of returned audio.",
    };

    private static Option<global::Neuphonic.TtsRequestEncoding?> Encoding { get; } = new(
        name: @"--encoding")
    {
        Description = @"Encoding of returned audio.",
    };

    private static Option<global::Neuphonic.TtsRequestOutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"Optional output format for generated audio.",
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

    public static Command Create()
    {
        var command = new Command(@"speak-with-sse", @"Text to speech over SSE
Generate speech from text using Server-Sent Events. Each event contains
base64 encoded audio plus the source text and sampling rate.
");
                        command.Arguments.Add(LangCode);
                        command.Options.Add(ApiKey);
                        command.Options.Add(JwtToken);
                        command.Options.Add(Text);
                        command.Options.Add(Speed);
                        command.Options.Add(Temperature);
                        command.Options.Add(RequestLangCode);
                        command.Options.Add(VoiceId);
                        command.Options.Add(SamplingRate);
                        command.Options.Add(Encoding);
                        command.Options.Add(OutputFormat);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Neuphonic.TtsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Neuphonic.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var langCode = parseResult.GetRequiredValue(LangCode);
                        var apiKey = parseResult.GetValue(ApiKey);
                        var jwtToken = parseResult.GetValue(JwtToken);
                        var text = parseResult.GetRequiredValue(Text);
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var requestLangCode = CliRuntime.WasSpecified(parseResult, RequestLangCode) ? parseResult.GetValue(RequestLangCode) : (__requestBase is { } __RequestLangCodeBaseValue ? __RequestLangCodeBaseValue.LangCode : default);
                        var voiceId = CliRuntime.WasSpecified(parseResult, VoiceId) ? parseResult.GetValue(VoiceId) : (__requestBase is { } __VoiceIdBaseValue ? __VoiceIdBaseValue.VoiceId : default);
                        var samplingRate = CliRuntime.WasSpecified(parseResult, SamplingRate) ? parseResult.GetValue(SamplingRate) : (__requestBase is { } __SamplingRateBaseValue ? __SamplingRateBaseValue.SamplingRate : default);
                        var encoding = CliRuntime.WasSpecified(parseResult, Encoding) ? parseResult.GetValue(Encoding) : (__requestBase is { } __EncodingBaseValue ? __EncodingBaseValue.Encoding : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = client.Tts.SpeakWithSseAsync(
                                    langCode: langCode,
                                    apiKey: apiKey,
                                    jwtToken: jwtToken,
                                    text: text,
                                    speed: speed,
                                    temperature: temperature,
                                    requestLangCode: requestLangCode,
                                    voiceId: voiceId,
                                    samplingRate: samplingRate,
                                    encoding: encoding,
                                    outputFormat: outputFormat,
                                    cancellationToken: cancellationToken);

                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteResponseLineAsync(
                                        parseResult,
                                        item,
                                        global::Neuphonic.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}