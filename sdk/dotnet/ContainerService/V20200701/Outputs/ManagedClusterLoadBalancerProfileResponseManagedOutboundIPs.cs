// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20200701.Outputs
{

    /// <summary>
    /// Desired managed outbound IPs for the cluster load balancer.
    /// </summary>
    [OutputType]
    public sealed class ManagedClusterLoadBalancerProfileResponseManagedOutboundIPs
    {
        /// <summary>
        /// Desired number of outbound IP created/managed by Azure for the cluster load balancer. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. 
        /// </summary>
        public readonly int? Count;

        [OutputConstructor]
        private ManagedClusterLoadBalancerProfileResponseManagedOutboundIPs(int? count)
        {
            Count = count;
        }
    }
}
