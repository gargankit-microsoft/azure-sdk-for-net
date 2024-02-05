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
using Azure.ResourceManager.CostManagement.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A Class representing a CostManagementExport along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CostManagementExportResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCostManagementExportResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetCostManagementExport method.
    /// </summary>
    public partial class CostManagementExportResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CostManagementExportResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="exportName"> The exportName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string exportName)
        {
            var resourceId = $"{scope}/providers/Microsoft.CostManagement/exports/{exportName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _costManagementExportExportsClientDiagnostics;
        private readonly ExportsRestOperations _costManagementExportExportsRestClient;
        private readonly CostManagementExportData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CostManagement/exports";

        /// <summary> Initializes a new instance of the <see cref="CostManagementExportResource"/> class for mocking. </summary>
        protected CostManagementExportResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CostManagementExportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CostManagementExportResource(ArmClient client, CostManagementExportData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CostManagementExportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CostManagementExportResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _costManagementExportExportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string costManagementExportExportsApiVersion);
            _costManagementExportExportsRestClient = new ExportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, costManagementExportExportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CostManagementExportData Data
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
        /// The operation to get the export for the defined scope by export name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CostManagementExportResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Get");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.GetAsync(Id.Parent, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the export for the defined scope by export name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CostManagementExportResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Get");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.Get(Id.Parent, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete a export.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Delete");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation(response);
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
        /// The operation to delete a export.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Delete");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new CostManagementArmOperation(response);
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
        /// The operation to create or update a export. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Export operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CostManagementExportResource>> UpdateAsync(WaitUntil waitUntil, CostManagementExportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Update");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation<CostManagementExportResource>(Response.FromValue(new CostManagementExportResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update a export. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Export operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CostManagementExportResource> Update(WaitUntil waitUntil, CostManagementExportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Update");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new CostManagementArmOperation<CostManagementExportResource>(Response.FromValue(new CostManagementExportResource(Client, response), response.GetRawResponse()));
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
        /// The operation to run an export.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}/run</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Execute</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Execute");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.ExecuteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to run an export.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}/run</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Execute</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Execute(CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportResource.Execute");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.Execute(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the run history of an export for the defined scope and export name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}/runHistory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_GetExecutionHistory</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExportRun"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExportRun> GetExecutionHistoryAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementExportExportsRestClient.CreateGetExecutionHistoryRequest(Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ExportRun.DeserializeExportRun(e), _costManagementExportExportsClientDiagnostics, Pipeline, "CostManagementExportResource.GetExecutionHistory", "value", null, cancellationToken);
        }

        /// <summary>
        /// The operation to get the run history of an export for the defined scope and export name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}/runHistory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_GetExecutionHistory</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CostManagementExportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExportRun"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExportRun> GetExecutionHistory(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementExportExportsRestClient.CreateGetExecutionHistoryRequest(Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ExportRun.DeserializeExportRun(e), _costManagementExportExportsClientDiagnostics, Pipeline, "CostManagementExportResource.GetExecutionHistory", "value", null, cancellationToken);
        }
    }
}
