// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The license status. </summary>
    public readonly partial struct HybridComputeLicenseStatus : IEquatable<HybridComputeLicenseStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridComputeLicenseStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridComputeLicenseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnlicensedValue = "Unlicensed";
        private const string LicensedValue = "Licensed";
        private const string OobGraceValue = "OOBGrace";
        private const string OotGraceValue = "OOTGrace";
        private const string NonGenuineGraceValue = "NonGenuineGrace";
        private const string NotificationValue = "Notification";
        private const string ExtendedGraceValue = "ExtendedGrace";

        /// <summary> Unlicensed. </summary>
        public static HybridComputeLicenseStatus Unlicensed { get; } = new HybridComputeLicenseStatus(UnlicensedValue);
        /// <summary> Licensed. </summary>
        public static HybridComputeLicenseStatus Licensed { get; } = new HybridComputeLicenseStatus(LicensedValue);
        /// <summary> OOBGrace. </summary>
        public static HybridComputeLicenseStatus OobGrace { get; } = new HybridComputeLicenseStatus(OobGraceValue);
        /// <summary> OOTGrace. </summary>
        public static HybridComputeLicenseStatus OotGrace { get; } = new HybridComputeLicenseStatus(OotGraceValue);
        /// <summary> NonGenuineGrace. </summary>
        public static HybridComputeLicenseStatus NonGenuineGrace { get; } = new HybridComputeLicenseStatus(NonGenuineGraceValue);
        /// <summary> Notification. </summary>
        public static HybridComputeLicenseStatus Notification { get; } = new HybridComputeLicenseStatus(NotificationValue);
        /// <summary> ExtendedGrace. </summary>
        public static HybridComputeLicenseStatus ExtendedGrace { get; } = new HybridComputeLicenseStatus(ExtendedGraceValue);
        /// <summary> Determines if two <see cref="HybridComputeLicenseStatus"/> values are the same. </summary>
        public static bool operator ==(HybridComputeLicenseStatus left, HybridComputeLicenseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridComputeLicenseStatus"/> values are not the same. </summary>
        public static bool operator !=(HybridComputeLicenseStatus left, HybridComputeLicenseStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HybridComputeLicenseStatus"/>. </summary>
        public static implicit operator HybridComputeLicenseStatus(string value) => new HybridComputeLicenseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridComputeLicenseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridComputeLicenseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
