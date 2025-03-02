// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20190401.Outputs
{

    /// <summary>
    /// Frontend IP address of the load balancer.
    /// </summary>
    [OutputType]
    public sealed class FrontendIPConfigurationResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Read only. Inbound pools URIs that use this frontend IP.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> InboundNatPools;
        /// <summary>
        /// Read only. Inbound rules URIs that use this frontend IP.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> InboundNatRules;
        /// <summary>
        /// Gets load balancing rules URIs that use this frontend IP.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> LoadBalancingRules;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Read only. Outbound rules URIs that use this frontend IP.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> OutboundRules;
        /// <summary>
        /// The private IP address of the IP configuration.
        /// </summary>
        public readonly string? PrivateIPAddress;
        /// <summary>
        /// It represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.
        /// </summary>
        public readonly string? PrivateIPAddressVersion;
        /// <summary>
        /// The Private IP allocation method.
        /// </summary>
        public readonly string? PrivateIPAllocationMethod;
        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// The reference of the Public IP resource.
        /// </summary>
        public readonly Outputs.PublicIPAddressResponse? PublicIPAddress;
        /// <summary>
        /// The reference of the Public IP Prefix resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse? PublicIPPrefix;
        /// <summary>
        /// The reference of the subnet resource.
        /// </summary>
        public readonly Outputs.SubnetResponse? Subnet;
        /// <summary>
        /// A list of availability zones denoting the IP allocated for the resource needs to come from.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private FrontendIPConfigurationResponse(
            string? etag,

            string? id,

            ImmutableArray<Outputs.SubResourceResponse> inboundNatPools,

            ImmutableArray<Outputs.SubResourceResponse> inboundNatRules,

            ImmutableArray<Outputs.SubResourceResponse> loadBalancingRules,

            string? name,

            ImmutableArray<Outputs.SubResourceResponse> outboundRules,

            string? privateIPAddress,

            string? privateIPAddressVersion,

            string? privateIPAllocationMethod,

            string? provisioningState,

            Outputs.PublicIPAddressResponse? publicIPAddress,

            Outputs.SubResourceResponse? publicIPPrefix,

            Outputs.SubnetResponse? subnet,

            ImmutableArray<string> zones)
        {
            Etag = etag;
            Id = id;
            InboundNatPools = inboundNatPools;
            InboundNatRules = inboundNatRules;
            LoadBalancingRules = loadBalancingRules;
            Name = name;
            OutboundRules = outboundRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAddressVersion = privateIPAddressVersion;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            ProvisioningState = provisioningState;
            PublicIPAddress = publicIPAddress;
            PublicIPPrefix = publicIPPrefix;
            Subnet = subnet;
            Zones = zones;
        }
    }
}
