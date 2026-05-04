# List voices

List voices available to the Neuphonic account.

This example assumes `using Neuphonic;` is in scope and `apiKey` contains your Neuphonic API key.

```csharp
using var client = new NeuphonicClient(apiKey);

var response = await client.Voices.ListVoicesAsync();
```