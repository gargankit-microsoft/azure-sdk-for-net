// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    public partial class TrainingFileFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Prefix != null)
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteStringValue(Prefix);
            }
            writer.WritePropertyName("includeSubFolders"u8);
            writer.WriteBooleanValue(IncludeSubfolders);
            writer.WriteEndObject();
        }
    }
}
