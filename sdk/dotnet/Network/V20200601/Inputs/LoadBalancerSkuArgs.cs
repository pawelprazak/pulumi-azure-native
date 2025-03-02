// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20200601.Inputs
{

    /// <summary>
    /// SKU of a load balancer.
    /// </summary>
    public sealed class LoadBalancerSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of a load balancer SKU.
        /// </summary>
        [Input("name")]
        public InputUnion<string, Pulumi.AzureNative.Network.V20200601.LoadBalancerSkuName>? Name { get; set; }

        public LoadBalancerSkuArgs()
        {
        }
    }
}
