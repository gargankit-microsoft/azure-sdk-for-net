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
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagementGroupPolicySetDefinitionResource" /> and their operations.
    /// Each <see cref="ManagementGroupPolicySetDefinitionResource" /> in the collection will belong to the same instance of <see cref="ManagementGroupResource" />.
    /// To get a <see cref="ManagementGroupPolicySetDefinitionCollection" /> instance call the GetManagementGroupPolicySetDefinitions method from an instance of <see cref="ManagementGroupResource" />.
    /// </summary>
    public partial class ManagementGroupPolicySetDefinitionCollection : ArmCollection, IEnumerable<ManagementGroupPolicySetDefinitionResource>, IAsyncEnumerable<ManagementGroupPolicySetDefinitionResource>
    {
        private readonly ClientDiagnostics _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicySetDefinitionCollection"/> class for mocking. </summary>
        protected ManagementGroupPolicySetDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicySetDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagementGroupPolicySetDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ManagementGroupPolicySetDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagementGroupPolicySetDefinitionResource.ResourceType, out string managementGroupPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managementGroupPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation creates or updates a policy set definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_CreateOrUpdateAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to create. </param>
        /// <param name="data"> The policy set definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagementGroupPolicySetDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policySetDefinitionName, PolicySetDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicySetDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateOrUpdateAtManagementGroupAsync(Id.Name, policySetDefinitionName, data, cancellationToken).ConfigureAwait(false);
                var uri = _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateCreateOrUpdateAtManagementGroupRequestUri(Id.Name, policySetDefinitionName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ResourcesArmOperation<ManagementGroupPolicySetDefinitionResource>(Response.FromValue(new ManagementGroupPolicySetDefinitionResource(Client, response), response.GetRawResponse()), operationId);
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
        /// This operation creates or updates a policy set definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_CreateOrUpdateAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to create. </param>
        /// <param name="data"> The policy set definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagementGroupPolicySetDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string policySetDefinitionName, PolicySetDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicySetDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateOrUpdateAtManagementGroup(Id.Name, policySetDefinitionName, data, cancellationToken);
                var uri = _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateCreateOrUpdateAtManagementGroupRequestUri(Id.Name, policySetDefinitionName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ResourcesArmOperation<ManagementGroupPolicySetDefinitionResource>(Response.FromValue(new ManagementGroupPolicySetDefinitionResource(Client, response), response.GetRawResponse()), operationId);
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
        /// This operation retrieves the policy set definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual async Task<Response<ManagementGroupPolicySetDefinitionResource>> GetAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicySetDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policySetDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy set definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<ManagementGroupPolicySetDefinitionResource> Get(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicySetDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.GetAtManagementGroup(Id.Name, policySetDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a list of all the policy set definitions in a given management group that match the optional given $filter. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, the unfiltered list includes all policy set definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given management group. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn and Custom. If $filter='category -eq {value}' is provided, the returned list only includes all policy set definitions whose category match the {value}.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_ListByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementGroupPolicySetDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementGroupPolicySetDefinitionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateListByManagementGroupRequest(Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateListByManagementGroupNextPageRequest(nextLink, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagementGroupPolicySetDefinitionResource(Client, PolicySetDefinitionData.DeserializePolicySetDefinitionData(e)), _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics, Pipeline, "ManagementGroupPolicySetDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This operation retrieves a list of all the policy set definitions in a given management group that match the optional given $filter. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, the unfiltered list includes all policy set definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given management group. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn and Custom. If $filter='category -eq {value}' is provided, the returned list only includes all policy set definitions whose category match the {value}.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_ListByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementGroupPolicySetDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementGroupPolicySetDefinitionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateListByManagementGroupRequest(Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.CreateListByManagementGroupNextPageRequest(nextLink, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagementGroupPolicySetDefinitionResource(Client, PolicySetDefinitionData.DeserializePolicySetDefinitionData(e)), _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics, Pipeline, "ManagementGroupPolicySetDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicySetDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policySetDefinitionName, nameof(policySetDefinitionName));

            using var scope = _managementGroupPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicySetDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _managementGroupPolicySetDefinitionPolicySetDefinitionsRestClient.GetAtManagementGroup(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagementGroupPolicySetDefinitionResource> IEnumerable<ManagementGroupPolicySetDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementGroupPolicySetDefinitionResource> IAsyncEnumerable<ManagementGroupPolicySetDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
