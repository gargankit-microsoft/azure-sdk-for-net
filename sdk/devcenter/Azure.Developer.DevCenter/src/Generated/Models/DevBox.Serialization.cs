// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevBox : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("poolName"u8);
            writer.WriteStringValue(PoolName);
            if (Optional.IsDefined(LocalAdministratorStatus))
            {
                writer.WritePropertyName("localAdministrator"u8);
                writer.WriteStringValue(LocalAdministratorStatus);
            }
            writer.WriteEndObject();
        }

        internal static DevBox DeserializeDevBox(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> projectName = default;
            string poolName = default;
            Optional<HibernateSupport> hibernateSupport = default;
            Optional<DevBoxProvisioningState> provisioningState = default;
            Optional<string> actionState = default;
            PowerState powerState = default;
            Optional<Guid> uniqueId = default;
            Optional<ResponseError> error = default;
            Optional<string> location = default;
            Optional<string> osType = default;
            Optional<Guid> user = default;
            Optional<DevBoxHardwareProfile> hardwareProfile = default;
            Optional<DevBoxStorageProfile> storageProfile = default;
            Optional<DevBoxImageReference> imageReference = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> localAdministrator = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poolName"u8))
                {
                    poolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hibernateSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hibernateSupport = new HibernateSupport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DevBoxProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("actionState"u8))
                {
                    actionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerState"u8))
                {
                    powerState = new PowerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uniqueId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uniqueId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    user = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("hardwareProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareProfile = DevBoxHardwareProfile.DeserializeDevBoxHardwareProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = DevBoxStorageProfile.DeserializeDevBoxStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = DevBoxImageReference.DeserializeDevBoxImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("localAdministrator"u8))
                {
                    localAdministrator = property.Value.GetString();
                    continue;
                }
            }
            return new DevBox(name, projectName.Value, poolName, Optional.ToNullable(hibernateSupport), Optional.ToNullable(provisioningState), actionState.Value, powerState, Optional.ToNullable(uniqueId), error.Value, location.Value, osType.Value, Optional.ToNullable(user), hardwareProfile.Value, storageProfile.Value, imageReference.Value, Optional.ToNullable(createdTime), localAdministrator.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DevBox FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDevBox(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
