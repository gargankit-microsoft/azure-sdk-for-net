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

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A Class representing a Component along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ComponentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetComponentResource method.
    /// Otherwise you can get one from its parent resource <see cref="NetworkFunctionResource" /> using the GetComponent method.
    /// </summary>
    public partial class ComponentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ComponentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="networkFunctionName"> The networkFunctionName. </param>
        /// <param name="componentName"> The componentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkFunctionName, string componentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}/components/{componentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _componentClientDiagnostics;
        private readonly ComponentsRestOperations _componentRestClient;
        private readonly ComponentData _data;

        /// <summary> Initializes a new instance of the <see cref="ComponentResource"/> class for mocking. </summary>
        protected ComponentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ComponentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ComponentResource(ArmClient client, ComponentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ComponentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ComponentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _componentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string componentApiVersion);
            _componentRestClient = new ComponentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, componentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridNetwork/networkFunctions/components";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ComponentData Data
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
        /// Gets information about the specified application instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Components_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ComponentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _componentClientDiagnostics.CreateScope("ComponentResource.Get");
            scope.Start();
            try
            {
                var response = await _componentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified application instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}/components/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Components_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ComponentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _componentClientDiagnostics.CreateScope("ComponentResource.Get");
            scope.Start();
            try
            {
                var response = _componentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
