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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteProcess and their operations over its parent. </summary>
    public partial class SiteProcessCollection : ArmCollection, IEnumerable<SiteProcess>, IAsyncEnumerable<SiteProcess>
    {
        private readonly ClientDiagnostics _siteProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteProcessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteProcessCollection"/> class for mocking. </summary>
        protected SiteProcessCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteProcessCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteProcessCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteProcess.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteProcess.ResourceType, out string siteProcessWebAppsApiVersion);
            _siteProcessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual async Task<Response<SiteProcess>> GetAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteProcessWebAppsRestClient.GetProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteProcess> Get(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Get");
            scope.Start();
            try
            {
                var response = _siteProcessWebAppsRestClient.GetProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes
        /// Operation Id: WebApps_ListProcesses
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteProcess> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteProcess>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteProcessWebAppsRestClient.ListProcessesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteProcess>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteProcessWebAppsRestClient.ListProcessesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes
        /// Operation Id: WebApps_ListProcesses
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteProcess> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteProcess> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteProcessWebAppsRestClient.ListProcesses(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteProcess> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteProcessWebAppsRestClient.ListProcessesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(processId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<bool> Exists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(processId, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual async Task<Response<SiteProcess>> GetIfExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteProcessWebAppsRestClient.GetProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteProcess>(null, response.GetRawResponse());
                return Response.FromValue(new SiteProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteProcess> GetIfExists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteProcessWebAppsRestClient.GetProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteProcess>(null, response.GetRawResponse());
                return Response.FromValue(new SiteProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteProcess> IEnumerable<SiteProcess>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteProcess> IAsyncEnumerable<SiteProcess>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
