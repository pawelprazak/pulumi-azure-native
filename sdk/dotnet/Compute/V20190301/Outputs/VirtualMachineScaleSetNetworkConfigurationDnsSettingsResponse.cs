// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20190301.Outputs
{

    /// <summary>
    /// Describes a virtual machines scale sets network configuration's DNS settings.
    /// </summary>
    [OutputType]
    public sealed class VirtualMachineScaleSetNetworkConfigurationDnsSettingsResponse
    {
        /// <summary>
        /// List of DNS servers IP addresses
        /// </summary>
        public readonly ImmutableArray<string> DnsServers;

        [OutputConstructor]
        private VirtualMachineScaleSetNetworkConfigurationDnsSettingsResponse(ImmutableArray<string> dnsServers)
        {
            DnsServers = dnsServers;
        }
    }
}
