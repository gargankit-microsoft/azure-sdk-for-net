// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.LargeInstance.Models
{
    /// <summary> Power states that an Azure Large Instance can be in. </summary>
    public readonly partial struct LargeInstancePowerState : IEquatable<LargeInstancePowerState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LargeInstancePowerState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LargeInstancePowerState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartingValue = "starting";
        private const string StartedValue = "started";
        private const string StoppingValue = "stopping";
        private const string StoppedValue = "stopped";
        private const string RestartingValue = "restarting";
        private const string UnknownValue = "unknown";

        /// <summary> Starting means that the Azure Large Instance resource is turning on. </summary>
        public static LargeInstancePowerState Starting { get; } = new LargeInstancePowerState(StartingValue);
        /// <summary> Started means that the Azure Large Instance resource has been powered on. </summary>
        public static LargeInstancePowerState Started { get; } = new LargeInstancePowerState(StartedValue);
        /// <summary> Stopping means that the Azure Large Instance resource is shutting down. </summary>
        public static LargeInstancePowerState Stopping { get; } = new LargeInstancePowerState(StoppingValue);
        /// <summary> Stopped means that the Azure Large Instance resource has shut down. </summary>
        public static LargeInstancePowerState Stopped { get; } = new LargeInstancePowerState(StoppedValue);
        /// <summary> Restarting means that the Azure Large Instance resource is restarting. </summary>
        public static LargeInstancePowerState Restarting { get; } = new LargeInstancePowerState(RestartingValue);
        /// <summary> Unknown means that the state of the Azure Large Instance is unknown. </summary>
        public static LargeInstancePowerState Unknown { get; } = new LargeInstancePowerState(UnknownValue);
        /// <summary> Determines if two <see cref="LargeInstancePowerState"/> values are the same. </summary>
        public static bool operator ==(LargeInstancePowerState left, LargeInstancePowerState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LargeInstancePowerState"/> values are not the same. </summary>
        public static bool operator !=(LargeInstancePowerState left, LargeInstancePowerState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LargeInstancePowerState"/>. </summary>
        public static implicit operator LargeInstancePowerState(string value) => new LargeInstancePowerState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LargeInstancePowerState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LargeInstancePowerState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
