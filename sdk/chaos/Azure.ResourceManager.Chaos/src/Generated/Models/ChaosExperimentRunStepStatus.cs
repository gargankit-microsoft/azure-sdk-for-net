// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the a list of branches and branch statuses. </summary>
    public partial class ChaosExperimentRunStepStatus
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChaosExperimentRunStepStatus"/>. </summary>
        internal ChaosExperimentRunStepStatus()
        {
            Branches = new ChangeTrackingList<ChaosExperimentRunBranchStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="ChaosExperimentRunStepStatus"/>. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="stepId"> The id of the step. </param>
        /// <param name="status"> The value of the status of the step. </param>
        /// <param name="branches"> The array of branches. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChaosExperimentRunStepStatus(string stepName, string stepId, string status, IReadOnlyList<ChaosExperimentRunBranchStatus> branches, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StepName = stepName;
            StepId = stepId;
            Status = status;
            Branches = branches;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the step. </summary>
        public string StepName { get; }
        /// <summary> The id of the step. </summary>
        public string StepId { get; }
        /// <summary> The value of the status of the step. </summary>
        public string Status { get; }
        /// <summary> The array of branches. </summary>
        public IReadOnlyList<ChaosExperimentRunBranchStatus> Branches { get; }
    }
}
