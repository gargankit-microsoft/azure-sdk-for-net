// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure Operator Distributed Services network function Template application definition. </summary>
    public partial class AzureOperatorNexusNetworkFunctionArmTemplateApplication : AzureOperatorNexusNetworkFunctionApplication
    {
        /// <summary> Initializes a new instance of <see cref="AzureOperatorNexusNetworkFunctionArmTemplateApplication"/>. </summary>
        public AzureOperatorNexusNetworkFunctionArmTemplateApplication()
        {
            ArtifactType = AzureOperatorNexusArtifactType.ArmTemplate;
        }

        /// <summary> Initializes a new instance of <see cref="AzureOperatorNexusNetworkFunctionArmTemplateApplication"/>. </summary>
        /// <param name="name"> The name of the network function application. </param>
        /// <param name="dependsOnProfile"> Depends on profile definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="artifactType"> The artifact type. </param>
        /// <param name="artifactProfile"> Azure Operator Distributed Services Template artifact profile. </param>
        /// <param name="deployParametersMappingRuleProfile"> Deploy mapping rule profile. </param>
        internal AzureOperatorNexusNetworkFunctionArmTemplateApplication(string name, DependsOnProfile dependsOnProfile, IDictionary<string, BinaryData> serializedAdditionalRawData, AzureOperatorNexusArtifactType artifactType, AzureOperatorNexusArmTemplateArtifactProfile artifactProfile, AzureOperatorNexusArmTemplateDeployMappingRuleProfile deployParametersMappingRuleProfile) : base(name, dependsOnProfile, serializedAdditionalRawData, artifactType)
        {
            ArtifactProfile = artifactProfile;
            DeployParametersMappingRuleProfile = deployParametersMappingRuleProfile;
            ArtifactType = artifactType;
        }

        /// <summary> Azure Operator Distributed Services Template artifact profile. </summary>
        public AzureOperatorNexusArmTemplateArtifactProfile ArtifactProfile { get; set; }
        /// <summary> Deploy mapping rule profile. </summary>
        public AzureOperatorNexusArmTemplateDeployMappingRuleProfile DeployParametersMappingRuleProfile { get; set; }
    }
}
