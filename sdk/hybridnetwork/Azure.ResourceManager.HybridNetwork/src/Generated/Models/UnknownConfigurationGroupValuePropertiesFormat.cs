// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The UnknownConfigurationGroupValuePropertiesFormat. </summary>
    internal partial class UnknownConfigurationGroupValuePropertiesFormat : ConfigurationGroupValuePropertiesFormat
    {
        /// <summary> Initializes a new instance of <see cref="UnknownConfigurationGroupValuePropertiesFormat"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the site resource. </param>
        /// <param name="publisherName"> The publisher name for the configuration group schema. </param>
        /// <param name="publisherScope"> The scope of the publisher. </param>
        /// <param name="configurationGroupSchemaName"> The configuration group schema name. </param>
        /// <param name="configurationGroupSchemaOfferingLocation"> The location of the configuration group schema offering. </param>
        /// <param name="configurationGroupSchemaResourceReference">
        /// The configuration group schema resource reference.
        /// Please note <see cref="DeploymentResourceIdReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OpenDeploymentResourceReference"/> and <see cref="SecretDeploymentResourceReference"/>.
        /// </param>
        /// <param name="configurationType"> The value which indicates if configuration values are secrets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownConfigurationGroupValuePropertiesFormat(ProvisioningState? provisioningState, string publisherName, PublisherScope? publisherScope, string configurationGroupSchemaName, string configurationGroupSchemaOfferingLocation, DeploymentResourceIdReference configurationGroupSchemaResourceReference, ConfigurationGroupValueConfigurationType configurationType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(provisioningState, publisherName, publisherScope, configurationGroupSchemaName, configurationGroupSchemaOfferingLocation, configurationGroupSchemaResourceReference, configurationType, serializedAdditionalRawData)
        {
            ConfigurationType = configurationType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownConfigurationGroupValuePropertiesFormat"/> for deserialization. </summary>
        internal UnknownConfigurationGroupValuePropertiesFormat()
        {
        }
    }
}
