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

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceFabricManagedApplicationTypeVersionResource" /> and their operations.
    /// Each <see cref="ServiceFabricManagedApplicationTypeVersionResource" /> in the collection will belong to the same instance of <see cref="ServiceFabricManagedApplicationTypeResource" />.
    /// To get a <see cref="ServiceFabricManagedApplicationTypeVersionCollection" /> instance call the GetServiceFabricManagedApplicationTypeVersions method from an instance of <see cref="ServiceFabricManagedApplicationTypeResource" />.
    /// </summary>
    public partial class ServiceFabricManagedApplicationTypeVersionCollection : ArmCollection, IEnumerable<ServiceFabricManagedApplicationTypeVersionResource>, IAsyncEnumerable<ServiceFabricManagedApplicationTypeVersionResource>
    {
        private readonly ClientDiagnostics _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics;
        private readonly ApplicationTypeVersionsRestOperations _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricManagedApplicationTypeVersionCollection"/> class for mocking. </summary>
        protected ServiceFabricManagedApplicationTypeVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricManagedApplicationTypeVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceFabricManagedApplicationTypeVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabricManagedClusters", ServiceFabricManagedApplicationTypeVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceFabricManagedApplicationTypeVersionResource.ResourceType, out string serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsApiVersion);
            _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient = new ApplicationTypeVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceFabricManagedApplicationTypeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceFabricManagedApplicationTypeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Service Fabric managed application type version resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> The application type version. </param>
        /// <param name="data"> The application type version resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceFabricManagedApplicationTypeVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, ServiceFabricManagedApplicationTypeVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricManagedClustersArmOperation<ServiceFabricManagedApplicationTypeVersionResource>(new ServiceFabricManagedApplicationTypeVersionOperationSource(Client), _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a Service Fabric managed application type version resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> The application type version. </param>
        /// <param name="data"> The application type version resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceFabricManagedApplicationTypeVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, ServiceFabricManagedApplicationTypeVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new ServiceFabricManagedClustersArmOperation<ServiceFabricManagedApplicationTypeVersionResource>(new ServiceFabricManagedApplicationTypeVersionOperationSource(Client), _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Service Fabric managed application type version resource created or in the process of being created in the Service Fabric managed application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricManagedApplicationTypeVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedApplicationTypeVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric managed application type version resource created or in the process of being created in the Service Fabric managed application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<ServiceFabricManagedApplicationTypeVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedApplicationTypeVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all application type version resources created or in the process of being created in the Service Fabric managed application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_ListByApplicationTypes</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricManagedApplicationTypeVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricManagedApplicationTypeVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateListByApplicationTypesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateListByApplicationTypesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceFabricManagedApplicationTypeVersionResource(Client, ServiceFabricManagedApplicationTypeVersionData.DeserializeServiceFabricManagedApplicationTypeVersionData(e)), _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, "ServiceFabricManagedApplicationTypeVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all application type version resources created or in the process of being created in the Service Fabric managed application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_ListByApplicationTypes</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricManagedApplicationTypeVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricManagedApplicationTypeVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateListByApplicationTypesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.CreateListByApplicationTypesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceFabricManagedApplicationTypeVersionResource(Client, ServiceFabricManagedApplicationTypeVersionData.DeserializeServiceFabricManagedApplicationTypeVersionData(e)), _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, "ServiceFabricManagedApplicationTypeVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedApplicationTypeVersionApplicationTypeVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceFabricManagedApplicationTypeVersionResource> IEnumerable<ServiceFabricManagedApplicationTypeVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceFabricManagedApplicationTypeVersionResource> IAsyncEnumerable<ServiceFabricManagedApplicationTypeVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
