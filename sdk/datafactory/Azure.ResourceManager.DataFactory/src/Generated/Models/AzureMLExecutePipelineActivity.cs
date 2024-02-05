// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure ML Execute Pipeline activity. </summary>
    public partial class AzureMLExecutePipelineActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="AzureMLExecutePipelineActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AzureMLExecutePipelineActivity(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ActivityType = "AzureMLExecutePipeline";
        }

        /// <summary> Initializes a new instance of <see cref="AzureMLExecutePipelineActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="mlPipelineId"> ID of the published Azure ML pipeline. Type: string (or Expression with resultType string). </param>
        /// <param name="mlPipelineEndpointId"> ID of the published Azure ML pipeline endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="version"> Version of the published Azure ML pipeline endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="experimentName"> Run history experiment name of the pipeline run. This information will be passed in the ExperimentName property of the published pipeline execution request. Type: string (or Expression with resultType string). </param>
        /// <param name="mlPipelineParameters"> Key,Value pairs to be passed to the published Azure ML pipeline endpoint. Keys must match the names of pipeline parameters defined in the published pipeline. Values will be passed in the ParameterAssignments property of the published pipeline execution request. Type: object with key value pairs (or Expression with resultType object). </param>
        /// <param name="dataPathAssignments"> Dictionary used for changing data path assignments without retraining. Values will be passed in the dataPathAssignments property of the published pipeline execution request. Type: object (or Expression with resultType object). </param>
        /// <param name="mlParentRunId"> The parent Azure ML Service pipeline run id. This information will be passed in the ParentRunId property of the published pipeline execution request. Type: string (or Expression with resultType string). </param>
        /// <param name="continueOnStepFailure"> Whether to continue execution of other steps in the PipelineRun if a step fails. This information will be passed in the continueOnStepFailure property of the published pipeline execution request. Type: boolean (or Expression with resultType boolean). </param>
        internal AzureMLExecutePipelineActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> mlPipelineId, DataFactoryElement<string> mlPipelineEndpointId, DataFactoryElement<string> version, DataFactoryElement<string> experimentName, DataFactoryElement<IDictionary<string, string>> mlPipelineParameters, BinaryData dataPathAssignments, DataFactoryElement<string> mlParentRunId, DataFactoryElement<bool> continueOnStepFailure) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            MLPipelineId = mlPipelineId;
            MLPipelineEndpointId = mlPipelineEndpointId;
            Version = version;
            ExperimentName = experimentName;
            MLPipelineParameters = mlPipelineParameters;
            DataPathAssignments = dataPathAssignments;
            MLParentRunId = mlParentRunId;
            ContinueOnStepFailure = continueOnStepFailure;
            ActivityType = activityType ?? "AzureMLExecutePipeline";
        }

        /// <summary> Initializes a new instance of <see cref="AzureMLExecutePipelineActivity"/> for deserialization. </summary>
        internal AzureMLExecutePipelineActivity()
        {
        }

        /// <summary> ID of the published Azure ML pipeline. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> MLPipelineId { get; set; }
        /// <summary> ID of the published Azure ML pipeline endpoint. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> MLPipelineEndpointId { get; set; }
        /// <summary> Version of the published Azure ML pipeline endpoint. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Version { get; set; }
        /// <summary> Run history experiment name of the pipeline run. This information will be passed in the ExperimentName property of the published pipeline execution request. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ExperimentName { get; set; }
        /// <summary> Key,Value pairs to be passed to the published Azure ML pipeline endpoint. Keys must match the names of pipeline parameters defined in the published pipeline. Values will be passed in the ParameterAssignments property of the published pipeline execution request. Type: object with key value pairs (or Expression with resultType object). </summary>
        public DataFactoryElement<IDictionary<string, string>> MLPipelineParameters { get; set; }
        /// <summary>
        /// Dictionary used for changing data path assignments without retraining. Values will be passed in the dataPathAssignments property of the published pipeline execution request. Type: object (or Expression with resultType object).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData DataPathAssignments { get; set; }
        /// <summary> The parent Azure ML Service pipeline run id. This information will be passed in the ParentRunId property of the published pipeline execution request. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> MLParentRunId { get; set; }
        /// <summary> Whether to continue execution of other steps in the PipelineRun if a step fails. This information will be passed in the continueOnStepFailure property of the published pipeline execution request. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> ContinueOnStepFailure { get; set; }
    }
}
