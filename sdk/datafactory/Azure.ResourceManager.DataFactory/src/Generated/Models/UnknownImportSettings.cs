// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownImportSettings. </summary>
    internal partial class UnknownImportSettings : ImportSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownImportSettings"/>. </summary>
        /// <param name="importSettingsType"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownImportSettings(string importSettingsType, IDictionary<string, BinaryData> additionalProperties) : base(importSettingsType, additionalProperties)
        {
            ImportSettingsType = importSettingsType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownImportSettings"/> for deserialization. </summary>
        internal UnknownImportSettings()
        {
        }
    }
}
