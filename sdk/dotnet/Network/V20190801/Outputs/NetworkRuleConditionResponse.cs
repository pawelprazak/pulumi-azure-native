// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20190801.Outputs
{

    /// <summary>
    /// Rule condition of type network.
    /// </summary>
    [OutputType]
    public sealed class NetworkRuleConditionResponse
    {
        /// <summary>
        /// Description of the rule condition.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// List of destination IP addresses or Service Tags.
        /// </summary>
        public readonly ImmutableArray<string> DestinationAddresses;
        /// <summary>
        /// List of destination ports.
        /// </summary>
        public readonly ImmutableArray<string> DestinationPorts;
        /// <summary>
        /// Array of FirewallPolicyRuleConditionNetworkProtocols.
        /// </summary>
        public readonly ImmutableArray<string> IpProtocols;
        /// <summary>
        /// Name of the rule condition.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Rule Condition Type.
        /// Expected value is 'NetworkRuleCondition'.
        /// </summary>
        public readonly string RuleConditionType;
        /// <summary>
        /// List of source IP addresses for this rule.
        /// </summary>
        public readonly ImmutableArray<string> SourceAddresses;

        [OutputConstructor]
        private NetworkRuleConditionResponse(
            string? description,

            ImmutableArray<string> destinationAddresses,

            ImmutableArray<string> destinationPorts,

            ImmutableArray<string> ipProtocols,

            string? name,

            string ruleConditionType,

            ImmutableArray<string> sourceAddresses)
        {
            Description = description;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            IpProtocols = ipProtocols;
            Name = name;
            RuleConditionType = ruleConditionType;
            SourceAddresses = sourceAddresses;
        }
    }
}
