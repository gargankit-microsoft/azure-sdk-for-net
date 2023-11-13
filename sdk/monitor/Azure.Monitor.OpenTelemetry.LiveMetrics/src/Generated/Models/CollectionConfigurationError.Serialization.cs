// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class CollectionConfigurationError : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CollectionConfigurationErrorType))
            {
                writer.WritePropertyName("CollectionConfigurationErrorType"u8);
                writer.WriteStringValue(CollectionConfigurationErrorType.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("Message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(FullException))
            {
                writer.WritePropertyName("FullException"u8);
                writer.WriteStringValue(FullException);
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("Data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
