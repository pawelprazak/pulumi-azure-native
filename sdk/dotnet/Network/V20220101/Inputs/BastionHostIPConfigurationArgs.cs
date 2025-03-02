// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20220101.Inputs
{

    /// <summary>
    /// IP configuration of an Bastion Host.
    /// </summary>
    public sealed class BastionHostIPConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Private IP allocation method.
        /// </summary>
        [Input("privateIPAllocationMethod")]
        public InputUnion<string, Pulumi.AzureNative.Network.V20220101.IPAllocationMethod>? PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Reference of the PublicIP resource.
        /// </summary>
        [Input("publicIPAddress", required: true)]
        public Input<Inputs.SubResourceArgs> PublicIPAddress { get; set; } = null!;

        /// <summary>
        /// Reference of the subnet resource.
        /// </summary>
        [Input("subnet", required: true)]
        public Input<Inputs.SubResourceArgs> Subnet { get; set; } = null!;

        public BastionHostIPConfigurationArgs()
        {
        }
    }
}
