// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class ScalingPlanPersonalScheduleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RampUpStartTime))
            {
                writer.WritePropertyName("rampUpStartTime"u8);
                writer.WriteObjectValue(RampUpStartTime);
            }
            if (Optional.IsDefined(RampUpAutoStartHosts))
            {
                writer.WritePropertyName("rampUpAutoStartHosts"u8);
                writer.WriteStringValue(RampUpAutoStartHosts.Value.ToString());
            }
            if (Optional.IsDefined(RampUpStartVmOnConnect))
            {
                writer.WritePropertyName("rampUpStartVMOnConnect"u8);
                writer.WriteStringValue(RampUpStartVmOnConnect.Value.ToString());
            }
            if (Optional.IsDefined(RampUpActionOnDisconnect))
            {
                writer.WritePropertyName("rampUpActionOnDisconnect"u8);
                writer.WriteStringValue(RampUpActionOnDisconnect.Value.ToString());
            }
            if (Optional.IsDefined(RampUpMinutesToWaitOnDisconnect))
            {
                writer.WritePropertyName("rampUpMinutesToWaitOnDisconnect"u8);
                writer.WriteNumberValue(RampUpMinutesToWaitOnDisconnect.Value);
            }
            if (Optional.IsDefined(RampUpActionOnLogoff))
            {
                writer.WritePropertyName("rampUpActionOnLogoff"u8);
                writer.WriteStringValue(RampUpActionOnLogoff.Value.ToString());
            }
            if (Optional.IsDefined(RampUpMinutesToWaitOnLogoff))
            {
                writer.WritePropertyName("rampUpMinutesToWaitOnLogoff"u8);
                writer.WriteNumberValue(RampUpMinutesToWaitOnLogoff.Value);
            }
            if (Optional.IsDefined(PeakStartTime))
            {
                writer.WritePropertyName("peakStartTime"u8);
                writer.WriteObjectValue(PeakStartTime);
            }
            if (Optional.IsDefined(PeakStartVmOnConnect))
            {
                writer.WritePropertyName("peakStartVMOnConnect"u8);
                writer.WriteStringValue(PeakStartVmOnConnect.Value.ToString());
            }
            if (Optional.IsDefined(PeakActionOnDisconnect))
            {
                writer.WritePropertyName("peakActionOnDisconnect"u8);
                writer.WriteStringValue(PeakActionOnDisconnect.Value.ToString());
            }
            if (Optional.IsDefined(PeakMinutesToWaitOnDisconnect))
            {
                writer.WritePropertyName("peakMinutesToWaitOnDisconnect"u8);
                writer.WriteNumberValue(PeakMinutesToWaitOnDisconnect.Value);
            }
            if (Optional.IsDefined(PeakActionOnLogoff))
            {
                writer.WritePropertyName("peakActionOnLogoff"u8);
                writer.WriteStringValue(PeakActionOnLogoff.Value.ToString());
            }
            if (Optional.IsDefined(PeakMinutesToWaitOnLogoff))
            {
                writer.WritePropertyName("peakMinutesToWaitOnLogoff"u8);
                writer.WriteNumberValue(PeakMinutesToWaitOnLogoff.Value);
            }
            if (Optional.IsDefined(RampDownStartTime))
            {
                writer.WritePropertyName("rampDownStartTime"u8);
                writer.WriteObjectValue(RampDownStartTime);
            }
            if (Optional.IsDefined(RampDownStartVmOnConnect))
            {
                writer.WritePropertyName("rampDownStartVMOnConnect"u8);
                writer.WriteStringValue(RampDownStartVmOnConnect.Value.ToString());
            }
            if (Optional.IsDefined(RampDownActionOnDisconnect))
            {
                writer.WritePropertyName("rampDownActionOnDisconnect"u8);
                writer.WriteStringValue(RampDownActionOnDisconnect.Value.ToString());
            }
            if (Optional.IsDefined(RampDownMinutesToWaitOnDisconnect))
            {
                writer.WritePropertyName("rampDownMinutesToWaitOnDisconnect"u8);
                writer.WriteNumberValue(RampDownMinutesToWaitOnDisconnect.Value);
            }
            if (Optional.IsDefined(RampDownActionOnLogoff))
            {
                writer.WritePropertyName("rampDownActionOnLogoff"u8);
                writer.WriteStringValue(RampDownActionOnLogoff.Value.ToString());
            }
            if (Optional.IsDefined(RampDownMinutesToWaitOnLogoff))
            {
                writer.WritePropertyName("rampDownMinutesToWaitOnLogoff"u8);
                writer.WriteNumberValue(RampDownMinutesToWaitOnLogoff.Value);
            }
            if (Optional.IsDefined(OffPeakStartTime))
            {
                writer.WritePropertyName("offPeakStartTime"u8);
                writer.WriteObjectValue(OffPeakStartTime);
            }
            if (Optional.IsDefined(OffPeakStartVmOnConnect))
            {
                writer.WritePropertyName("offPeakStartVMOnConnect"u8);
                writer.WriteStringValue(OffPeakStartVmOnConnect.Value.ToString());
            }
            if (Optional.IsDefined(OffPeakActionOnDisconnect))
            {
                writer.WritePropertyName("offPeakActionOnDisconnect"u8);
                writer.WriteStringValue(OffPeakActionOnDisconnect.Value.ToString());
            }
            if (Optional.IsDefined(OffPeakMinutesToWaitOnDisconnect))
            {
                writer.WritePropertyName("offPeakMinutesToWaitOnDisconnect"u8);
                writer.WriteNumberValue(OffPeakMinutesToWaitOnDisconnect.Value);
            }
            if (Optional.IsDefined(OffPeakActionOnLogoff))
            {
                writer.WritePropertyName("offPeakActionOnLogoff"u8);
                writer.WriteStringValue(OffPeakActionOnLogoff.Value.ToString());
            }
            if (Optional.IsDefined(OffPeakMinutesToWaitOnLogoff))
            {
                writer.WritePropertyName("offPeakMinutesToWaitOnLogoff"u8);
                writer.WriteNumberValue(OffPeakMinutesToWaitOnLogoff.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScalingPlanPersonalScheduleData DeserializeScalingPlanPersonalScheduleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<DesktopVirtualizationDayOfWeek>> daysOfWeek = default;
            Optional<ScalingActionTime> rampUpStartTime = default;
            Optional<StartupBehavior> rampUpAutoStartHosts = default;
            Optional<SetStartVmOnConnect> rampUpStartVmOnConnect = default;
            Optional<SessionHandlingOperation> rampUpActionOnDisconnect = default;
            Optional<int> rampUpMinutesToWaitOnDisconnect = default;
            Optional<SessionHandlingOperation> rampUpActionOnLogoff = default;
            Optional<int> rampUpMinutesToWaitOnLogoff = default;
            Optional<ScalingActionTime> peakStartTime = default;
            Optional<SetStartVmOnConnect> peakStartVmOnConnect = default;
            Optional<SessionHandlingOperation> peakActionOnDisconnect = default;
            Optional<int> peakMinutesToWaitOnDisconnect = default;
            Optional<SessionHandlingOperation> peakActionOnLogoff = default;
            Optional<int> peakMinutesToWaitOnLogoff = default;
            Optional<ScalingActionTime> rampDownStartTime = default;
            Optional<SetStartVmOnConnect> rampDownStartVmOnConnect = default;
            Optional<SessionHandlingOperation> rampDownActionOnDisconnect = default;
            Optional<int> rampDownMinutesToWaitOnDisconnect = default;
            Optional<SessionHandlingOperation> rampDownActionOnLogoff = default;
            Optional<int> rampDownMinutesToWaitOnLogoff = default;
            Optional<ScalingActionTime> offPeakStartTime = default;
            Optional<SetStartVmOnConnect> offPeakStartVmOnConnect = default;
            Optional<SessionHandlingOperation> offPeakActionOnDisconnect = default;
            Optional<int> offPeakMinutesToWaitOnDisconnect = default;
            Optional<SessionHandlingOperation> offPeakActionOnLogoff = default;
            Optional<int> offPeakMinutesToWaitOnLogoff = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("daysOfWeek"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DesktopVirtualizationDayOfWeek> array = new List<DesktopVirtualizationDayOfWeek>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToDesktopVirtualizationDayOfWeek());
                            }
                            daysOfWeek = array;
                            continue;
                        }
                        if (property0.NameEquals("rampUpStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rampUpAutoStartHosts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpAutoStartHosts = new StartupBehavior(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampUpStartVMOnConnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpStartVmOnConnect = new SetStartVmOnConnect(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampUpActionOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpActionOnDisconnect = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampUpMinutesToWaitOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpMinutesToWaitOnDisconnect = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampUpActionOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpActionOnLogoff = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampUpMinutesToWaitOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpMinutesToWaitOnLogoff = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peakStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peakStartVMOnConnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakStartVmOnConnect = new SetStartVmOnConnect(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peakActionOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakActionOnDisconnect = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peakMinutesToWaitOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakMinutesToWaitOnDisconnect = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peakActionOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakActionOnLogoff = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peakMinutesToWaitOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakMinutesToWaitOnLogoff = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rampDownStartVMOnConnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownStartVmOnConnect = new SetStartVmOnConnect(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownActionOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownActionOnDisconnect = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownMinutesToWaitOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownMinutesToWaitOnDisconnect = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownActionOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownActionOnLogoff = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownMinutesToWaitOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownMinutesToWaitOnLogoff = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("offPeakStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("offPeakStartVMOnConnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakStartVmOnConnect = new SetStartVmOnConnect(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offPeakActionOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakActionOnDisconnect = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offPeakMinutesToWaitOnDisconnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakMinutesToWaitOnDisconnect = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("offPeakActionOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakActionOnLogoff = new SessionHandlingOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offPeakMinutesToWaitOnLogoff"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakMinutesToWaitOnLogoff = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScalingPlanPersonalScheduleData(id, name, type, systemData.Value, Optional.ToList(daysOfWeek), rampUpStartTime.Value, Optional.ToNullable(rampUpAutoStartHosts), Optional.ToNullable(rampUpStartVmOnConnect), Optional.ToNullable(rampUpActionOnDisconnect), Optional.ToNullable(rampUpMinutesToWaitOnDisconnect), Optional.ToNullable(rampUpActionOnLogoff), Optional.ToNullable(rampUpMinutesToWaitOnLogoff), peakStartTime.Value, Optional.ToNullable(peakStartVmOnConnect), Optional.ToNullable(peakActionOnDisconnect), Optional.ToNullable(peakMinutesToWaitOnDisconnect), Optional.ToNullable(peakActionOnLogoff), Optional.ToNullable(peakMinutesToWaitOnLogoff), rampDownStartTime.Value, Optional.ToNullable(rampDownStartVmOnConnect), Optional.ToNullable(rampDownActionOnDisconnect), Optional.ToNullable(rampDownMinutesToWaitOnDisconnect), Optional.ToNullable(rampDownActionOnLogoff), Optional.ToNullable(rampDownMinutesToWaitOnLogoff), offPeakStartTime.Value, Optional.ToNullable(offPeakStartVmOnConnect), Optional.ToNullable(offPeakActionOnDisconnect), Optional.ToNullable(offPeakMinutesToWaitOnDisconnect), Optional.ToNullable(offPeakActionOnLogoff), Optional.ToNullable(offPeakMinutesToWaitOnLogoff));
        }
    }
}
