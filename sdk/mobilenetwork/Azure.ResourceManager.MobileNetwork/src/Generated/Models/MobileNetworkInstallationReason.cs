// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The reason for the installation state of the packet core. </summary>
    public readonly partial struct MobileNetworkInstallationReason : IEquatable<MobileNetworkInstallationReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkInstallationReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkInstallationReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoSlicesValue = "NoSlices";
        private const string NoPacketCoreDataPlaneValue = "NoPacketCoreDataPlane";
        private const string NoAttachedDataNetworksValue = "NoAttachedDataNetworks";

        /// <summary> The mobile network does not have any applicable configured slices. </summary>
        public static MobileNetworkInstallationReason NoSlices { get; } = new MobileNetworkInstallationReason(NoSlicesValue);
        /// <summary> There is no configured data plane for this packet core. </summary>
        public static MobileNetworkInstallationReason NoPacketCoreDataPlane { get; } = new MobileNetworkInstallationReason(NoPacketCoreDataPlaneValue);
        /// <summary> The packet core has no attached data networks. </summary>
        public static MobileNetworkInstallationReason NoAttachedDataNetworks { get; } = new MobileNetworkInstallationReason(NoAttachedDataNetworksValue);
        /// <summary> Determines if two <see cref="MobileNetworkInstallationReason"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkInstallationReason left, MobileNetworkInstallationReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkInstallationReason"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkInstallationReason left, MobileNetworkInstallationReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkInstallationReason"/>. </summary>
        public static implicit operator MobileNetworkInstallationReason(string value) => new MobileNetworkInstallationReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkInstallationReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkInstallationReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
