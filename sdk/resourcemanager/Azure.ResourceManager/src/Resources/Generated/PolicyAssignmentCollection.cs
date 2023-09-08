// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="PolicyAssignmentResource" /> and their operations.
    /// Each <see cref="PolicyAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="PolicyAssignmentCollection" /> instance call the GetPolicyAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class PolicyAssignmentCollection : ArmCollection, IEnumerable<PolicyAssignmentResource>, IAsyncEnumerable<PolicyAssignmentResource>
    {
        private readonly ClientDiagnostics _policyAssignmentClientDiagnostics;
        private readonly PolicyAssignmentsRestOperations _policyAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyAssignmentCollection"/> class for mocking. </summary>
        protected PolicyAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PolicyAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", PolicyAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PolicyAssignmentResource.ResourceType, out string policyAssignmentApiVersion);
            _policyAssignmentRestClient = new PolicyAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyAssignmentApiVersion);
        }

        /// <summary>
        ///  This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="data"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyAssignmentName, PolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyAssignmentName, nameof(policyAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policyAssignmentRestClient.CreateAsync(Id, policyAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var uri = _policyAssignmentRestClient.CreateCreateRequestUri(Id, policyAssignmentName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ResourcesArmOperation<PolicyAssignmentResource>(Response.FromValue(new PolicyAssignmentResource(Client, response), response.GetRawResponse()), operationId);
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
        ///  This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="data"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicyAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string policyAssignmentName, PolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyAssignmentName, nameof(policyAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policyAssignmentRestClient.Create(Id, policyAssignmentName, data, cancellationToken);
                var uri = _policyAssignmentRestClient.CreateCreateRequestUri(Id, policyAssignmentName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ResourcesArmOperation<PolicyAssignmentResource>(Response.FromValue(new PolicyAssignmentResource(Client, response), response.GetRawResponse()), operationId);
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
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        public virtual async Task<Response<PolicyAssignmentResource>> GetAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyAssignmentName, nameof(policyAssignmentName));

            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyAssignmentRestClient.GetAsync(Id, policyAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        public virtual Response<PolicyAssignmentResource> Get(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyAssignmentName, nameof(policyAssignmentName));

            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _policyAssignmentRestClient.Get(Id, policyAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the list of all policy assignments associated with the given resource group in the given subscription that match the optional given $filter. Valid values for $filter are: 'atScope()', 'atExactScope()' or 'policyDefinitionId eq '{value}''. If $filter is not provided, the unfiltered list includes all policy assignments associated with the resource group, including those that apply directly or apply from containing scopes, as well as any applied to resources contained within the resource group. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the resource group, which is everything in the unfiltered list except those applied to resources contained within the resource group. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the resource group. If $filter=policyDefinitionId eq '{value}' is provided, the returned list includes all policy assignments of the policy definition whose id is {value} that apply to the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_ListForResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_ListForResource</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_ListForManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atScope()', 'atExactScope()' or 'policyDefinitionId eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atScope() is provided, the returned list only includes all policy assignments that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the given scope. If $filter=policyDefinitionId eq '{value}' is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyAssignmentResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == ManagementGroupResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListForManagementGroupRequest(Id.Name, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListForManagementGroupNextPageRequest(nextLink, Id.Name, filter, top);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListRequest(Id.SubscriptionId, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter, top);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListForResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListForResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, top);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
        }

        /// <summary>
        /// This operation retrieves the list of all policy assignments associated with the given resource group in the given subscription that match the optional given $filter. Valid values for $filter are: 'atScope()', 'atExactScope()' or 'policyDefinitionId eq '{value}''. If $filter is not provided, the unfiltered list includes all policy assignments associated with the resource group, including those that apply directly or apply from containing scopes, as well as any applied to resources contained within the resource group. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the resource group, which is everything in the unfiltered list except those applied to resources contained within the resource group. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the resource group. If $filter=policyDefinitionId eq '{value}' is provided, the returned list includes all policy assignments of the policy definition whose id is {value} that apply to the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_ListForResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_ListForResource</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_ListForManagementGroup</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atScope()', 'atExactScope()' or 'policyDefinitionId eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atScope() is provided, the returned list only includes all policy assignments that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the given scope. If $filter=policyDefinitionId eq '{value}' is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyAssignmentResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == ManagementGroupResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListForManagementGroupRequest(Id.Name, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListForManagementGroupNextPageRequest(nextLink, Id.Name, filter, top);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListRequest(Id.SubscriptionId, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter, top);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _policyAssignmentRestClient.CreateListForResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, top);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyAssignmentRestClient.CreateListForResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, top);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PolicyAssignmentResource(Client, PolicyAssignmentData.DeserializePolicyAssignmentData(e)), _policyAssignmentClientDiagnostics, Pipeline, "PolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyAssignmentName, nameof(policyAssignmentName));

            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _policyAssignmentRestClient.GetAsync(Id, policyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyAssignmentName, nameof(policyAssignmentName));

            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _policyAssignmentRestClient.Get(Id, policyAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PolicyAssignmentResource> IEnumerable<PolicyAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PolicyAssignmentResource> IAsyncEnumerable<PolicyAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
