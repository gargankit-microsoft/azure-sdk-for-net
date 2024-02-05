// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The UnknownAzureResourcePropertiesBase. </summary>
    internal partial class UnknownAzureResourcePropertiesBase : AzureResourceBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAzureResourcePropertiesBase"/>. </summary>
        /// <param name="azureResourceType"> The azure resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAzureResourcePropertiesBase(AzureResourceType azureResourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(azureResourceType, serializedAdditionalRawData)
        {
            AzureResourceType = azureResourceType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAzureResourcePropertiesBase"/> for deserialization. </summary>
        internal UnknownAzureResourcePropertiesBase()
        {
        }
    }
}
