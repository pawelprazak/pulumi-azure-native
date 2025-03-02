// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNative.Dashboard.V20210901Preview
{
    [EnumType]
    public readonly struct AutoGeneratedDomainNameLabelScope : IEquatable<AutoGeneratedDomainNameLabelScope>
    {
        private readonly string _value;

        private AutoGeneratedDomainNameLabelScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static AutoGeneratedDomainNameLabelScope TenantReuse { get; } = new AutoGeneratedDomainNameLabelScope("TenantReuse");

        public static bool operator ==(AutoGeneratedDomainNameLabelScope left, AutoGeneratedDomainNameLabelScope right) => left.Equals(right);
        public static bool operator !=(AutoGeneratedDomainNameLabelScope left, AutoGeneratedDomainNameLabelScope right) => !left.Equals(right);

        public static explicit operator string(AutoGeneratedDomainNameLabelScope value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AutoGeneratedDomainNameLabelScope other && Equals(other);
        public bool Equals(AutoGeneratedDomainNameLabelScope other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities. The type 'None' will remove any identities from the resource.
    /// </summary>
    [EnumType]
    public readonly struct IdentityType : IEquatable<IdentityType>
    {
        private readonly string _value;

        private IdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static IdentityType None { get; } = new IdentityType("None");
        public static IdentityType SystemAssigned { get; } = new IdentityType("SystemAssigned");

        public static bool operator ==(IdentityType left, IdentityType right) => left.Equals(right);
        public static bool operator !=(IdentityType left, IdentityType right) => !left.Equals(right);

        public static explicit operator string(IdentityType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is IdentityType other && Equals(other);
        public bool Equals(IdentityType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Provisioning state of the resource.
    /// </summary>
    [EnumType]
    public readonly struct ProvisioningState : IEquatable<ProvisioningState>
    {
        private readonly string _value;

        private ProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ProvisioningState Accepted { get; } = new ProvisioningState("Accepted");
        public static ProvisioningState Creating { get; } = new ProvisioningState("Creating");
        public static ProvisioningState Updating { get; } = new ProvisioningState("Updating");
        public static ProvisioningState Deleting { get; } = new ProvisioningState("Deleting");
        public static ProvisioningState Succeeded { get; } = new ProvisioningState("Succeeded");
        public static ProvisioningState Failed { get; } = new ProvisioningState("Failed");
        public static ProvisioningState Canceled { get; } = new ProvisioningState("Canceled");
        public static ProvisioningState Deleted { get; } = new ProvisioningState("Deleted");
        public static ProvisioningState NotSpecified { get; } = new ProvisioningState("NotSpecified");

        public static bool operator ==(ProvisioningState left, ProvisioningState right) => left.Equals(right);
        public static bool operator !=(ProvisioningState left, ProvisioningState right) => !left.Equals(right);

        public static explicit operator string(ProvisioningState value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ProvisioningState other && Equals(other);
        public bool Equals(ProvisioningState other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct ZoneRedundancy : IEquatable<ZoneRedundancy>
    {
        private readonly string _value;

        private ZoneRedundancy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ZoneRedundancy Disabled { get; } = new ZoneRedundancy("Disabled");
        public static ZoneRedundancy Enabled { get; } = new ZoneRedundancy("Enabled");

        public static bool operator ==(ZoneRedundancy left, ZoneRedundancy right) => left.Equals(right);
        public static bool operator !=(ZoneRedundancy left, ZoneRedundancy right) => !left.Equals(right);

        public static explicit operator string(ZoneRedundancy value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ZoneRedundancy other && Equals(other);
        public bool Equals(ZoneRedundancy other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
