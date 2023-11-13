// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownMLAssistConfiguration. </summary>
    internal partial class UnknownMLAssistConfiguration : MachineLearningAssistConfiguration
    {
        /// <summary> Initializes a new instance of UnknownMLAssistConfiguration. </summary>
        /// <param name="mlAssist"> [Required] Indicates whether MLAssist feature is enabled. </param>
        internal UnknownMLAssistConfiguration(MLAssistConfigurationType mlAssist) : base(mlAssist)
        {
            MlAssist = mlAssist;
        }
    }
}
