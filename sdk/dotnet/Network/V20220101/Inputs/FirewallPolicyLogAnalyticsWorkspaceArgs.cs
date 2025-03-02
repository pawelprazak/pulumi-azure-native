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
    /// Log Analytics Workspace for Firewall Policy Insights.
    /// </summary>
    public sealed class FirewallPolicyLogAnalyticsWorkspaceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Region to configure the Workspace.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The workspace Id for Firewall Policy Insights.
        /// </summary>
        [Input("workspaceId")]
        public Input<Inputs.SubResourceArgs>? WorkspaceId { get; set; }

        public FirewallPolicyLogAnalyticsWorkspaceArgs()
        {
        }
    }
}
