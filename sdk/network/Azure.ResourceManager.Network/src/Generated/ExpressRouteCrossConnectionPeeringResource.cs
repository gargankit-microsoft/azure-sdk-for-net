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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing an ExpressRouteCrossConnectionPeering along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ExpressRouteCrossConnectionPeeringResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetExpressRouteCrossConnectionPeeringResource method.
    /// Otherwise you can get one from its parent resource <see cref="ExpressRouteCrossConnectionResource" /> using the GetExpressRouteCrossConnectionPeering method.
    /// </summary>
    public partial class ExpressRouteCrossConnectionPeeringResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRouteCrossConnectionPeeringResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="crossConnectionName"> The crossConnectionName. </param>
        /// <param name="peeringName"> The peeringName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string crossConnectionName, string peeringName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _expressRouteCrossConnectionPeeringClientDiagnostics;
        private readonly ExpressRouteCrossConnectionPeeringsRestOperations _expressRouteCrossConnectionPeeringRestClient;
        private readonly ClientDiagnostics _expressRouteCrossConnectionClientDiagnostics;
        private readonly ExpressRouteCrossConnectionsRestOperations _expressRouteCrossConnectionRestClient;
        private readonly ExpressRouteCrossConnectionPeeringData _data;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringResource"/> class for mocking. </summary>
        protected ExpressRouteCrossConnectionPeeringResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ExpressRouteCrossConnectionPeeringResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRouteCrossConnectionPeeringResource(ArmClient client, ExpressRouteCrossConnectionPeeringData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteCrossConnectionPeeringResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCrossConnectionPeeringClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string expressRouteCrossConnectionPeeringApiVersion);
            _expressRouteCrossConnectionPeeringRestClient = new ExpressRouteCrossConnectionPeeringsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCrossConnectionPeeringApiVersion);
            _expressRouteCrossConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCrossConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteCrossConnectionResource.ResourceType, out string expressRouteCrossConnectionApiVersion);
            _expressRouteCrossConnectionRestClient = new ExpressRouteCrossConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCrossConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteCrossConnections/peerings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRouteCrossConnectionPeeringData Data
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
        /// Gets the specified peering for the ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCrossConnectionPeeringResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified peering for the ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCrossConnectionPeeringResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified peering from the ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.Delete");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified peering from the ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.Delete");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a peering in the specified ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCrossConnectionPeeringResource>> UpdateAsync(WaitUntil waitUntil, ExpressRouteCrossConnectionPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.Update");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionPeeringResource>(new ExpressRouteCrossConnectionPeeringOperationSource(Client), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a peering in the specified ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCrossConnectionPeeringResource> Update(WaitUntil waitUntil, ExpressRouteCrossConnectionPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.Update");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionPeeringResource>(new ExpressRouteCrossConnectionPeeringOperationSource(Client), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the currently advertised ARP table associated with the express route cross connection in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}/arpTables/{devicePath}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnections_ListArpTable</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devicePath"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitsArpTableListResult>> GetArpTableExpressRouteCrossConnectionAsync(WaitUntil waitUntil, string devicePath, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devicePath, nameof(devicePath));

            using var scope = _expressRouteCrossConnectionClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.GetArpTableExpressRouteCrossConnection");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionRestClient.ListArpTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitsArpTableListResult>(new ExpressRouteCircuitsArpTableListResultOperationSource(), _expressRouteCrossConnectionClientDiagnostics, Pipeline, _expressRouteCrossConnectionRestClient.CreateListArpTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the currently advertised ARP table associated with the express route cross connection in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}/arpTables/{devicePath}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnections_ListArpTable</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devicePath"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitsArpTableListResult> GetArpTableExpressRouteCrossConnection(WaitUntil waitUntil, string devicePath, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devicePath, nameof(devicePath));

            using var scope = _expressRouteCrossConnectionClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.GetArpTableExpressRouteCrossConnection");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionRestClient.ListArpTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitsArpTableListResult>(new ExpressRouteCircuitsArpTableListResultOperationSource(), _expressRouteCrossConnectionClientDiagnostics, Pipeline, _expressRouteCrossConnectionRestClient.CreateListArpTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the route table summary associated with the express route cross connection in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}/routeTablesSummary/{devicePath}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnections_ListRoutesTableSummary</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devicePath"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>> GetRoutesTableSummaryExpressRouteCrossConnectionAsync(WaitUntil waitUntil, string devicePath, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devicePath, nameof(devicePath));

            using var scope = _expressRouteCrossConnectionClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.GetRoutesTableSummaryExpressRouteCrossConnection");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionRestClient.ListRoutesTableSummaryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>(new ExpressRouteCrossConnectionsRoutesTableSummaryListResultOperationSource(), _expressRouteCrossConnectionClientDiagnostics, Pipeline, _expressRouteCrossConnectionRestClient.CreateListRoutesTableSummaryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the route table summary associated with the express route cross connection in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}/routeTablesSummary/{devicePath}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnections_ListRoutesTableSummary</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devicePath"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCrossConnectionsRoutesTableSummaryListResult> GetRoutesTableSummaryExpressRouteCrossConnection(WaitUntil waitUntil, string devicePath, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devicePath, nameof(devicePath));

            using var scope = _expressRouteCrossConnectionClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.GetRoutesTableSummaryExpressRouteCrossConnection");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionRestClient.ListRoutesTableSummary(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>(new ExpressRouteCrossConnectionsRoutesTableSummaryListResultOperationSource(), _expressRouteCrossConnectionClientDiagnostics, Pipeline, _expressRouteCrossConnectionRestClient.CreateListRoutesTableSummaryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the currently advertised routes table associated with the express route cross connection in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}/routeTables/{devicePath}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnections_ListRoutesTable</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devicePath"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitsRoutesTableListResult>> GetRoutesTableExpressRouteCrossConnectionAsync(WaitUntil waitUntil, string devicePath, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devicePath, nameof(devicePath));

            using var scope = _expressRouteCrossConnectionClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.GetRoutesTableExpressRouteCrossConnection");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionRestClient.ListRoutesTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitsRoutesTableListResult>(new ExpressRouteCircuitsRoutesTableListResultOperationSource(), _expressRouteCrossConnectionClientDiagnostics, Pipeline, _expressRouteCrossConnectionRestClient.CreateListRoutesTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the currently advertised routes table associated with the express route cross connection in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}/routeTables/{devicePath}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnections_ListRoutesTable</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devicePath"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitsRoutesTableListResult> GetRoutesTableExpressRouteCrossConnection(WaitUntil waitUntil, string devicePath, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devicePath, nameof(devicePath));

            using var scope = _expressRouteCrossConnectionClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringResource.GetRoutesTableExpressRouteCrossConnection");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionRestClient.ListRoutesTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitsRoutesTableListResult>(new ExpressRouteCircuitsRoutesTableListResultOperationSource(), _expressRouteCrossConnectionClientDiagnostics, Pipeline, _expressRouteCrossConnectionRestClient.CreateListRoutesTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response, OperationFinalStateVia.Location);
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
    }
}
