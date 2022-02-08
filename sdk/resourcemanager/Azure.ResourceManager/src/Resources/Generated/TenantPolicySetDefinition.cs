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

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a TenantPolicySetDefinition along with the instance operations that can be performed on it. </summary>
    public partial class TenantPolicySetDefinition : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantPolicySetDefinition"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string policySetDefinitionName)
        {
            var resourceId = $"/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _tenantPolicySetDefinitionPolicySetDefinitionsRestClient;
        private readonly PolicySetDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantPolicySetDefinition"/> class for mocking. </summary>
        protected TenantPolicySetDefinition()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantPolicySetDefinition"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantPolicySetDefinition(ArmClient client, PolicySetDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPolicySetDefinition"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantPolicySetDefinition(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _tenantPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(_tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, tenantPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policySetDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicySetDefinitionData Data
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

        /// RequestPath: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// ContextualPath: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// OperationId: PolicySetDefinitions_GetBuiltIn
        /// <summary> This operation retrieves the built-in policy set definition with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<TenantPolicySetDefinition>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("TenantPolicySetDefinition.Get");
            scope.Start();
            try
            {
                var response = await _tenantPolicySetDefinitionPolicySetDefinitionsRestClient.GetBuiltInAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TenantPolicySetDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// ContextualPath: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// OperationId: PolicySetDefinitions_GetBuiltIn
        /// <summary> This operation retrieves the built-in policy set definition with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantPolicySetDefinition> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("TenantPolicySetDefinition.Get");
            scope.Start();
            try
            {
                var response = _tenantPolicySetDefinitionPolicySetDefinitionsRestClient.GetBuiltIn(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _tenantPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPolicySetDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
