/*
order: 10
title: List voices
slug: list-voices

List voices available to the Neuphonic account.
*/

namespace Neuphonic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListVoices()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Voices.ListVoicesAsync();

        response.Data.Voices.Should().NotBeNull();
    }
}
