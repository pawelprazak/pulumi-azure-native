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
    /// The VirtualHub Router autoscale configuration.
    /// </summary>
    public sealed class VirtualRouterAutoScaleConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The minimum number of scale units for VirtualHub Router.
        /// </summary>
        [Input("minCapacity")]
        public Input<int>? MinCapacity { get; set; }

        public VirtualRouterAutoScaleConfigurationArgs()
        {
        }
    }
}
