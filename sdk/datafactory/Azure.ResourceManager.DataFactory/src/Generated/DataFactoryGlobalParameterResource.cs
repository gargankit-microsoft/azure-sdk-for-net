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

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A Class representing a DataFactoryGlobalParameter along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataFactoryGlobalParameterResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataFactoryGlobalParameterResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataFactoryResource" /> using the GetDataFactoryGlobalParameter method.
    /// </summary>
    public partial class DataFactoryGlobalParameterResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataFactoryGlobalParameterResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="factoryName"> The factoryName. </param>
        /// <param name="globalParameterName"> The globalParameterName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string factoryName, string globalParameterName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/globalParameters/{globalParameterName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataFactoryGlobalParameterGlobalParametersClientDiagnostics;
        private readonly GlobalParametersRestOperations _dataFactoryGlobalParameterGlobalParametersRestClient;
        private readonly DataFactoryGlobalParameterData _data;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryGlobalParameterResource"/> class for mocking. </summary>
        protected DataFactoryGlobalParameterResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataFactoryGlobalParameterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataFactoryGlobalParameterResource(ArmClient client, DataFactoryGlobalParameterData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryGlobalParameterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataFactoryGlobalParameterResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryGlobalParameterGlobalParametersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataFactoryGlobalParameterGlobalParametersApiVersion);
            _dataFactoryGlobalParameterGlobalParametersRestClient = new GlobalParametersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryGlobalParameterGlobalParametersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataFactory/factories/globalParameters";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataFactoryGlobalParameterData Data
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
        /// Gets a Global parameter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/globalParameters/{globalParameterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalParameters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataFactoryGlobalParameterResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryGlobalParameterGlobalParametersClientDiagnostics.CreateScope("DataFactoryGlobalParameterResource.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryGlobalParameterGlobalParametersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryGlobalParameterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Global parameter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/globalParameters/{globalParameterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalParameters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataFactoryGlobalParameterResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryGlobalParameterGlobalParametersClientDiagnostics.CreateScope("DataFactoryGlobalParameterResource.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryGlobalParameterGlobalParametersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryGlobalParameterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Global parameter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/globalParameters/{globalParameterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalParameters_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryGlobalParameterGlobalParametersClientDiagnostics.CreateScope("DataFactoryGlobalParameterResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataFactoryGlobalParameterGlobalParametersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation(response);
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
        /// Deletes a Global parameter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/globalParameters/{globalParameterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalParameters_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataFactoryGlobalParameterGlobalParametersClientDiagnostics.CreateScope("DataFactoryGlobalParameterResource.Delete");
            scope.Start();
            try
            {
                var response = _dataFactoryGlobalParameterGlobalParametersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataFactoryArmOperation(response);
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
        /// Creates or updates a Global parameter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/globalParameters/{globalParameterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalParameters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Global parameter resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryGlobalParameterResource>> UpdateAsync(WaitUntil waitUntil, DataFactoryGlobalParameterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryGlobalParameterGlobalParametersClientDiagnostics.CreateScope("DataFactoryGlobalParameterResource.Update");
            scope.Start();
            try
            {
                var response = await _dataFactoryGlobalParameterGlobalParametersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryGlobalParameterResource>(Response.FromValue(new DataFactoryGlobalParameterResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a Global parameter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/globalParameters/{globalParameterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalParameters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Global parameter resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryGlobalParameterResource> Update(WaitUntil waitUntil, DataFactoryGlobalParameterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryGlobalParameterGlobalParametersClientDiagnostics.CreateScope("DataFactoryGlobalParameterResource.Update");
            scope.Start();
            try
            {
                var response = _dataFactoryGlobalParameterGlobalParametersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryGlobalParameterResource>(Response.FromValue(new DataFactoryGlobalParameterResource(Client, response), response.GetRawResponse()));
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
