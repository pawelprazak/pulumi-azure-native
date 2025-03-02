// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNative.Security.V20220701Preview
{
    /// <summary>
    /// The application source, what it affects, e.g. Assessments
    /// </summary>
    [EnumType]
    public readonly struct ApplicationSourceResourceType : IEquatable<ApplicationSourceResourceType>
    {
        private readonly string _value;

        private ApplicationSourceResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// The source of the application is assessments
        /// </summary>
        public static ApplicationSourceResourceType Assessments { get; } = new ApplicationSourceResourceType("Assessments");

        public static bool operator ==(ApplicationSourceResourceType left, ApplicationSourceResourceType right) => left.Equals(right);
        public static bool operator !=(ApplicationSourceResourceType left, ApplicationSourceResourceType right) => !left.Equals(right);

        public static explicit operator string(ApplicationSourceResourceType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ApplicationSourceResourceType other && Equals(other);
        public bool Equals(ApplicationSourceResourceType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
