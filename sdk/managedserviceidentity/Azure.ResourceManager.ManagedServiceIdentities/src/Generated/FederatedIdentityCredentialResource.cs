// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary>
    /// A Class representing a FederatedIdentityCredential along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="FederatedIdentityCredentialResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetFederatedIdentityCredentialResource method.
    /// Otherwise you can get one from its parent resource <see cref="UserAssignedIdentityResource" /> using the GetFederatedIdentityCredential method.
    /// </summary>
    public partial class FederatedIdentityCredentialResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FederatedIdentityCredentialResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="federatedIdentityCredentialResourceName"> The federatedIdentityCredentialResourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string federatedIdentityCredentialResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _federatedIdentityCredentialClientDiagnostics;
        private readonly FederatedIdentityCredentialsRestOperations _federatedIdentityCredentialRestClient;
        private readonly FederatedIdentityCredentialData _data;

        /// <summary> Initializes a new instance of the <see cref="FederatedIdentityCredentialResource"/> class for mocking. </summary>
        protected FederatedIdentityCredentialResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FederatedIdentityCredentialResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FederatedIdentityCredentialResource(ArmClient client, FederatedIdentityCredentialData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FederatedIdentityCredentialResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FederatedIdentityCredentialResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _federatedIdentityCredentialClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServiceIdentities", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string federatedIdentityCredentialApiVersion);
            _federatedIdentityCredentialRestClient = new FederatedIdentityCredentialsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, federatedIdentityCredentialApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagedIdentity/userAssignedIdentities/federatedIdentityCredentials";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FederatedIdentityCredentialData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the federated identity credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FederatedIdentityCredentialResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialResource.Get");
            scope.Start();
            try
            {
                var response = await _federatedIdentityCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FederatedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the federated identity credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FederatedIdentityCredentialResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialResource.Get");
            scope.Start();
            try
            {
                var response = _federatedIdentityCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FederatedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the federated identity credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialResource.Delete");
            scope.Start();
            try
            {
                var response = await _federatedIdentityCredentialRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServiceIdentitiesArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the federated identity credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialResource.Delete");
            scope.Start();
            try
            {
                var response = _federatedIdentityCredentialRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ManagedServiceIdentitiesArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a federated identity credential under the specified user assigned identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters to create or update the federated identity credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FederatedIdentityCredentialResource>> UpdateAsync(WaitUntil waitUntil, FederatedIdentityCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialResource.Update");
            scope.Start();
            try
            {
                var response = await _federatedIdentityCredentialRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServiceIdentitiesArmOperation<FederatedIdentityCredentialResource>(Response.FromValue(new FederatedIdentityCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a federated identity credential under the specified user assigned identity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{resourceName}/federatedIdentityCredentials/{federatedIdentityCredentialResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FederatedIdentityCredentials_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters to create or update the federated identity credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FederatedIdentityCredentialResource> Update(WaitUntil waitUntil, FederatedIdentityCredentialData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _federatedIdentityCredentialClientDiagnostics.CreateScope("FederatedIdentityCredentialResource.Update");
            scope.Start();
            try
            {
                var response = _federatedIdentityCredentialRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ManagedServiceIdentitiesArmOperation<FederatedIdentityCredentialResource>(Response.FromValue(new FederatedIdentityCredentialResource(Client, response), response.GetRawResponse()));
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
    }
}
