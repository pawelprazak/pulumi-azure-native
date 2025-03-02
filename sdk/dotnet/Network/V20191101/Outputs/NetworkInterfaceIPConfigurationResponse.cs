// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20191101.Outputs
{

    /// <summary>
    /// IPConfiguration in a network interface.
    /// </summary>
    [OutputType]
    public sealed class NetworkInterfaceIPConfigurationResponse
    {
        /// <summary>
        /// The reference to ApplicationGatewayBackendAddressPool resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayBackendAddressPoolResponse> ApplicationGatewayBackendAddressPools;
        /// <summary>
        /// Application security groups in which the IP configuration is included.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSecurityGroupResponse> ApplicationSecurityGroups;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The reference to LoadBalancerBackendAddressPool resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.BackendAddressPoolResponse> LoadBalancerBackendAddressPools;
        /// <summary>
        /// A list of references of LoadBalancerInboundNatRules.
        /// </summary>
        public readonly ImmutableArray<Outputs.InboundNatRuleResponse> LoadBalancerInboundNatRules;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Whether this is a primary customer address on the network interface.
        /// </summary>
        public readonly bool? Primary;
        /// <summary>
        /// Private IP address of the IP configuration.
        /// </summary>
        public readonly string? PrivateIPAddress;
        /// <summary>
        /// Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        public readonly string? PrivateIPAddressVersion;
        /// <summary>
        /// The private IP address allocation method.
        /// </summary>
        public readonly string? PrivateIPAllocationMethod;
        /// <summary>
        /// PrivateLinkConnection properties for the network interface.
        /// </summary>
        public readonly Outputs.NetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesResponse PrivateLinkConnectionProperties;
        /// <summary>
        /// The provisioning state of the network interface IP configuration.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Public IP address bound to the IP configuration.
        /// </summary>
        public readonly Outputs.PublicIPAddressResponse? PublicIPAddress;
        /// <summary>
        /// Subnet bound to the IP configuration.
        /// </summary>
        public readonly Outputs.SubnetResponse? Subnet;
        /// <summary>
        /// The reference to Virtual Network Taps.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualNetworkTapResponse> VirtualNetworkTaps;

        [OutputConstructor]
        private NetworkInterfaceIPConfigurationResponse(
            ImmutableArray<Outputs.ApplicationGatewayBackendAddressPoolResponse> applicationGatewayBackendAddressPools,

            ImmutableArray<Outputs.ApplicationSecurityGroupResponse> applicationSecurityGroups,

            string etag,

            string? id,

            ImmutableArray<Outputs.BackendAddressPoolResponse> loadBalancerBackendAddressPools,

            ImmutableArray<Outputs.InboundNatRuleResponse> loadBalancerInboundNatRules,

            string? name,

            bool? primary,

            string? privateIPAddress,

            string? privateIPAddressVersion,

            string? privateIPAllocationMethod,

            Outputs.NetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesResponse privateLinkConnectionProperties,

            string provisioningState,

            Outputs.PublicIPAddressResponse? publicIPAddress,

            Outputs.SubnetResponse? subnet,

            ImmutableArray<Outputs.VirtualNetworkTapResponse> virtualNetworkTaps)
        {
            ApplicationGatewayBackendAddressPools = applicationGatewayBackendAddressPools;
            ApplicationSecurityGroups = applicationSecurityGroups;
            Etag = etag;
            Id = id;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            LoadBalancerInboundNatRules = loadBalancerInboundNatRules;
            Name = name;
            Primary = primary;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAddressVersion = privateIPAddressVersion;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            PrivateLinkConnectionProperties = privateLinkConnectionProperties;
            ProvisioningState = provisioningState;
            PublicIPAddress = publicIPAddress;
            Subnet = subnet;
            VirtualNetworkTaps = virtualNetworkTaps;
        }
    }
}
