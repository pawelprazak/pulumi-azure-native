// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorageCache.V20200301.Outputs
{

    /// <summary>
    /// Cache network settings.
    /// </summary>
    [OutputType]
    public sealed class CacheNetworkSettingsResponse
    {
        /// <summary>
        /// The IPv4 maximum transmission unit configured for the subnet.
        /// </summary>
        public readonly int? Mtu;
        /// <summary>
        /// Array of additional IP addresses used by this Cache.
        /// </summary>
        public readonly ImmutableArray<string> UtilityAddresses;

        [OutputConstructor]
        private CacheNetworkSettingsResponse(
            int? mtu,

            ImmutableArray<string> utilityAddresses)
        {
            Mtu = mtu;
            UtilityAddresses = utilityAddresses;
        }
    }
}
