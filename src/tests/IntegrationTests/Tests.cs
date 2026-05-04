namespace Neuphonic.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static NeuphonicClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NEUPHONIC_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("NEUPHONIC_API_KEY environment variable is not found.");

        var client = new NeuphonicClient(apiKey);

        return client;
    }
}
