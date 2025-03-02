// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNative.Synapse.V20200401Preview
{
    /// <summary>
    /// The storage redundancy of the database.
    /// </summary>
    [EnumType]
    public readonly struct StorageRedundancy : IEquatable<StorageRedundancy>
    {
        private readonly string _value;

        private StorageRedundancy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static StorageRedundancy Local { get; } = new StorageRedundancy("Local");
        public static StorageRedundancy Geo { get; } = new StorageRedundancy("Geo");
        public static StorageRedundancy Zone { get; } = new StorageRedundancy("Zone");
        public static StorageRedundancy GeoZone { get; } = new StorageRedundancy("GeoZone");

        public static bool operator ==(StorageRedundancy left, StorageRedundancy right) => left.Equals(right);
        public static bool operator !=(StorageRedundancy left, StorageRedundancy right) => !left.Equals(right);

        public static explicit operator string(StorageRedundancy value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is StorageRedundancy other && Equals(other);
        public bool Equals(StorageRedundancy other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
