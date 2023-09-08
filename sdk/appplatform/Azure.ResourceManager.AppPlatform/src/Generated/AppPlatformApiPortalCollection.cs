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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformApiPortalResource" /> and their operations.
    /// Each <see cref="AppPlatformApiPortalResource" /> in the collection will belong to the same instance of <see cref="AppPlatformServiceResource" />.
    /// To get an <see cref="AppPlatformApiPortalCollection" /> instance call the GetAppPlatformApiPortals method from an instance of <see cref="AppPlatformServiceResource" />.
    /// </summary>
    public partial class AppPlatformApiPortalCollection : ArmCollection, IEnumerable<AppPlatformApiPortalResource>, IAsyncEnumerable<AppPlatformApiPortalResource>
    {
        private readonly ClientDiagnostics _appPlatformApiPortalApiPortalsClientDiagnostics;
        private readonly ApiPortalsRestOperations _appPlatformApiPortalApiPortalsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformApiPortalCollection"/> class for mocking. </summary>
        protected AppPlatformApiPortalCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformApiPortalCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformApiPortalCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformApiPortalApiPortalsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformApiPortalResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformApiPortalResource.ResourceType, out string appPlatformApiPortalApiPortalsApiVersion);
            _appPlatformApiPortalApiPortalsRestClient = new ApiPortalsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformApiPortalApiPortalsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the default API portal or update the existing API portal.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiPortalName"> The name of API portal. </param>
        /// <param name="data"> The API portal for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiPortalName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiPortalName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformApiPortalResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string apiPortalName, AppPlatformApiPortalData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiPortalName, nameof(apiPortalName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalApiPortalsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformApiPortalResource>(new AppPlatformApiPortalOperationSource(Client), _appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, _appPlatformApiPortalApiPortalsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create the default API portal or update the existing API portal.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiPortalName"> The name of API portal. </param>
        /// <param name="data"> The API portal for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiPortalName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiPortalName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformApiPortalResource> CreateOrUpdate(WaitUntil waitUntil, string apiPortalName, AppPlatformApiPortalData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiPortalName, nameof(apiPortalName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalApiPortalsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformApiPortalResource>(new AppPlatformApiPortalOperationSource(Client), _appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, _appPlatformApiPortalApiPortalsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the API portal and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiPortalName"> The name of API portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiPortalName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiPortalName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformApiPortalResource>> GetAsync(string apiPortalName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiPortalName, nameof(apiPortalName));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalApiPortalsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the API portal and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiPortalName"> The name of API portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiPortalName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiPortalName"/> is null. </exception>
        public virtual Response<AppPlatformApiPortalResource> Get(string apiPortalName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiPortalName, nameof(apiPortalName));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalApiPortalsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformApiPortalResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformApiPortalResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformApiPortalResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformApiPortalApiPortalsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformApiPortalApiPortalsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppPlatformApiPortalResource(Client, AppPlatformApiPortalData.DeserializeAppPlatformApiPortalData(e)), _appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, "AppPlatformApiPortalCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformApiPortalResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformApiPortalResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformApiPortalApiPortalsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformApiPortalApiPortalsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppPlatformApiPortalResource(Client, AppPlatformApiPortalData.DeserializeAppPlatformApiPortalData(e)), _appPlatformApiPortalApiPortalsClientDiagnostics, Pipeline, "AppPlatformApiPortalCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiPortalName"> The name of API portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiPortalName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiPortalName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string apiPortalName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiPortalName, nameof(apiPortalName));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformApiPortalApiPortalsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apiPortals/{apiPortalName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiPortals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiPortalName"> The name of API portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiPortalName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiPortalName"/> is null. </exception>
        public virtual Response<bool> Exists(string apiPortalName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiPortalName, nameof(apiPortalName));

            using var scope = _appPlatformApiPortalApiPortalsClientDiagnostics.CreateScope("AppPlatformApiPortalCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformApiPortalApiPortalsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiPortalName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformApiPortalResource> IEnumerable<AppPlatformApiPortalResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformApiPortalResource> IAsyncEnumerable<AppPlatformApiPortalResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
