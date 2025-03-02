// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Kusto.V20200215.Inputs
{

    /// <summary>
    /// A class that contains virtual network definition.
    /// </summary>
    public sealed class VirtualNetworkConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Data management's service public IP address resource id.
        /// </summary>
        [Input("dataManagementPublicIpId", required: true)]
        public Input<string> DataManagementPublicIpId { get; set; } = null!;

        /// <summary>
        /// Engine service's public IP address resource id.
        /// </summary>
        [Input("enginePublicIpId", required: true)]
        public Input<string> EnginePublicIpId { get; set; } = null!;

        /// <summary>
        /// The subnet resource id.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public VirtualNetworkConfigurationArgs()
        {
        }
    }
}
