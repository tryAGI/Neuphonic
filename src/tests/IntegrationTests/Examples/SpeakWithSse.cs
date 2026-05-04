/*
order: 20
title: Speak with SSE
slug: speak-with-sse

Generate text-to-speech audio over Neuphonic's SSE endpoint.
*/

namespace Neuphonic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SpeakWithSse()
    {
        using var client = GetAuthenticatedClient();

        var totalAudioBytes = 0;
        var errors = new List<string>();

        var request = new TtsRequest
        {
            Text = "Hello from Neuphonic.",
            LangCode = "en",
            SamplingRate = 24000,
            Speed = 1.0,
        };

        await foreach (var message in client.Tts.SpeakWithSseAsync(
            langCode: "en",
            request: request,
            requestOptions: new AutoSDKRequestOptions
            {
                Timeout = TimeSpan.FromSeconds(30),
            }))
        {
            if (message.Data?.Audio is { Length: > 0 } audio)
            {
                totalAudioBytes += audio.Length;
            }

            if (message.Errors is { Count: > 0 } messageErrors)
            {
                errors.AddRange(messageErrors);
            }
        }

        errors.Should().BeEmpty();
        totalAudioBytes.Should().BeGreaterThan(0);
    }
}
