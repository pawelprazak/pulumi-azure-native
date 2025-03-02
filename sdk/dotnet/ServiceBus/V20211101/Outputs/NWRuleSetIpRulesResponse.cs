// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceBus.V20211101.Outputs
{

    /// <summary>
    /// Description of NetWorkRuleSet - IpRules resource.
    /// </summary>
    [OutputType]
    public sealed class NWRuleSetIpRulesResponse
    {
        /// <summary>
        /// The IP Filter Action
        /// </summary>
        public readonly string? Action;
        /// <summary>
        /// IP Mask
        /// </summary>
        public readonly string? IpMask;

        [OutputConstructor]
        private NWRuleSetIpRulesResponse(
            string? action,

            string? ipMask)
        {
            Action = action;
            IpMask = ipMask;
        }
    }
}
