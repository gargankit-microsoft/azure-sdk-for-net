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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="KpiResourceFormatResource"/> and their operations.
    /// Each <see cref="KpiResourceFormatResource"/> in the collection will belong to the same instance of <see cref="HubResource"/>.
    /// To get a <see cref="KpiResourceFormatCollection"/> instance call the GetKpiResourceFormats method from an instance of <see cref="HubResource"/>.
    /// </summary>
    public partial class KpiResourceFormatCollection : ArmCollection, IEnumerable<KpiResourceFormatResource>, IAsyncEnumerable<KpiResourceFormatResource>
    {
        private readonly ClientDiagnostics _kpiResourceFormatKpiClientDiagnostics;
        private readonly KpiRestOperations _kpiResourceFormatKpiRestClient;

        /// <summary> Initializes a new instance of the <see cref="KpiResourceFormatCollection"/> class for mocking. </summary>
        protected KpiResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KpiResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KpiResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kpiResourceFormatKpiClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", KpiResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KpiResourceFormatResource.ResourceType, out string kpiResourceFormatKpiApiVersion);
            _kpiResourceFormatKpiRestClient = new KpiRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kpiResourceFormatKpiApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a KPI or updates an existing KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="data"> Parameters supplied to the create/update KPI operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KpiResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string kpiName, KpiResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<KpiResourceFormatResource>(new KpiResourceFormatOperationSource(Client), _kpiResourceFormatKpiClientDiagnostics, Pipeline, _kpiResourceFormatKpiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a KPI or updates an existing KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="data"> Parameters supplied to the create/update KPI operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KpiResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string kpiName, KpiResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<KpiResourceFormatResource>(new KpiResourceFormatOperationSource(Client), _kpiResourceFormatKpiClientDiagnostics, Pipeline, _kpiResourceFormatKpiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> is null. </exception>
        public virtual async Task<Response<KpiResourceFormatResource>> GetAsync(string kpiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KpiResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> is null. </exception>
        public virtual Response<KpiResourceFormatResource> Get(string kpiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KpiResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the KPIs in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_ListByHub</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KpiResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KpiResourceFormatResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kpiResourceFormatKpiRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kpiResourceFormatKpiRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new KpiResourceFormatResource(Client, KpiResourceFormatData.DeserializeKpiResourceFormatData(e)), _kpiResourceFormatKpiClientDiagnostics, Pipeline, "KpiResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the KPIs in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_ListByHub</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KpiResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KpiResourceFormatResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kpiResourceFormatKpiRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kpiResourceFormatKpiRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new KpiResourceFormatResource(Client, KpiResourceFormatData.DeserializeKpiResourceFormatData(e)), _kpiResourceFormatKpiClientDiagnostics, Pipeline, "KpiResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string kpiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> is null. </exception>
        public virtual Response<bool> Exists(string kpiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> is null. </exception>
        public virtual async Task<NullableResponse<KpiResourceFormatResource>> GetIfExistsAsync(string kpiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<KpiResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new KpiResourceFormatResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KpiResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="kpiName"> The name of the KPI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="kpiName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="kpiName"/> is null. </exception>
        public virtual NullableResponse<KpiResourceFormatResource> GetIfExists(string kpiName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(kpiName, nameof(kpiName));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, kpiName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<KpiResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new KpiResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KpiResourceFormatResource> IEnumerable<KpiResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KpiResourceFormatResource> IAsyncEnumerable<KpiResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
