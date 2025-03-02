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
    /// AzureFirewall NAT Rule Collection Action.
    /// </summary>
    public sealed class AzureFirewallNatRCActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of action.
        /// </summary>
        [Input("type")]
        public InputUnion<string, Pulumi.AzureNative.Network.V20220101.AzureFirewallNatRCActionType>? Type { get; set; }

        public AzureFirewallNatRCActionArgs()
        {
        }
    }
}
