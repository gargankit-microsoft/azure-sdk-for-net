// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing an IngestionSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="IngestionSettingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetIngestionSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetIngestionSetting method.
    /// </summary>
    public partial class IngestionSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IngestionSettingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="ingestionSettingName"> The ingestionSettingName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string ingestionSettingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _ingestionSettingClientDiagnostics;
        private readonly IngestionSettingsRestOperations _ingestionSettingRestClient;
        private readonly IngestionSettingData _data;

        /// <summary> Initializes a new instance of the <see cref="IngestionSettingResource"/> class for mocking. </summary>
        protected IngestionSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "IngestionSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IngestionSettingResource(ArmClient client, IngestionSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IngestionSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IngestionSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ingestionSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string ingestionSettingApiVersion);
            _ingestionSettingRestClient = new IngestionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ingestionSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/ingestionSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IngestionSettingData Data
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
        /// Settings for ingesting security data and logs to correlate with resources associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IngestionSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _ingestionSettingRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IngestionSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings for ingesting security data and logs to correlate with resources associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IngestionSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.Get");
            scope.Start();
            try
            {
                var response = _ingestionSettingRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IngestionSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the ingestion settings for this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.Delete");
            scope.Start();
            try
            {
                var response = await _ingestionSettingRestClient.DeleteAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Deletes the ingestion settings for this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.Delete");
            scope.Start();
            try
            {
                var response = _ingestionSettingRestClient.Delete(Id.SubscriptionId, Id.Name, cancellationToken);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Create setting for ingesting security data and logs to correlate with resources associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Ingestion setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IngestionSettingResource>> UpdateAsync(WaitUntil waitUntil, IngestionSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _ingestionSettingRestClient.CreateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<IngestionSettingResource>(Response.FromValue(new IngestionSettingResource(Client, response), response.GetRawResponse()));
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
        /// Create setting for ingesting security data and logs to correlate with resources associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Ingestion setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IngestionSettingResource> Update(WaitUntil waitUntil, IngestionSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.Update");
            scope.Start();
            try
            {
                var response = _ingestionSettingRestClient.Create(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<IngestionSettingResource>(Response.FromValue(new IngestionSettingResource(Client, response), response.GetRawResponse()));
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
        /// Returns the token that is used for correlating ingested telemetry with the resources in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}/listTokens</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_ListTokens</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IngestionSettingToken>> GetTokensAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.GetTokens");
            scope.Start();
            try
            {
                var response = await _ingestionSettingRestClient.ListTokensAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the token that is used for correlating ingested telemetry with the resources in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}/listTokens</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_ListTokens</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IngestionSettingToken> GetTokens(CancellationToken cancellationToken = default)
        {
            using var scope = _ingestionSettingClientDiagnostics.CreateScope("IngestionSettingResource.GetTokens");
            scope.Start();
            try
            {
                var response = _ingestionSettingRestClient.ListTokens(Id.SubscriptionId, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Connection strings for ingesting security scan logs and data.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}/listConnectionStrings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_ListConnectionStrings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IngestionConnectionString" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IngestionConnectionString> GetConnectionStringsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ingestionSettingRestClient.CreateListConnectionStringsRequest(Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, IngestionConnectionString.DeserializeIngestionConnectionString, _ingestionSettingClientDiagnostics, Pipeline, "IngestionSettingResource.GetConnectionStrings", "value", null, cancellationToken);
        }

        /// <summary>
        /// Connection strings for ingesting security scan logs and data.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/ingestionSettings/{ingestionSettingName}/listConnectionStrings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IngestionSettings_ListConnectionStrings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IngestionConnectionString" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IngestionConnectionString> GetConnectionStrings(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ingestionSettingRestClient.CreateListConnectionStringsRequest(Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, IngestionConnectionString.DeserializeIngestionConnectionString, _ingestionSettingClientDiagnostics, Pipeline, "IngestionSettingResource.GetConnectionStrings", "value", null, cancellationToken);
        }
    }
}
