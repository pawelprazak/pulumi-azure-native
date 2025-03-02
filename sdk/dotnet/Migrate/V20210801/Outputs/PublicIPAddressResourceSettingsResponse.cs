// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Migrate.V20210801.Outputs
{

    /// <summary>
    /// Defines the public IP address resource settings.
    /// </summary>
    [OutputType]
    public sealed class PublicIPAddressResourceSettingsResponse
    {
        /// <summary>
        /// Gets or sets the domain name label.
        /// </summary>
        public readonly string? DomainNameLabel;
        /// <summary>
        /// Gets or sets the fully qualified domain name.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// Gets or sets public IP allocation method.
        /// </summary>
        public readonly string? PublicIpAllocationMethod;
        /// <summary>
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// Expected value is 'Microsoft.Network/publicIPAddresses'.
        /// </summary>
        public readonly string ResourceType;
        /// <summary>
        /// Gets or sets public IP sku.
        /// </summary>
        public readonly string? Sku;
        /// <summary>
        /// Gets or sets the Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Gets or sets the target Resource name.
        /// </summary>
        public readonly string TargetResourceName;
        /// <summary>
        /// Gets or sets public IP zones.
        /// </summary>
        public readonly string? Zones;

        [OutputConstructor]
        private PublicIPAddressResourceSettingsResponse(
            string? domainNameLabel,

            string? fqdn,

            string? publicIpAllocationMethod,

            string resourceType,

            string? sku,

            ImmutableDictionary<string, string>? tags,

            string targetResourceName,

            string? zones)
        {
            DomainNameLabel = domainNameLabel;
            Fqdn = fqdn;
            PublicIpAllocationMethod = publicIpAllocationMethod;
            ResourceType = resourceType;
            Sku = sku;
            Tags = tags;
            TargetResourceName = targetResourceName;
            Zones = zones;
        }
    }
}
