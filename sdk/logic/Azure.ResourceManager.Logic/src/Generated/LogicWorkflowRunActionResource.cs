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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A Class representing a LogicWorkflowRunAction along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="LogicWorkflowRunActionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetLogicWorkflowRunActionResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogicWorkflowRunResource"/> using the GetLogicWorkflowRunAction method.
    /// </summary>
    public partial class LogicWorkflowRunActionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicWorkflowRunActionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workflowName"> The workflowName. </param>
        /// <param name="runName"> The runName. </param>
        /// <param name="actionName"> The actionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicWorkflowRunActionWorkflowRunActionsClientDiagnostics;
        private readonly WorkflowRunActionsRestOperations _logicWorkflowRunActionWorkflowRunActionsRestClient;
        private readonly LogicWorkflowRunActionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Logic/workflows/runs/actions";

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionResource"/> class for mocking. </summary>
        protected LogicWorkflowRunActionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRunActionResource(ArmClient client, LogicWorkflowRunActionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRunActionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunActionWorkflowRunActionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunActionWorkflowRunActionsApiVersion);
            _logicWorkflowRunActionWorkflowRunActionsRestClient = new WorkflowRunActionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunActionWorkflowRunActionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicWorkflowRunActionData Data
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

        /// <summary> Gets a collection of LogicWorkflowRunActionRepetitionResources in the LogicWorkflowRunAction. </summary>
        /// <returns> An object representing collection of LogicWorkflowRunActionRepetitionResources and their operations over a LogicWorkflowRunActionRepetitionResource. </returns>
        public virtual LogicWorkflowRunActionRepetitionCollection GetLogicWorkflowRunActionRepetitions()
        {
            return GetCachedClient(client => new LogicWorkflowRunActionRepetitionCollection(client, Id));
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowRunActionRepetitionResource>> GetLogicWorkflowRunActionRepetitionAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflowRunActionRepetitions().GetAsync(repetitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowRunActionRepetitionResource> GetLogicWorkflowRunActionRepetition(string repetitionName, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflowRunActionRepetitions().Get(repetitionName, cancellationToken);
        }

        /// <summary> Gets a collection of LogicWorkflowRunActionScopeRepetitionResources in the LogicWorkflowRunAction. </summary>
        /// <returns> An object representing collection of LogicWorkflowRunActionScopeRepetitionResources and their operations over a LogicWorkflowRunActionScopeRepetitionResource. </returns>
        public virtual LogicWorkflowRunActionScopeRepetitionCollection GetLogicWorkflowRunActionScopeRepetitions()
        {
            return GetCachedClient(client => new LogicWorkflowRunActionScopeRepetitionCollection(client, Id));
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowRunActionScopeRepetitionResource>> GetLogicWorkflowRunActionScopeRepetitionAsync(string repetitionName, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflowRunActionScopeRepetitions().GetAsync(repetitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionScopeRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionScopeRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowRunActionScopeRepetitionResource> GetLogicWorkflowRunActionScopeRepetition(string repetitionName, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflowRunActionScopeRepetitions().Get(repetitionName, cancellationToken);
        }

        /// <summary> Gets a collection of LogicWorkflowRunActionRequestHistoryResources in the LogicWorkflowRunAction. </summary>
        /// <returns> An object representing collection of LogicWorkflowRunActionRequestHistoryResources and their operations over a LogicWorkflowRunActionRequestHistoryResource. </returns>
        public virtual LogicWorkflowRunActionRequestHistoryCollection GetLogicWorkflowRunActionRequestHistories()
        {
            return GetCachedClient(client => new LogicWorkflowRunActionRequestHistoryCollection(client, Id));
        }

        /// <summary>
        /// Gets a workflow run request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowRunActionRequestHistoryResource>> GetLogicWorkflowRunActionRequestHistoryAsync(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflowRunActionRequestHistories().GetAsync(requestHistoryName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow run request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowRunActionRequestHistoryResource> GetLogicWorkflowRunActionRequestHistory(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflowRunActionRequestHistories().Get(requestHistoryName, cancellationToken);
        }

        /// <summary>
        /// Gets a workflow run action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogicWorkflowRunActionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionWorkflowRunActionsClientDiagnostics.CreateScope("LogicWorkflowRunActionResource.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunActionWorkflowRunActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow run action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicWorkflowRunActionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionWorkflowRunActionsClientDiagnostics.CreateScope("LogicWorkflowRunActionResource.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunActionWorkflowRunActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a workflow run expression trace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/listExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActions_ListExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicExpressionRoot"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicExpressionRoot> GetExpressionTracesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowRunActionWorkflowRunActionsRestClient.CreateListExpressionTracesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => LogicExpressionRoot.DeserializeLogicExpressionRoot(e), _logicWorkflowRunActionWorkflowRunActionsClientDiagnostics, Pipeline, "LogicWorkflowRunActionResource.GetExpressionTraces", "inputs", null, cancellationToken);
        }

        /// <summary>
        /// Lists a workflow run expression trace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/listExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActions_ListExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicWorkflowRunActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicExpressionRoot"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicExpressionRoot> GetExpressionTraces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowRunActionWorkflowRunActionsRestClient.CreateListExpressionTracesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => LogicExpressionRoot.DeserializeLogicExpressionRoot(e), _logicWorkflowRunActionWorkflowRunActionsClientDiagnostics, Pipeline, "LogicWorkflowRunActionResource.GetExpressionTraces", "inputs", null, cancellationToken);
        }
    }
}
