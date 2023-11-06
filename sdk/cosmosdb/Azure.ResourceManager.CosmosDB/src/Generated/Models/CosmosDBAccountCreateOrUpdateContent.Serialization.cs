// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConsistencyPolicy))
            {
                writer.WritePropertyName("consistencyPolicy"u8);
                writer.WriteObjectValue(ConsistencyPolicy);
            }
            writer.WritePropertyName("locations"u8);
            writer.WriteStartArray();
            foreach (var item in Locations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("databaseAccountOfferType"u8);
            writer.WriteStringValue(DatabaseAccountOfferType.ToString());
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsVirtualNetworkFilterEnabled))
            {
                writer.WritePropertyName("isVirtualNetworkFilterEnabled"u8);
                writer.WriteBooleanValue(IsVirtualNetworkFilterEnabled.Value);
            }
            if (Optional.IsDefined(EnableAutomaticFailover))
            {
                writer.WritePropertyName("enableAutomaticFailover"u8);
                writer.WriteBooleanValue(EnableAutomaticFailover.Value);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableMultipleWriteLocations))
            {
                writer.WritePropertyName("enableMultipleWriteLocations"u8);
                writer.WriteBooleanValue(EnableMultipleWriteLocations.Value);
            }
            if (Optional.IsDefined(EnableCassandraConnector))
            {
                writer.WritePropertyName("enableCassandraConnector"u8);
                writer.WriteBooleanValue(EnableCassandraConnector.Value);
            }
            if (Optional.IsDefined(ConnectorOffer))
            {
                writer.WritePropertyName("connectorOffer"u8);
                writer.WriteStringValue(ConnectorOffer.Value.ToString());
            }
            if (Optional.IsDefined(DisableKeyBasedMetadataWriteAccess))
            {
                writer.WritePropertyName("disableKeyBasedMetadataWriteAccess"u8);
                writer.WriteBooleanValue(DisableKeyBasedMetadataWriteAccess.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri"u8);
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DefaultIdentity))
            {
                writer.WritePropertyName("defaultIdentity"u8);
                writer.WriteStringValue(DefaultIdentity);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(IsFreeTierEnabled))
            {
                writer.WritePropertyName("enableFreeTier"u8);
                writer.WriteBooleanValue(IsFreeTierEnabled.Value);
            }
            if (Optional.IsDefined(ApiProperties))
            {
                writer.WritePropertyName("apiProperties"u8);
                writer.WriteObjectValue(ApiProperties);
            }
            if (Optional.IsDefined(IsAnalyticalStorageEnabled))
            {
                writer.WritePropertyName("enableAnalyticalStorage"u8);
                writer.WriteBooleanValue(IsAnalyticalStorageEnabled.Value);
            }
            if (Optional.IsDefined(AnalyticalStorageConfiguration))
            {
                writer.WritePropertyName("analyticalStorageConfiguration"u8);
                writer.WriteObjectValue(AnalyticalStorageConfiguration);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(BackupPolicy))
            {
                writer.WritePropertyName("backupPolicy"u8);
                writer.WriteObjectValue(BackupPolicy);
            }
            if (Optional.IsCollectionDefined(Cors))
            {
                writer.WritePropertyName("cors"u8);
                writer.WriteStartArray();
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkAclBypass))
            {
                writer.WritePropertyName("networkAclBypass"u8);
                writer.WriteStringValue(NetworkAclBypass.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(NetworkAclBypassResourceIds))
            {
                writer.WritePropertyName("networkAclBypassResourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkAclBypassResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiagnosticLogSettings))
            {
                writer.WritePropertyName("diagnosticLogSettings"u8);
                writer.WriteObjectValue(DiagnosticLogSettings);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
            }
            if (Optional.IsDefined(EnableMaterializedViews))
            {
                writer.WritePropertyName("enableMaterializedViews"u8);
                writer.WriteBooleanValue(EnableMaterializedViews.Value);
            }
            if (Optional.IsDefined(EnablePartitionMerge))
            {
                writer.WritePropertyName("enablePartitionMerge"u8);
                writer.WriteBooleanValue(EnablePartitionMerge.Value);
            }
            if (Optional.IsDefined(EnableBurstCapacity))
            {
                writer.WritePropertyName("enableBurstCapacity"u8);
                writer.WriteBooleanValue(EnableBurstCapacity.Value);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(CustomerManagedKeyStatus))
            {
                writer.WritePropertyName("customerManagedKeyStatus"u8);
                writer.WriteStringValue(CustomerManagedKeyStatus.Value.ToString());
            }
            if (Optional.IsDefined(EnablePriorityBasedExecution))
            {
                writer.WritePropertyName("enablePriorityBasedExecution"u8);
                writer.WriteBooleanValue(EnablePriorityBasedExecution.Value);
            }
            if (Optional.IsDefined(DefaultPriorityLevel))
            {
                writer.WritePropertyName("defaultPriorityLevel"u8);
                writer.WriteStringValue(DefaultPriorityLevel.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CosmosDBAccountCreateOrUpdateContent DeserializeCosmosDBAccountCreateOrUpdateContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CosmosDBAccountKind> kind = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ConsistencyPolicy> consistencyPolicy = default;
            IList<CosmosDBAccountLocation> locations = default;
            CosmosDBAccountOfferType databaseAccountOfferType = default;
            Optional<IList<CosmosDBIPAddressOrRange>> ipRules = default;
            Optional<bool> isVirtualNetworkFilterEnabled = default;
            Optional<bool> enableAutomaticFailover = default;
            Optional<IList<CosmosDBAccountCapability>> capabilities = default;
            Optional<IList<CosmosDBVirtualNetworkRule>> virtualNetworkRules = default;
            Optional<bool> enableMultipleWriteLocations = default;
            Optional<bool> enableCassandraConnector = default;
            Optional<ConnectorOffer> connectorOffer = default;
            Optional<bool> disableKeyBasedMetadataWriteAccess = default;
            Optional<Uri> keyVaultKeyUri = default;
            Optional<string> defaultIdentity = default;
            Optional<CosmosDBPublicNetworkAccess> publicNetworkAccess = default;
            Optional<bool> enableFreeTier = default;
            Optional<ApiProperties> apiProperties = default;
            Optional<bool> enableAnalyticalStorage = default;
            Optional<AnalyticalStorageConfiguration> analyticalStorageConfiguration = default;
            Optional<CosmosDBAccountCreateMode> createMode = default;
            Optional<CosmosDBAccountBackupPolicy> backupPolicy = default;
            Optional<IList<CosmosDBAccountCorsPolicy>> cors = default;
            Optional<NetworkAclBypass> networkAclBypass = default;
            Optional<IList<ResourceIdentifier>> networkAclBypassResourceIds = default;
            Optional<DiagnosticLogSettings> diagnosticLogSettings = default;
            Optional<bool> disableLocalAuth = default;
            Optional<CosmosDBAccountRestoreParameters> restoreParameters = default;
            Optional<CosmosDBAccountCapacity> capacity = default;
            Optional<bool> enableMaterializedViews = default;
            Optional<DatabaseAccountKeysMetadata> keysMetadata = default;
            Optional<bool> enablePartitionMerge = default;
            Optional<bool> enableBurstCapacity = default;
            Optional<CosmosDBMinimalTlsVersion> minimalTlsVersion = default;
            Optional<CustomerManagedKeyStatus> customerManagedKeyStatus = default;
            Optional<bool> enablePriorityBasedExecution = default;
            Optional<DefaultPriorityLevel> defaultPriorityLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new CosmosDBAccountKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("consistencyPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            consistencyPolicy = ConsistencyPolicy.DeserializeConsistencyPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("locations"u8))
                        {
                            List<CosmosDBAccountLocation> array = new List<CosmosDBAccountLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountLocation.DeserializeCosmosDBAccountLocation(item));
                            }
                            locations = array;
                            continue;
                        }
                        if (property0.NameEquals("databaseAccountOfferType"u8))
                        {
                            databaseAccountOfferType = new CosmosDBAccountOfferType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBIPAddressOrRange> array = new List<CosmosDBIPAddressOrRange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBIPAddressOrRange.DeserializeCosmosDBIPAddressOrRange(item));
                            }
                            ipRules = array;
                            continue;
                        }
                        if (property0.NameEquals("isVirtualNetworkFilterEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isVirtualNetworkFilterEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAutomaticFailover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAutomaticFailover = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountCapability> array = new List<CosmosDBAccountCapability>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountCapability.DeserializeCosmosDBAccountCapability(item));
                            }
                            capabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBVirtualNetworkRule> array = new List<CosmosDBVirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBVirtualNetworkRule.DeserializeCosmosDBVirtualNetworkRule(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("enableMultipleWriteLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableMultipleWriteLocations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableCassandraConnector"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableCassandraConnector = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("connectorOffer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectorOffer = new ConnectorOffer(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disableKeyBasedMetadataWriteAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableKeyBasedMetadataWriteAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultKeyUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultKeyUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultIdentity"u8))
                        {
                            defaultIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new CosmosDBPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableFreeTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableFreeTier = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiProperties = ApiProperties.DeserializeApiProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableAnalyticalStorage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAnalyticalStorage = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("analyticalStorageConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            analyticalStorageConfiguration = AnalyticalStorageConfiguration.DeserializeAnalyticalStorageConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = new CosmosDBAccountCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("backupPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupPolicy = CosmosDBAccountBackupPolicy.DeserializeCosmosDBAccountBackupPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountCorsPolicy> array = new List<CosmosDBAccountCorsPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountCorsPolicy.DeserializeCosmosDBAccountCorsPolicy(item));
                            }
                            cors = array;
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypass"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAclBypass = property0.Value.GetString().ToNetworkAclBypass();
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypassResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            networkAclBypassResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("diagnosticLogSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticLogSettings = DiagnosticLogSettings.DeserializeDiagnosticLogSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("restoreParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restoreParameters = CosmosDBAccountRestoreParameters.DeserializeCosmosDBAccountRestoreParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacity = CosmosDBAccountCapacity.DeserializeCosmosDBAccountCapacity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableMaterializedViews"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableMaterializedViews = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keysMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keysMetadata = DatabaseAccountKeysMetadata.DeserializeDatabaseAccountKeysMetadata(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enablePartitionMerge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePartitionMerge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableBurstCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBurstCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minimalTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimalTlsVersion = new CosmosDBMinimalTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerManagedKeyStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerManagedKeyStatus = new CustomerManagedKeyStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enablePriorityBasedExecution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePriorityBasedExecution = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultPriorityLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultPriorityLevel = new DefaultPriorityLevel(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CosmosDBAccountCreateOrUpdateContent(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(kind), consistencyPolicy.Value, locations, databaseAccountOfferType, Optional.ToList(ipRules), Optional.ToNullable(isVirtualNetworkFilterEnabled), Optional.ToNullable(enableAutomaticFailover), Optional.ToList(capabilities), Optional.ToList(virtualNetworkRules), Optional.ToNullable(enableMultipleWriteLocations), Optional.ToNullable(enableCassandraConnector), Optional.ToNullable(connectorOffer), Optional.ToNullable(disableKeyBasedMetadataWriteAccess), keyVaultKeyUri.Value, defaultIdentity.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(enableFreeTier), apiProperties.Value, Optional.ToNullable(enableAnalyticalStorage), analyticalStorageConfiguration.Value, Optional.ToNullable(createMode), backupPolicy.Value, Optional.ToList(cors), Optional.ToNullable(networkAclBypass), Optional.ToList(networkAclBypassResourceIds), diagnosticLogSettings.Value, Optional.ToNullable(disableLocalAuth), restoreParameters.Value, capacity.Value, Optional.ToNullable(enableMaterializedViews), keysMetadata.Value, Optional.ToNullable(enablePartitionMerge), Optional.ToNullable(enableBurstCapacity), Optional.ToNullable(minimalTlsVersion), Optional.ToNullable(customerManagedKeyStatus), Optional.ToNullable(enablePriorityBasedExecution), Optional.ToNullable(defaultPriorityLevel), identity);
        }
    }
}
