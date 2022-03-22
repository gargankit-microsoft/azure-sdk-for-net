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
    /// <summary> A class representing collection of SiteSlotDiagnostic and their operations over its parent. </summary>
    public partial class SiteSlotDiagnosticCollection : ArmCollection, IEnumerable<SiteSlotDiagnostic>, IAsyncEnumerable<SiteSlotDiagnostic>
    {
        private readonly ClientDiagnostics _siteSlotDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDiagnosticCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDiagnostic.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotDiagnostic.ResourceType, out string siteSlotDiagnosticDiagnosticsApiVersion);
            _siteSlotDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategorySlot
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDiagnostic>> GetAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategorySlot
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteSlotDiagnostic> Get(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Categories
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics
        /// Operation Id: Diagnostics_ListSiteDiagnosticCategoriesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnostic> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDiagnostic>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategoriesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDiagnostic>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategoriesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get Diagnostics Categories
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics
        /// Operation Id: Diagnostics_ListSiteDiagnosticCategoriesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnostic> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDiagnostic> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategoriesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDiagnostic> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategoriesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategorySlot
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategorySlot
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<bool> Exists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(diagnosticCategory, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategorySlot
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDiagnostic>> GetIfExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDiagnostic>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategorySlot
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteSlotDiagnostic> GetIfExists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteSlotDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDiagnostic>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDiagnostic> IEnumerable<SiteSlotDiagnostic>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnostic> IAsyncEnumerable<SiteSlotDiagnostic>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
