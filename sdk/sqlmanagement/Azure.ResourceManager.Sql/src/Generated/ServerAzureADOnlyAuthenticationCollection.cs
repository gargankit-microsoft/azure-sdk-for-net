// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerAzureADOnlyAuthentication and their operations over its parent. </summary>
    public partial class ServerAzureADOnlyAuthenticationCollection : ArmCollection, IEnumerable<ServerAzureADOnlyAuthentication>, IAsyncEnumerable<ServerAzureADOnlyAuthentication>
    {
        private readonly ClientDiagnostics _serverAzureADOnlyAuthenticationClientDiagnostics;
        private readonly ServerAzureADOnlyAuthenticationsRestOperations _serverAzureADOnlyAuthenticationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerAzureADOnlyAuthenticationCollection"/> class for mocking. </summary>
        protected ServerAzureADOnlyAuthenticationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerAzureADOnlyAuthenticationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerAzureADOnlyAuthenticationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverAzureADOnlyAuthenticationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerAzureADOnlyAuthentication.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerAzureADOnlyAuthentication.ResourceType, out string serverAzureADOnlyAuthenticationApiVersion);
            _serverAzureADOnlyAuthenticationRestClient = new ServerAzureADOnlyAuthenticationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverAzureADOnlyAuthenticationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="parameters"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerAzureADOnlyAuthentication>> CreateOrUpdateAsync(WaitUntil waitUntil, AuthenticationName authenticationName, ServerAzureADOnlyAuthenticationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverAzureADOnlyAuthenticationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerAzureADOnlyAuthentication>(new ServerAzureADOnlyAuthenticationOperationSource(Client), _serverAzureADOnlyAuthenticationClientDiagnostics, Pipeline, _serverAzureADOnlyAuthenticationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="parameters"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServerAzureADOnlyAuthentication> CreateOrUpdate(WaitUntil waitUntil, AuthenticationName authenticationName, ServerAzureADOnlyAuthenticationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverAzureADOnlyAuthenticationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ServerAzureADOnlyAuthentication>(new ServerAzureADOnlyAuthenticationOperationSource(Client), _serverAzureADOnlyAuthenticationClientDiagnostics, Pipeline, _serverAzureADOnlyAuthenticationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Azure Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerAzureADOnlyAuthentication>> GetAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverAzureADOnlyAuthenticationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAzureADOnlyAuthentication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Azure Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAzureADOnlyAuthentication> Get(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = _serverAzureADOnlyAuthenticationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAzureADOnlyAuthentication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server Azure Active Directory only authentications.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications
        /// Operation Id: ServerAzureADOnlyAuthentications_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerAzureADOnlyAuthentication" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerAzureADOnlyAuthentication> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerAzureADOnlyAuthentication>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverAzureADOnlyAuthenticationRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerAzureADOnlyAuthentication>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverAzureADOnlyAuthenticationRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of server Azure Active Directory only authentications.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications
        /// Operation Id: ServerAzureADOnlyAuthentications_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerAzureADOnlyAuthentication" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerAzureADOnlyAuthentication> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerAzureADOnlyAuthentication> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverAzureADOnlyAuthenticationRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerAzureADOnlyAuthentication> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverAzureADOnlyAuthenticationRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authenticationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerAzureADOnlyAuthentication>> GetIfExistsAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverAzureADOnlyAuthenticationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerAzureADOnlyAuthentication>(null, response.GetRawResponse());
                return Response.FromValue(new ServerAzureADOnlyAuthentication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAzureADOnlyAuthentication> GetIfExists(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverAzureADOnlyAuthenticationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerAzureADOnlyAuthentication>(null, response.GetRawResponse());
                return Response.FromValue(new ServerAzureADOnlyAuthentication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerAzureADOnlyAuthentication> IEnumerable<ServerAzureADOnlyAuthentication>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerAzureADOnlyAuthentication> IAsyncEnumerable<ServerAzureADOnlyAuthentication>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
