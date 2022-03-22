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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ServiceEndpointPolicyDefinition and their operations over its parent. </summary>
    public partial class ServiceEndpointPolicyDefinitionCollection : ArmCollection, IEnumerable<ServiceEndpointPolicyDefinition>, IAsyncEnumerable<ServiceEndpointPolicyDefinition>
    {
        private readonly ClientDiagnostics _serviceEndpointPolicyDefinitionClientDiagnostics;
        private readonly ServiceEndpointPolicyDefinitionsRestOperations _serviceEndpointPolicyDefinitionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceEndpointPolicyDefinitionCollection"/> class for mocking. </summary>
        protected ServiceEndpointPolicyDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceEndpointPolicyDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceEndpointPolicyDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceEndpointPolicyDefinitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ServiceEndpointPolicyDefinition.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceEndpointPolicyDefinition.ResourceType, out string serviceEndpointPolicyDefinitionApiVersion);
            _serviceEndpointPolicyDefinitionRestClient = new ServiceEndpointPolicyDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceEndpointPolicyDefinitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceEndpointPolicy.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceEndpointPolicy.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a service endpoint policy definition in the specified service endpoint policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> or <paramref name="serviceEndpointPolicyDefinitions"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceEndpointPolicyDefinition>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinitionData serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));
            Argument.AssertNotNull(serviceEndpointPolicyDefinitions, nameof(serviceEndpointPolicyDefinitions));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyDefinitionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ServiceEndpointPolicyDefinition>(new ServiceEndpointPolicyDefinitionOperationSource(Client), _serviceEndpointPolicyDefinitionClientDiagnostics, Pipeline, _serviceEndpointPolicyDefinitionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a service endpoint policy definition in the specified service endpoint policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> or <paramref name="serviceEndpointPolicyDefinitions"/> is null. </exception>
        public virtual ArmOperation<ServiceEndpointPolicyDefinition> CreateOrUpdate(WaitUntil waitUntil, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinitionData serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));
            Argument.AssertNotNull(serviceEndpointPolicyDefinitions, nameof(serviceEndpointPolicyDefinitions));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyDefinitionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions, cancellationToken);
                var operation = new NetworkArmOperation<ServiceEndpointPolicyDefinition>(new ServiceEndpointPolicyDefinitionOperationSource(Client), _serviceEndpointPolicyDefinitionClientDiagnostics, Pipeline, _serviceEndpointPolicyDefinitionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the specified service endpoint policy definitions from service endpoint policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_Get
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<ServiceEndpointPolicyDefinition>> GetAsync(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyDefinitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified service endpoint policy definitions from service endpoint policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_Get
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual Response<ServiceEndpointPolicyDefinition> Get(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyDefinitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all service endpoint policy definitions in a service end point policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions
        /// Operation Id: ServiceEndpointPolicyDefinitions_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceEndpointPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceEndpointPolicyDefinition> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceEndpointPolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceEndpointPolicyDefinitionRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceEndpointPolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceEndpointPolicyDefinitionRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all service endpoint policy definitions in a service end point policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions
        /// Operation Id: ServiceEndpointPolicyDefinitions_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceEndpointPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceEndpointPolicyDefinition> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceEndpointPolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceEndpointPolicyDefinitionRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceEndpointPolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceEndpointPolicyDefinitionRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicyDefinition(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_Get
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_Get
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_Get
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<ServiceEndpointPolicyDefinition>> GetIfExistsAsync(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyDefinitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServiceEndpointPolicyDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}/serviceEndpointPolicyDefinitions/{serviceEndpointPolicyDefinitionName}
        /// Operation Id: ServiceEndpointPolicyDefinitions_Get
        /// </summary>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public virtual Response<ServiceEndpointPolicyDefinition> GetIfExists(string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyDefinitionName, nameof(serviceEndpointPolicyDefinitionName));

            using var scope = _serviceEndpointPolicyDefinitionClientDiagnostics.CreateScope("ServiceEndpointPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyDefinitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceEndpointPolicyDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServiceEndpointPolicyDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceEndpointPolicyDefinition> IEnumerable<ServiceEndpointPolicyDefinition>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceEndpointPolicyDefinition> IAsyncEnumerable<ServiceEndpointPolicyDefinition>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
