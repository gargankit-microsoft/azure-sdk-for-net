// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkAnalytics;

namespace Azure.ResourceManager.NetworkAnalytics.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableNetworkAnalyticsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _dataProductClientDiagnostics;
        private DataProductsRestOperations _dataProductRestClient;
        private ClientDiagnostics _dataProductsCatalogClientDiagnostics;
        private DataProductsCatalogsRestOperations _dataProductsCatalogRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableNetworkAnalyticsSubscriptionResource"/> class for mocking. </summary>
        protected MockableNetworkAnalyticsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNetworkAnalyticsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNetworkAnalyticsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataProductClientDiagnostics => _dataProductClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetworkAnalytics", DataProductResource.ResourceType.Namespace, Diagnostics);
        private DataProductsRestOperations DataProductRestClient => _dataProductRestClient ??= new DataProductsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataProductResource.ResourceType));
        private ClientDiagnostics DataProductsCatalogClientDiagnostics => _dataProductsCatalogClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetworkAnalytics", DataProductsCatalogResource.ResourceType.Namespace, Diagnostics);
        private DataProductsCatalogsRestOperations DataProductsCatalogRestClient => _dataProductsCatalogRestClient ??= new DataProductsCatalogsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataProductsCatalogResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List data products by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProducts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProductResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProductResource> GetDataProductsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataProductRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataProductRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProductResource(Client, DataProductData.DeserializeDataProductData(e)), DataProductClientDiagnostics, Pipeline, "MockableNetworkAnalyticsSubscriptionResource.GetDataProducts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List data products by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProducts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProducts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProductResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProductResource> GetDataProducts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataProductRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataProductRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProductResource(Client, DataProductData.DeserializeDataProductData(e)), DataProductClientDiagnostics, Pipeline, "MockableNetworkAnalyticsSubscriptionResource.GetDataProducts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List data catalog by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProductsCatalogs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProductsCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProductsCatalogResource> GetDataProductsCatalogsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataProductsCatalogRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataProductsCatalogRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProductsCatalogResource(Client, DataProductsCatalogData.DeserializeDataProductsCatalogData(e)), DataProductsCatalogClientDiagnostics, Pipeline, "MockableNetworkAnalyticsSubscriptionResource.GetDataProductsCatalogs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List data catalog by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkAnalytics/dataProductsCatalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProductsCatalogs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProductsCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProductsCatalogResource> GetDataProductsCatalogs(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataProductsCatalogRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataProductsCatalogRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProductsCatalogResource(Client, DataProductsCatalogData.DeserializeDataProductsCatalogData(e)), DataProductsCatalogClientDiagnostics, Pipeline, "MockableNetworkAnalyticsSubscriptionResource.GetDataProductsCatalogs", "value", "nextLink", cancellationToken);
        }
    }
}
