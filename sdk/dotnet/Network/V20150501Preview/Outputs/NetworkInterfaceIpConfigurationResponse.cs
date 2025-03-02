// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20150501Preview.Outputs
{

    /// <summary>
    /// IPConfiguration in a NetworkInterface
    /// </summary>
    [OutputType]
    public sealed class NetworkInterfaceIpConfigurationResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Gets or sets the reference of LoadBalancerBackendAddressPool resource
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> LoadBalancerBackendAddressPools;
        /// <summary>
        /// Gets or sets list of references of LoadBalancerInboundNatRules
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> LoadBalancerInboundNatRules;
        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Gets or sets the privateIPAddress of the Network Interface IP Configuration
        /// </summary>
        public readonly string? PrivateIPAddress;
        /// <summary>
        /// Gets or sets PrivateIP allocation method (Static/Dynamic)
        /// </summary>
        public readonly string? PrivateIPAllocationMethod;
        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Gets or sets the reference of the PublicIP resource
        /// </summary>
        public readonly Outputs.SubResourceResponse? PublicIPAddress;
        /// <summary>
        /// Gets or sets the reference of the subnet resource
        /// </summary>
        public readonly Outputs.SubResourceResponse? Subnet;

        [OutputConstructor]
        private NetworkInterfaceIpConfigurationResponse(
            string? etag,

            string? id,

            ImmutableArray<Outputs.SubResourceResponse> loadBalancerBackendAddressPools,

            ImmutableArray<Outputs.SubResourceResponse> loadBalancerInboundNatRules,

            string? name,

            string? privateIPAddress,

            string? privateIPAllocationMethod,

            string? provisioningState,

            Outputs.SubResourceResponse? publicIPAddress,

            Outputs.SubResourceResponse? subnet)
        {
            Etag = etag;
            Id = id;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            LoadBalancerInboundNatRules = loadBalancerInboundNatRules;
            Name = name;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            ProvisioningState = provisioningState;
            PublicIPAddress = publicIPAddress;
            Subnet = subnet;
        }
    }
}
