// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MobileNetwork.V20220301Preview.Outputs
{

    /// <summary>
    /// Expiry times of inactive NAPT pinholes, in seconds. All timers must be at least 1 second.
    /// </summary>
    [OutputType]
    public sealed class PinholeTimeoutsResponse
    {
        /// <summary>
        /// Pinhole timeout for ICMP pinholes in seconds. Default for ICMP Echo is 60 seconds per RFC 5508 section 3.2.
        /// </summary>
        public readonly int? Icmp;
        /// <summary>
        /// Pinhole timeout for TCP pinholes in seconds. Default for TCP is 2 hours 4 minutes per RFC 5382 section 5.
        /// </summary>
        public readonly int? Tcp;
        /// <summary>
        /// Pinhole timeout for UDP pinholes in seconds. Default for UDP is 5 minutes per RFC 4787 section 4.3.
        /// </summary>
        public readonly int? Udp;

        [OutputConstructor]
        private PinholeTimeoutsResponse(
            int? icmp,

            int? tcp,

            int? udp)
        {
            Icmp = icmp;
            Tcp = tcp;
            Udp = udp;
        }
    }
}
