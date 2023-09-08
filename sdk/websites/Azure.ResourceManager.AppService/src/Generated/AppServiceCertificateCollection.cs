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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppServiceCertificateResource" /> and their operations.
    /// Each <see cref="AppServiceCertificateResource" /> in the collection will belong to the same instance of <see cref="AppServiceCertificateOrderResource" />.
    /// To get an <see cref="AppServiceCertificateCollection" /> instance call the GetAppServiceCertificates method from an instance of <see cref="AppServiceCertificateOrderResource" />.
    /// </summary>
    public partial class AppServiceCertificateCollection : ArmCollection, IEnumerable<AppServiceCertificateResource>, IAsyncEnumerable<AppServiceCertificateResource>
    {
        private readonly ClientDiagnostics _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics;
        private readonly AppServiceCertificateOrdersRestOperations _appServiceCertificateAppServiceCertificateOrdersRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateCollection"/> class for mocking. </summary>
        protected AppServiceCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppServiceCertificateResource.ResourceType, out string appServiceCertificateAppServiceCertificateOrdersApiVersion);
            _appServiceCertificateAppServiceCertificateOrdersRestClient = new AppServiceCertificateOrdersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServiceCertificateAppServiceCertificateOrdersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceCertificateOrderResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceCertificateOrderResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates or updates a certificate and associates with key vault secret.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_CreateOrUpdateCertificate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="data"> Key vault certificate resource Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, AppServiceCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServiceCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateOrUpdateCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServiceCertificateResource>(new AppServiceCertificateOperationSource(Client), _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics, Pipeline, _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateCreateOrUpdateCertificateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates or updates a certificate and associates with key vault secret.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_CreateOrUpdateCertificate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="data"> Key vault certificate resource Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServiceCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string name, AppServiceCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServiceCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateOrUpdateCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppServiceCertificateResource>(new AppServiceCertificateOperationSource(Client), _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics, Pipeline, _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateCreateOrUpdateCertificateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the certificate associated with a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_GetCertificate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AppServiceCertificateResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServiceCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateAppServiceCertificateOrdersRestClient.GetCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the certificate associated with a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_GetCertificate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppServiceCertificateResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServiceCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceCertificateAppServiceCertificateOrdersRestClient.GetCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List all certificates associated with a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_ListCertificates</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateListCertificatesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateListCertificatesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppServiceCertificateResource(Client, AppServiceCertificateData.DeserializeAppServiceCertificateData(e)), _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics, Pipeline, "AppServiceCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List all certificates associated with a certificate order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_ListCertificates</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateListCertificatesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceCertificateAppServiceCertificateOrdersRestClient.CreateListCertificatesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppServiceCertificateResource(Client, AppServiceCertificateData.DeserializeAppServiceCertificateData(e)), _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics, Pipeline, "AppServiceCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_GetCertificate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServiceCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateAppServiceCertificateOrdersRestClient.GetCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceCertificateOrders_GetCertificate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServiceCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _appServiceCertificateAppServiceCertificateOrdersRestClient.GetCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceCertificateResource> IEnumerable<AppServiceCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceCertificateResource> IAsyncEnumerable<AppServiceCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
