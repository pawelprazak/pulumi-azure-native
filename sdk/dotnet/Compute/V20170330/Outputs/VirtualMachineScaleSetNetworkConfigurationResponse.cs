// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20170330.Outputs
{

    /// <summary>
    /// Describes a virtual machine scale set network profile's network configurations.
    /// </summary>
    [OutputType]
    public sealed class VirtualMachineScaleSetNetworkConfigurationResponse
    {
        /// <summary>
        /// The dns settings to be applied on the network interfaces.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetNetworkConfigurationDnsSettingsResponse? DnsSettings;
        /// <summary>
        /// Specifies whether the network interface is accelerated networking-enabled.
        /// </summary>
        public readonly bool? EnableAcceleratedNetworking;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Specifies the IP configurations of the network interface.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualMachineScaleSetIPConfigurationResponse> IpConfigurations;
        /// <summary>
        /// The network configuration name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The network security group.
        /// </summary>
        public readonly Outputs.SubResourceResponse? NetworkSecurityGroup;
        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more than 1 network interface.
        /// </summary>
        public readonly bool? Primary;

        [OutputConstructor]
        private VirtualMachineScaleSetNetworkConfigurationResponse(
            Outputs.VirtualMachineScaleSetNetworkConfigurationDnsSettingsResponse? dnsSettings,

            bool? enableAcceleratedNetworking,

            string? id,

            ImmutableArray<Outputs.VirtualMachineScaleSetIPConfigurationResponse> ipConfigurations,

            string name,

            Outputs.SubResourceResponse? networkSecurityGroup,

            bool? primary)
        {
            DnsSettings = dnsSettings;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            Id = id;
            IpConfigurations = ipConfigurations;
            Name = name;
            NetworkSecurityGroup = networkSecurityGroup;
            Primary = primary;
        }
    }
}
