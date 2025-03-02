// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Batch.V20190401.Inputs
{

    public sealed class NetworkSecurityGroupRuleArgs : Pulumi.ResourceArgs
    {
        [Input("access", required: true)]
        public Input<Pulumi.AzureNative.Batch.V20190401.NetworkSecurityGroupRuleAccess> Access { get; set; } = null!;

        /// <summary>
        /// Priorities within a pool must be unique and are evaluated in order of priority. The lower the number the higher the priority. For example, rules could be specified with order numbers of 150, 250, and 350. The rule with the order number of 150 takes precedence over the rule that has an order of 250. Allowed priorities are 150 to 3500. If any reserved or duplicate values are provided the request fails with HTTP status code 400.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        /// <summary>
        /// Valid values are a single IP address (i.e. 10.10.10.10), IP subnet (i.e. 192.168.1.0/24), default tag, or * (for all addresses).  If any other values are provided the request fails with HTTP status code 400.
        /// </summary>
        [Input("sourceAddressPrefix", required: true)]
        public Input<string> SourceAddressPrefix { get; set; } = null!;

        public NetworkSecurityGroupRuleArgs()
        {
        }
    }
}
