// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20220101.Outputs
{

    /// <summary>
    /// The VirtualHub Router autoscale configuration.
    /// </summary>
    [OutputType]
    public sealed class VirtualRouterAutoScaleConfigurationResponse
    {
        /// <summary>
        /// The minimum number of scale units for VirtualHub Router.
        /// </summary>
        public readonly int? MinCapacity;

        [OutputConstructor]
        private VirtualRouterAutoScaleConfigurationResponse(int? minCapacity)
        {
            MinCapacity = minCapacity;
        }
    }
}
