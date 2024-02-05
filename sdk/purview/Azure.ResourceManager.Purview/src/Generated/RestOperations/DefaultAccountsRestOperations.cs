// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Purview.Models;

namespace Azure.ResourceManager.Purview
{
    internal partial class DefaultAccountsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DefaultAccountsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DefaultAccountsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-05-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Purview/getDefaultAccount", false);
            uri.AppendQuery("scopeTenantId", scopeTenantId, true);
            uri.AppendQuery("scopeType", scopeType.ToString(), true);
            if (scope != null)
            {
                uri.AppendQuery("scope", scope, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the default account for the scope. </summary>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DefaultPurviewAccountPayload>> GetAsync(Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(scopeTenantId, scopeType, scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DefaultPurviewAccountPayload value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DefaultPurviewAccountPayload.DeserializeDefaultPurviewAccountPayload(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the default account for the scope. </summary>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DefaultPurviewAccountPayload> Get(Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(scopeTenantId, scopeType, scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DefaultPurviewAccountPayload value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DefaultPurviewAccountPayload.DeserializeDefaultPurviewAccountPayload(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRemoveRequest(Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Purview/removeDefaultAccount", false);
            uri.AppendQuery("scopeTenantId", scopeTenantId, true);
            uri.AppendQuery("scopeType", scopeType.ToString(), true);
            if (scope != null)
            {
                uri.AppendQuery("scope", scope, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Removes the default account from the scope. </summary>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> RemoveAsync(Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateRemoveRequest(scopeTenantId, scopeType, scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Removes the default account from the scope. </summary>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Remove(Guid scopeTenantId, PurviewAccountScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateRemoveRequest(scopeTenantId, scopeType, scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSetRequest(DefaultPurviewAccountPayload defaultAccountPayload)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Purview/setDefaultAccount", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(defaultAccountPayload);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Sets the default account for the scope. </summary>
        /// <param name="defaultAccountPayload"> The payload containing the default account information and the scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultAccountPayload"/> is null. </exception>
        public async Task<Response<DefaultPurviewAccountPayload>> SetAsync(DefaultPurviewAccountPayload defaultAccountPayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(defaultAccountPayload, nameof(defaultAccountPayload));

            using var message = CreateSetRequest(defaultAccountPayload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DefaultPurviewAccountPayload value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DefaultPurviewAccountPayload.DeserializeDefaultPurviewAccountPayload(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Sets the default account for the scope. </summary>
        /// <param name="defaultAccountPayload"> The payload containing the default account information and the scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultAccountPayload"/> is null. </exception>
        public Response<DefaultPurviewAccountPayload> Set(DefaultPurviewAccountPayload defaultAccountPayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(defaultAccountPayload, nameof(defaultAccountPayload));

            using var message = CreateSetRequest(defaultAccountPayload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DefaultPurviewAccountPayload value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DefaultPurviewAccountPayload.DeserializeDefaultPurviewAccountPayload(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
