// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNative.ElasticSan.V20211120Preview
{
    /// <summary>
    /// The action of virtual network rule.
    /// </summary>
    [EnumType]
    public readonly struct Action : IEquatable<Action>
    {
        private readonly string _value;

        private Action(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static Action Allow { get; } = new Action("Allow");

        public static bool operator ==(Action left, Action right) => left.Equals(right);
        public static bool operator !=(Action left, Action right) => !left.Equals(right);

        public static explicit operator string(Action value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Action other && Equals(other);
        public bool Equals(Action other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Type of encryption
    /// </summary>
    [EnumType]
    public readonly struct EncryptionType : IEquatable<EncryptionType>
    {
        private readonly string _value;

        private EncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Volume is encrypted at rest with Platform managed key. It is the default encryption type.
        /// </summary>
        public static EncryptionType EncryptionAtRestWithPlatformKey { get; } = new EncryptionType("EncryptionAtRestWithPlatformKey");

        public static bool operator ==(EncryptionType left, EncryptionType right) => left.Equals(right);
        public static bool operator !=(EncryptionType left, EncryptionType right) => !left.Equals(right);

        public static explicit operator string(EncryptionType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is EncryptionType other && Equals(other);
        public bool Equals(EncryptionType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The sku name.
    /// </summary>
    [EnumType]
    public readonly struct Name : IEquatable<Name>
    {
        private readonly string _value;

        private Name(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Premium locally redundant storage
        /// </summary>
        public static Name Premium_LRS { get; } = new Name("Premium_LRS");
        /// <summary>
        /// Premium zone redundant storage
        /// </summary>
        public static Name Premium_ZRS { get; } = new Name("Premium_ZRS");

        public static bool operator ==(Name left, Name right) => left.Equals(right);
        public static bool operator !=(Name left, Name right) => !left.Equals(right);

        public static explicit operator string(Name value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Name other && Equals(other);
        public bool Equals(Name other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Type of storage target
    /// </summary>
    [EnumType]
    public readonly struct StorageTargetType : IEquatable<StorageTargetType>
    {
        private readonly string _value;

        private StorageTargetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static StorageTargetType Iscsi { get; } = new StorageTargetType("Iscsi");
        public static StorageTargetType None { get; } = new StorageTargetType("None");

        public static bool operator ==(StorageTargetType left, StorageTargetType right) => left.Equals(right);
        public static bool operator !=(StorageTargetType left, StorageTargetType right) => !left.Equals(right);

        public static explicit operator string(StorageTargetType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is StorageTargetType other && Equals(other);
        public bool Equals(StorageTargetType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The sku tier.
    /// </summary>
    [EnumType]
    public readonly struct Tier : IEquatable<Tier>
    {
        private readonly string _value;

        private Tier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Premium Tier
        /// </summary>
        public static Tier Premium { get; } = new Tier("Premium");

        public static bool operator ==(Tier left, Tier right) => left.Equals(right);
        public static bool operator !=(Tier left, Tier right) => !left.Equals(right);

        public static explicit operator string(Tier value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Tier other && Equals(other);
        public bool Equals(Tier other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// This enumerates the possible sources of a volume creation.
    /// </summary>
    [EnumType]
    public readonly struct VolumeCreateOption : IEquatable<VolumeCreateOption>
    {
        private readonly string _value;

        private VolumeCreateOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static VolumeCreateOption None { get; } = new VolumeCreateOption("None");

        public static bool operator ==(VolumeCreateOption left, VolumeCreateOption right) => left.Equals(right);
        public static bool operator !=(VolumeCreateOption left, VolumeCreateOption right) => !left.Equals(right);

        public static explicit operator string(VolumeCreateOption value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is VolumeCreateOption other && Equals(other);
        public bool Equals(VolumeCreateOption other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
