// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20190401.Inputs
{

    /// <summary>
    /// Properties of the network rule.
    /// </summary>
    public sealed class AzureFirewallNetworkRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the rule.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("destinationAddresses")]
        private InputList<string>? _destinationAddresses;

        /// <summary>
        /// List of destination IP addresses.
        /// </summary>
        public InputList<string> DestinationAddresses
        {
            get => _destinationAddresses ?? (_destinationAddresses = new InputList<string>());
            set => _destinationAddresses = value;
        }

        [Input("destinationPorts")]
        private InputList<string>? _destinationPorts;

        /// <summary>
        /// List of destination ports.
        /// </summary>
        public InputList<string> DestinationPorts
        {
            get => _destinationPorts ?? (_destinationPorts = new InputList<string>());
            set => _destinationPorts = value;
        }

        /// <summary>
        /// Name of the network rule.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("protocols")]
        private InputList<Union<string, Pulumi.AzureNative.Network.V20190401.AzureFirewallNetworkRuleProtocol>>? _protocols;

        /// <summary>
        /// Array of AzureFirewallNetworkRuleProtocols.
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.Network.V20190401.AzureFirewallNetworkRuleProtocol>> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<Union<string, Pulumi.AzureNative.Network.V20190401.AzureFirewallNetworkRuleProtocol>>());
            set => _protocols = value;
        }

        [Input("sourceAddresses")]
        private InputList<string>? _sourceAddresses;

        /// <summary>
        /// List of source IP addresses for this rule.
        /// </summary>
        public InputList<string> SourceAddresses
        {
            get => _sourceAddresses ?? (_sourceAddresses = new InputList<string>());
            set => _sourceAddresses = value;
        }

        public AzureFirewallNetworkRuleArgs()
        {
        }
    }
}
