// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareLROTask. </summary>
    internal partial class HealthcareLROTask : AnalyzeTextLROTask
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareLROTask"/>. </summary>
        public HealthcareLROTask()
        {
            Kind = AnalyzeTextLROTaskKind.Healthcare;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareLROTask"/>. </summary>
        /// <param name="taskName"></param>
        /// <param name="kind"> Enumeration of supported long-running Text Analysis tasks. </param>
        /// <param name="parameters"> Supported parameters for a Healthcare task. </param>
        internal HealthcareLROTask(string taskName, AnalyzeTextLROTaskKind kind, HealthcareTaskParameters parameters) : base(taskName, kind)
        {
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Supported parameters for a Healthcare task. </summary>
        public HealthcareTaskParameters Parameters { get; set; }
    }
}
