// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="ChaosTargetResource"/> and their operations.
    /// Each <see cref="ChaosTargetResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ChaosTargetCollection"/> instance call the GetChaosTargets method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ChaosTargetCollection : ArmCollection, IEnumerable<ChaosTargetResource>, IAsyncEnumerable<ChaosTargetResource>
    {
        private readonly ClientDiagnostics _chaosTargetTargetsClientDiagnostics;
        private readonly TargetsRestOperations _chaosTargetTargetsRestClient;
        private readonly string _parentProviderNamespace;
        private readonly string _parentResourceType;
        private readonly string _parentResourceName;

        /// <summary> Initializes a new instance of the <see cref="ChaosTargetCollection"/> class for mocking. </summary>
        protected ChaosTargetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosTargetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="parentProviderNamespace"> String that represents a resource provider namespace. </param>
        /// <param name="parentResourceType"> String that represents a resource type. </param>
        /// <param name="parentResourceName"> String that represents a resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/> or <paramref name="parentResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/> or <paramref name="parentResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ChaosTargetCollection(ArmClient client, ResourceIdentifier id, string parentProviderNamespace, string parentResourceType, string parentResourceName) : base(client, id)
        {
            _parentProviderNamespace = parentProviderNamespace;
            _parentResourceType = parentResourceType;
            _parentResourceName = parentResourceName;
            _chaosTargetTargetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ChaosTargetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ChaosTargetResource.ResourceType, out string chaosTargetTargetsApiVersion);
            _chaosTargetTargetsRestClient = new TargetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, chaosTargetTargetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="data"> Target resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ChaosTargetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string targetName, ChaosTargetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _chaosTargetTargetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ChaosArmOperation<ChaosTargetResource>(Response.FromValue(new ChaosTargetResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="data"> Target resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ChaosTargetResource> CreateOrUpdate(WaitUntil waitUntil, string targetName, ChaosTargetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _chaosTargetTargetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, data, cancellationToken);
                var operation = new ChaosArmOperation<ChaosTargetResource>(Response.FromValue(new ChaosTargetResource(Client, response), response.GetRawResponse()));
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
        /// Get a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> is null. </exception>
        public virtual async Task<Response<ChaosTargetResource>> GetAsync(string targetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.Get");
            scope.Start();
            try
            {
                var response = await _chaosTargetTargetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ChaosTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> is null. </exception>
        public virtual Response<ChaosTargetResource> Get(string targetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.Get");
            scope.Start();
            try
            {
                var response = _chaosTargetTargetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ChaosTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Target resources that extend a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ChaosTargetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ChaosTargetResource> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosTargetTargetsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosTargetTargetsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ChaosTargetResource(Client, ChaosTargetData.DeserializeChaosTargetData(e)), _chaosTargetTargetsClientDiagnostics, Pipeline, "ChaosTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Target resources that extend a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ChaosTargetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ChaosTargetResource> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosTargetTargetsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosTargetTargetsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ChaosTargetResource(Client, ChaosTargetData.DeserializeChaosTargetData(e)), _chaosTargetTargetsClientDiagnostics, Pipeline, "ChaosTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string targetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _chaosTargetTargetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> is null. </exception>
        public virtual Response<bool> Exists(string targetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = _chaosTargetTargetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> is null. </exception>
        public virtual async Task<NullableResponse<ChaosTargetResource>> GetIfExistsAsync(string targetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _chaosTargetTargetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ChaosTargetResource>(response.GetRawResponse());
                return Response.FromValue(new ChaosTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/> is null. </exception>
        public virtual NullableResponse<ChaosTargetResource> GetIfExists(string targetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetName, nameof(targetName));

            using var scope = _chaosTargetTargetsClientDiagnostics.CreateScope("ChaosTargetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _chaosTargetTargetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _parentProviderNamespace, _parentResourceType, _parentResourceName, targetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ChaosTargetResource>(response.GetRawResponse());
                return Response.FromValue(new ChaosTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ChaosTargetResource> IEnumerable<ChaosTargetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ChaosTargetResource> IAsyncEnumerable<ChaosTargetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
