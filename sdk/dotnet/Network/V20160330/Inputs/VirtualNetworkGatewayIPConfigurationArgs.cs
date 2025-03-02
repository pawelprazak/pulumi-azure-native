// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20160330.Inputs
{

    /// <summary>
    /// IpConfiguration for Virtual network gateway
    /// </summary>
    public sealed class VirtualNetworkGatewayIPConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Gets or sets the privateIPAddress of the IP Configuration
        /// </summary>
        [Input("privateIPAddress")]
        public Input<string>? PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets PrivateIP allocation method (Static/Dynamic)
        /// </summary>
        [Input("privateIPAllocationMethod")]
        public InputUnion<string, Pulumi.AzureNative.Network.V20160330.IPAllocationMethod>? PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the reference of the PublicIP resource
        /// </summary>
        [Input("publicIPAddress")]
        public Input<Inputs.SubResourceArgs>? PublicIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the reference of the subnet resource
        /// </summary>
        [Input("subnet")]
        public Input<Inputs.SubResourceArgs>? Subnet { get; set; }

        public VirtualNetworkGatewayIPConfigurationArgs()
        {
        }
    }
}
