
#nullable enable

namespace Neuphonic
{
    public sealed partial class NeuphonicClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "X-API-KEY")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Neuphonic.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyXApiKey",
                Location = "Header",
                Name = "X-API-KEY",
                Value = apiKey,
            });
        }
    }
}