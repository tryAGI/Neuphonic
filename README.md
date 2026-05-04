<div class="docs-hero">
  <h1>Neuphonic</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Neuphonic generated from a focused manual OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/Neuphonic/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/Neuphonic"></a>
    <a href="https://github.com/tryAGI/Neuphonic/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Neuphonic/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Neuphonic/blob/main/LICENSE"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Neuphonic"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="https://docs.neuphonic.com/">Neuphonic's public docs and SDKs</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using Neuphonic;

using var client = new NeuphonicClient(apiKey);
```

<!-- EXAMPLES:START -->
### List voices
List voices available to the Neuphonic account.

```csharp
using var client = new NeuphonicClient(apiKey);

var response = await client.Voices.ListVoicesAsync();
```

### Speak with SSE
Generate text-to-speech audio over Neuphonic's SSE endpoint.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Neuphonic/issues">tryAGI/Neuphonic</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Neuphonic/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
