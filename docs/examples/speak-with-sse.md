# Speak with SSE

Generate text-to-speech audio over Neuphonic's SSE endpoint.

This example assumes `using Neuphonic;` is in scope and `apiKey` contains your Neuphonic API key.

```csharp
using var client = new NeuphonicClient(apiKey);

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
```