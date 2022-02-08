// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteConfigSnapshot along with the instance operations that can be performed on it. </summary>
    public partial class SiteConfigSnapshot : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteConfigSnapshot"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string snapshotId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteConfigSnapshotWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigSnapshotWebAppsRestClient;
        private readonly SiteConfigData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigSnapshot"/> class for mocking. </summary>
        protected SiteConfigSnapshot()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteConfigSnapshot"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteConfigSnapshot(ArmClient client, SiteConfigData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigSnapshot"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteConfigSnapshot(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteConfigSnapshotWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteConfigSnapshotWebAppsApiVersion);
            _siteConfigSnapshotWebAppsRestClient = new WebAppsRestOperations(_siteConfigSnapshotWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteConfigSnapshotWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config/snapshots";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteConfigData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// OperationId: WebApps_GetConfigurationSnapshot
        /// <summary> Description for Gets a snapshot of the configuration of an app at a previous point in time. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteConfigSnapshot>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshot.Get");
            scope.Start();
            try
            {
                var response = await _siteConfigSnapshotWebAppsRestClient.GetConfigurationSnapshotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteConfigSnapshotWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigSnapshot(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// OperationId: WebApps_GetConfigurationSnapshot
        /// <summary> Description for Gets a snapshot of the configuration of an app at a previous point in time. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteConfigSnapshot> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshot.Get");
            scope.Start();
            try
            {
                var response = _siteConfigSnapshotWebAppsRestClient.GetConfigurationSnapshot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteConfigSnapshotWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigSnapshot(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}/recover
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// OperationId: WebApps_RecoverSiteConfigurationSnapshot
        /// <summary> Description for Reverts the configuration of an app to a previous snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> RecoverSiteConfigurationSnapshotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshot.RecoverSiteConfigurationSnapshot");
            scope.Start();
            try
            {
                var response = await _siteConfigSnapshotWebAppsRestClient.RecoverSiteConfigurationSnapshotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}/recover
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// OperationId: WebApps_RecoverSiteConfigurationSnapshot
        /// <summary> Description for Reverts the configuration of an app to a previous snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RecoverSiteConfigurationSnapshot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshot.RecoverSiteConfigurationSnapshot");
            scope.Start();
            try
            {
                var response = _siteConfigSnapshotWebAppsRestClient.RecoverSiteConfigurationSnapshot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
