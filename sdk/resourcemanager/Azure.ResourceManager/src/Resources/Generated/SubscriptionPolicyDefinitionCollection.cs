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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionPolicyDefinitionResource" /> and their operations.
    /// Each <see cref="SubscriptionPolicyDefinitionResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionPolicyDefinitionCollection" /> instance call the GetSubscriptionPolicyDefinitions method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionPolicyDefinitionCollection : ArmCollection, IEnumerable<SubscriptionPolicyDefinitionResource>, IAsyncEnumerable<SubscriptionPolicyDefinitionResource>
    {
        private readonly ClientDiagnostics _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _subscriptionPolicyDefinitionPolicyDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicyDefinitionCollection"/> class for mocking. </summary>
        protected SubscriptionPolicyDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicyDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionPolicyDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", SubscriptionPolicyDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionPolicyDefinitionResource.ResourceType, out string subscriptionPolicyDefinitionPolicyDefinitionsApiVersion);
            _subscriptionPolicyDefinitionPolicyDefinitionsRestClient = new PolicyDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionPolicyDefinitionPolicyDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation creates or updates a policy definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="data"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionPolicyDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyDefinitionName, PolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, policyDefinitionName, data, cancellationToken).ConfigureAwait(false);
                var uri = _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, policyDefinitionName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ResourcesArmOperation<SubscriptionPolicyDefinitionResource>(Response.FromValue(new SubscriptionPolicyDefinitionResource(Client, response), response.GetRawResponse()), operationId);
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
        /// This operation creates or updates a policy definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="data"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionPolicyDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string policyDefinitionName, PolicyDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateOrUpdate(Id.SubscriptionId, policyDefinitionName, data, cancellationToken);
                var uri = _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, policyDefinitionName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ResourcesArmOperation<SubscriptionPolicyDefinitionResource>(Response.FromValue(new SubscriptionPolicyDefinitionResource(Client, response), response.GetRawResponse()), operationId);
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
        /// This operation retrieves the policy definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionPolicyDefinitionResource>> GetAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.GetAsync(Id.SubscriptionId, policyDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<SubscriptionPolicyDefinitionResource> Get(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.Get(Id.SubscriptionId, policyDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicyDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a list of all the policy definitions in a given subscription that match the optional given $filter. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, the unfiltered list includes all policy definitions associated with the subscription, including those that apply directly or from management groups that contain the given subscription. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given subscription. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionPolicyDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionPolicyDefinitionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateListRequest(Id.SubscriptionId, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SubscriptionPolicyDefinitionResource(Client, PolicyDefinitionData.DeserializePolicyDefinitionData(e)), _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics, Pipeline, "SubscriptionPolicyDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This operation retrieves a list of all the policy definitions in a given subscription that match the optional given $filter. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, the unfiltered list includes all policy definitions associated with the subscription, including those that apply directly or from management groups that contain the given subscription. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given subscription. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: 'atExactScope()', 'policyType -eq {value}' or 'category eq '{value}''. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter='policyType -eq {value}' is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter='category -eq {value}' is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionPolicyDefinitionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionPolicyDefinitionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateListRequest(Id.SubscriptionId, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SubscriptionPolicyDefinitionResource(Client, PolicyDefinitionData.DeserializePolicyDefinitionData(e)), _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics, Pipeline, "SubscriptionPolicyDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.GetAsync(Id.SubscriptionId, policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyDefinitionName, nameof(policyDefinitionName));

            using var scope = _subscriptionPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionPolicyDefinitionPolicyDefinitionsRestClient.Get(Id.SubscriptionId, policyDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionPolicyDefinitionResource> IEnumerable<SubscriptionPolicyDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionPolicyDefinitionResource> IAsyncEnumerable<SubscriptionPolicyDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
