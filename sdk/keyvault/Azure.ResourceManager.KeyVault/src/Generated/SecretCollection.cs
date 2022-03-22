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
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of Secret and their operations over its parent. </summary>
    public partial class SecretCollection : ArmCollection, IEnumerable<Secret>, IAsyncEnumerable<Secret>
    {
        private readonly ClientDiagnostics _secretClientDiagnostics;
        private readonly SecretsRestOperations _secretRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecretCollection"/> class for mocking. </summary>
        protected SecretCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecretCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecretCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _secretClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", Secret.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(Secret.ResourceType, out string secretApiVersion);
            _secretRestClient = new SecretsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, secretApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Vault.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Vault.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a secret in a key vault in the specified subscription.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="secretName"> Name of the secret. </param>
        /// <param name="parameters"> Parameters to create or update the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<Secret>> CreateOrUpdateAsync(WaitUntil waitUntil, string secretName, SecretCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _secretRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new KeyVaultArmOperation<Secret>(Response.FromValue(new Secret(Client, response), response.GetRawResponse()));
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
        /// Create or update a secret in a key vault in the specified subscription.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="secretName"> Name of the secret. </param>
        /// <param name="parameters"> Parameters to create or update the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<Secret> CreateOrUpdate(WaitUntil waitUntil, string secretName, SecretCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _secretRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, parameters, cancellationToken);
                var operation = new KeyVaultArmOperation<Secret>(Response.FromValue(new Secret(Client, response), response.GetRawResponse()));
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
        /// Gets the specified secret.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_Get
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<Response<Secret>> GetAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.Get");
            scope.Start();
            try
            {
                var response = await _secretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Secret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified secret.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_Get
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<Secret> Get(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.Get");
            scope.Start();
            try
            {
                var response = _secretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Secret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List operation gets information about the secrets in a vault.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets
        /// Operation Id: Secrets_List
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Secret" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Secret> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Secret>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _secretRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Secret>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _secretRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// The List operation gets information about the secrets in a vault.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets
        /// Operation Id: Secrets_List
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Secret" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Secret> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Secret> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _secretRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Secret> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _secretRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_Get
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_Get
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<bool> Exists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(secretName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_Get
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<Response<Secret>> GetIfExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _secretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Secret>(null, response.GetRawResponse());
                return Response.FromValue(new Secret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// Operation Id: Secrets_Get
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<Secret> GetIfExists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _secretClientDiagnostics.CreateScope("SecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _secretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Secret>(null, response.GetRawResponse());
                return Response.FromValue(new Secret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Secret> IEnumerable<Secret>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Secret> IAsyncEnumerable<Secret>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
