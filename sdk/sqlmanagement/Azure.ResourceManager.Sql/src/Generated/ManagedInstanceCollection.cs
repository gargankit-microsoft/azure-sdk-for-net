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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstance and their operations over its parent. </summary>
    public partial class ManagedInstanceCollection : ArmCollection, IEnumerable<ManagedInstance>, IAsyncEnumerable<ManagedInstance>
    {
        private readonly ClientDiagnostics _managedInstanceClientDiagnostics;
        private readonly ManagedInstancesRestOperations _managedInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceCollection"/> class for mocking. </summary>
        protected ManagedInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstance.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstance.ResourceType, out string managedInstanceApiVersion);
            _managedInstanceRestClient = new ManagedInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested managed instance resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstance>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedInstanceName, ManagedInstanceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstance>(new ManagedInstanceOperationSource(Client), _managedInstanceClientDiagnostics, Pipeline, _managedInstanceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested managed instance resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ManagedInstance> CreateOrUpdate(WaitUntil waitUntil, string managedInstanceName, ManagedInstanceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstance>(new ManagedInstanceOperationSource(Client), _managedInstanceClientDiagnostics, Pipeline, _managedInstanceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_Get
        /// </summary>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstance>> GetAsync(string managedInstanceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_Get
        /// </summary>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> is null. </exception>
        public virtual Response<ManagedInstance> Get(string managedInstanceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of managed instances in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances
        /// Operation Id: ManagedInstances_ListByResourceGroup
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstance> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of managed instances in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances
        /// Operation Id: ManagedInstances_ListByResourceGroup
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstance> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_Get
        /// </summary>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedInstanceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(managedInstanceName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_Get
        /// </summary>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedInstanceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(managedInstanceName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_Get
        /// </summary>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstance>> GetIfExistsAsync(string managedInstanceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstance>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// Operation Id: ManagedInstances_Get
        /// </summary>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceName"/> is null. </exception>
        public virtual Response<ManagedInstance> GetIfExists(string managedInstanceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));

            using var scope = _managedInstanceClientDiagnostics.CreateScope("ManagedInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, managedInstanceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstance>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstance> IEnumerable<ManagedInstance>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstance> IAsyncEnumerable<ManagedInstance>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
