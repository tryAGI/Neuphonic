
#nullable enable

namespace Neuphonic
{
    public partial class TtsClient
    {


        private static readonly global::Neuphonic.EndPointSecurityRequirement s_SpeakWithSseSecurityRequirement0 =
            new global::Neuphonic.EndPointSecurityRequirement
            {
                Authorizations = new global::Neuphonic.EndPointAuthorizationRequirement[]
                {                    new global::Neuphonic.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-KEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Neuphonic.EndPointSecurityRequirement[] s_SpeakWithSseSecurityRequirements =
            new global::Neuphonic.EndPointSecurityRequirement[]
            {                s_SpeakWithSseSecurityRequirement0,
            };
        partial void PrepareSpeakWithSseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string langCode,
            ref string? apiKey,
            ref string? jwtToken,
            global::Neuphonic.TtsRequest request);
        partial void PrepareSpeakWithSseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string langCode,
            string? apiKey,
            string? jwtToken,
            global::Neuphonic.TtsRequest request);
        partial void ProcessSpeakWithSseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Text to speech over SSE<br/>
        /// Generate speech from text using Server-Sent Events. Each event contains<br/>
        /// base64 encoded audio plus the source text and sampling rate.
        /// </summary>
        /// <param name="langCode">
        /// Example: en
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="jwtToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Neuphonic.TtsEventResponse> SpeakWithSseAsync(
            string langCode,

            global::Neuphonic.TtsRequest request,
            string? apiKey = default,
            string? jwtToken = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSpeakWithSseArguments(
                httpClient: HttpClient,
                langCode: ref langCode,
                apiKey: ref apiKey,
                jwtToken: ref jwtToken,
                request: request);


            var __authorizations = global::Neuphonic.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SpeakWithSseSecurityRequirements,
                operationName: "SpeakWithSseAsync");

            using var __timeoutCancellationTokenSource = global::Neuphonic.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Neuphonic.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Neuphonic.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Neuphonic.PathBuilder(
                                path: $"/sse/speak/{langCode}",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("api_key", apiKey)
                                .AddOptionalParameter("jwt_token", jwtToken) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Neuphonic.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Neuphonic.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSpeakWithSseRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    langCode: langCode!,
                    apiKey: apiKey,
                    jwtToken: jwtToken,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Neuphonic.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SpeakWithSse",
                                methodName: "SpeakWithSseAsync",
                                pathTemplate: "$\"/sse/speak/{langCode}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SpeakWithSse",
                                methodName: "SpeakWithSseAsync",
                                pathTemplate: "$\"/sse/speak/{langCode}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Neuphonic.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SpeakWithSse",
                                methodName: "SpeakWithSseAsync",
                                pathTemplate: "$\"/sse/speak/{langCode}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSpeakWithSseResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SpeakWithSse",
                                methodName: "SpeakWithSseAsync",
                                pathTemplate: "$\"/sse/speak/{langCode}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SpeakWithSse",
                                methodName: "SpeakWithSseAsync",
                                pathTemplate: "$\"/sse/speak/{langCode}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw new global::Neuphonic.ApiException(
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::Neuphonic.TtsEventResponse.FromJson(__content, JsonSerializerContext) ??
                                                       throw new global::Neuphonic.ApiException(
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           statusCode: __response.StatusCode)
                                                       {
                                                           ResponseBody = __content,
                                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value),
                                                       };

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Text to speech over SSE<br/>
        /// Generate speech from text using Server-Sent Events. Each event contains<br/>
        /// base64 encoded audio plus the source text and sampling rate.
        /// </summary>
        /// <param name="langCode">
        /// Example: en
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="jwtToken"></param>
        /// <param name="text">
        /// Text to synthesize.<br/>
        /// Example: Hello, world!
        /// </param>
        /// <param name="speed">
        /// Playback speed. Values are snapped by the service to slow, normal, or fast.<br/>
        /// Default Value: 1.0<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="temperature">
        /// Randomness introduced into text-to-speech generation.<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="requestLangCode">
        /// Language code for the desired language.<br/>
        /// Default Value: en<br/>
        /// Example: en
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to use for synthesis.<br/>
        /// Example: e564ba7e-aa8d-46a2-96a8-8dffedade48f
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate of returned audio.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="encoding">
        /// Encoding of returned audio.<br/>
        /// Default Value: pcm_linear
        /// </param>
        /// <param name="outputFormat">
        /// Optional output format for generated audio.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Neuphonic.TtsEventResponse> SpeakWithSseAsync(
            string langCode,
            string text,
            string? apiKey = default,
            string? jwtToken = default,
            double? speed = default,
            double? temperature = default,
            string? requestLangCode = default,
            string? voiceId = default,
            int? samplingRate = default,
            global::Neuphonic.TtsRequestEncoding? encoding = default,
            global::Neuphonic.TtsRequestOutputFormat? outputFormat = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neuphonic.TtsRequest
            {
                Text = text,
                Speed = speed,
                Temperature = temperature,
                LangCode = requestLangCode,
                VoiceId = voiceId,
                SamplingRate = samplingRate,
                Encoding = encoding,
                OutputFormat = outputFormat,
            };

            var __enumerable = SpeakWithSseAsync(
                langCode: langCode,
                apiKey: apiKey,
                jwtToken: jwtToken,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}