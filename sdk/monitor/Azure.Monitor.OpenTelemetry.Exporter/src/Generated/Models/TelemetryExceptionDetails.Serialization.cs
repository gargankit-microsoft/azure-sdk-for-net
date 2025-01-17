// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class TelemetryExceptionDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Id.HasValue)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (OuterId.HasValue)
            {
                writer.WritePropertyName("outerId"u8);
                writer.WriteNumberValue(OuterId.Value);
            }
            if (TypeName != null)
            {
                writer.WritePropertyName("typeName"u8);
                writer.WriteStringValue(TypeName);
            }
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
            if (HasFullStack.HasValue)
            {
                writer.WritePropertyName("hasFullStack"u8);
                writer.WriteBooleanValue(HasFullStack.Value);
            }
            if (Stack != null)
            {
                writer.WritePropertyName("stack"u8);
                writer.WriteStringValue(Stack);
            }
            if (!(ParsedStack is ChangeTrackingList<StackFrame> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parsedStack"u8);
                writer.WriteStartArray();
                foreach (var item in ParsedStack)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
