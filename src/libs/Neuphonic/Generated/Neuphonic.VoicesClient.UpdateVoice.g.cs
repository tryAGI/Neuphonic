
#nullable enable

namespace Neuphonic
{
    public partial class VoicesClient
    {


        private static readonly global::Neuphonic.EndPointSecurityRequirement s_UpdateVoiceSecurityRequirement0 =
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
        private static readonly global::Neuphonic.EndPointSecurityRequirement[] s_UpdateVoiceSecurityRequirements =
            new global::Neuphonic.EndPointSecurityRequirement[]
            {                s_UpdateVoiceSecurityRequirement0,
            };
        partial void PrepareUpdateVoiceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref string? newVoiceName,
            ref string? newVoiceTags,
            global::Neuphonic.UpdateVoiceRequest request);
        partial void PrepareUpdateVoiceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            string? newVoiceName,
            string? newVoiceTags,
            global::Neuphonic.UpdateVoiceRequest request);
        partial void ProcessUpdateVoiceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateVoiceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update cloned voice<br/>
        /// Update a cloned voice's name, tags, or reference audio.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="newVoiceName"></param>
        /// <param name="newVoiceTags"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> UpdateVoiceAsync(
            string voiceId,

            global::Neuphonic.UpdateVoiceRequest request,
            string? newVoiceName = default,
            string? newVoiceTags = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UpdateVoiceAsResponseAsync(
                voiceId: voiceId,

                request: request,
                newVoiceName: newVoiceName,
                newVoiceTags: newVoiceTags,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update cloned voice<br/>
        /// Update a cloned voice's name, tags, or reference audio.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="newVoiceName"></param>
        /// <param name="newVoiceTags"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neuphonic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.VoiceMutationResponse>> UpdateVoiceAsResponseAsync(
            string voiceId,

            global::Neuphonic.UpdateVoiceRequest request,
            string? newVoiceName = default,
            string? newVoiceTags = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateVoiceArguments(
                httpClient: HttpClient,
                voiceId: ref voiceId,
                newVoiceName: ref newVoiceName,
                newVoiceTags: ref newVoiceTags,
                request: request);


            var __authorizations = global::Neuphonic.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdateVoiceSecurityRequirements,
                operationName: "UpdateVoiceAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Neuphonic.PathBuilder(
                                path: $"/voices/{voiceId}",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("new_voice_name", newVoiceName)
                                .AddOptionalParameter("new_voice_tags", newVoiceTags)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Neuphonic.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: new global::System.Net.Http.HttpMethod("PATCH"),
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

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(voiceId ?? string.Empty),
                                name: "\"voice_id\"");

                            if (newVoiceName != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(newVoiceName ?? string.Empty),
                                    name: "\"new_voice_name\"");

                            }
                            if (newVoiceTags != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(newVoiceTags ?? string.Empty),
                                    name: "\"new_voice_tags\"");

                            }
                            if (request.NewVoiceFile != default)
                            {

                                var __contentNewVoiceFile = new global::System.Net.Http.ByteArrayContent(request.NewVoiceFile ?? global::System.Array.Empty<byte>());
                                __contentNewVoiceFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.NewVoiceFilename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.NewVoiceFilename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentNewVoiceFile,
                                    name: "\"new_voice_file\"",
                                    fileName: request.NewVoiceFilename != null ? $"\"{request.NewVoiceFilename}\"" : string.Empty);
                                if (__contentNewVoiceFile.Headers.ContentDisposition != null)
                                {
                                    __contentNewVoiceFile.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Neuphonic.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareUpdateVoiceRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    voiceId: voiceId!,
                    newVoiceName: newVoiceName,
                    newVoiceTags: newVoiceTags,
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
                                operationId: "UpdateVoice",
                                methodName: "UpdateVoiceAsync",
                                pathTemplate: "$\"/voices/{voiceId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Neuphonic.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdateVoice",
                                methodName: "UpdateVoiceAsync",
                                pathTemplate: "$\"/voices/{voiceId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Neuphonic.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Neuphonic.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdateVoice",
                                methodName: "UpdateVoiceAsync",
                                pathTemplate: "$\"/voices/{voiceId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Neuphonic.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessUpdateVoiceResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdateVoice",
                                methodName: "UpdateVoiceAsync",
                                pathTemplate: "$\"/voices/{voiceId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Neuphonic.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neuphonic.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdateVoice",
                                methodName: "UpdateVoiceAsync",
                                pathTemplate: "$\"/voices/{voiceId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation error.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Neuphonic.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Neuphonic.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Neuphonic.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Neuphonic.ApiException<global::Neuphonic.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessUpdateVoiceResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Neuphonic.VoiceMutationResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.VoiceMutationResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Neuphonic.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Neuphonic.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Neuphonic.VoiceMutationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Neuphonic.AutoSDKHttpResponse<global::Neuphonic.VoiceMutationResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Neuphonic.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
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

                                    throw global::Neuphonic.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Update cloned voice<br/>
        /// Update a cloned voice's name, tags, or reference audio.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="newVoiceName"></param>
        /// <param name="newVoiceTags"></param>
        /// <param name="newVoiceFile">
        /// New audio file to use as the voice reference sample.
        /// </param>
        /// <param name="newVoiceFilename">
        /// New audio file to use as the voice reference sample.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neuphonic.VoiceMutationResponse> UpdateVoiceAsync(
            string voiceId,
            string? newVoiceName = default,
            string? newVoiceTags = default,
            byte[]? newVoiceFile = default,
            string? newVoiceFilename = default,
            global::Neuphonic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neuphonic.UpdateVoiceRequest
            {
                NewVoiceFile = newVoiceFile,
                NewVoiceFilename = newVoiceFilename,
            };

            return await UpdateVoiceAsync(
                voiceId: voiceId,
                newVoiceName: newVoiceName,
                newVoiceTags: newVoiceTags,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}