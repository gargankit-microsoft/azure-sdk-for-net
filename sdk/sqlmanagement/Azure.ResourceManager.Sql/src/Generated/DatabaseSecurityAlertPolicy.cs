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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a DatabaseSecurityAlertPolicy along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseSecurityAlertPolicy : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseSecurityAlertPolicy"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string securityAlertPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseSecurityAlertPolicyClientDiagnostics;
        private readonly DatabaseSecurityAlertPoliciesRestOperations _databaseSecurityAlertPolicyRestClient;
        private readonly DatabaseSecurityAlertPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseSecurityAlertPolicy"/> class for mocking. </summary>
        protected DatabaseSecurityAlertPolicy()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseSecurityAlertPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseSecurityAlertPolicy(ArmClient client, DatabaseSecurityAlertPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseSecurityAlertPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseSecurityAlertPolicy(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseSecurityAlertPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string databaseSecurityAlertPolicyApiVersion);
            _databaseSecurityAlertPolicyRestClient = new DatabaseSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseSecurityAlertPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/securityAlertPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseSecurityAlertPolicyData Data
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

        /// <summary>
        /// Gets a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatabaseSecurityAlertPolicy>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicy.Get");
            scope.Start();
            try
            {
                var response = await _databaseSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseSecurityAlertPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: DatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseSecurityAlertPolicy> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseSecurityAlertPolicyClientDiagnostics.CreateScope("DatabaseSecurityAlertPolicy.Get");
            scope.Start();
            try
            {
                var response = _databaseSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseSecurityAlertPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
