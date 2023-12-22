// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    public partial class BackupRecoveryPointResource : IJsonModel<BackupRecoveryPointData>
    {
        void IJsonModel<BackupRecoveryPointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        BackupRecoveryPointData IJsonModel<BackupRecoveryPointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<BackupRecoveryPointData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<BackupRecoveryPointData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        BackupRecoveryPointData IPersistableModel<BackupRecoveryPointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<BackupRecoveryPointData>(data, options);
        }

        string IPersistableModel<BackupRecoveryPointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
