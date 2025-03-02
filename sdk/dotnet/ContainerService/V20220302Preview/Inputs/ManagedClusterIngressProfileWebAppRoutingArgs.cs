// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20220302Preview.Inputs
{

    /// <summary>
    /// Web App Routing settings for the ingress profile.
    /// </summary>
    public sealed class ManagedClusterIngressProfileWebAppRoutingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource ID of the DNS Zone to be associated with the web app. Used only when Web App Routing is enabled.
        /// </summary>
        [Input("dnsZoneResourceId")]
        public Input<string>? DnsZoneResourceId { get; set; }

        /// <summary>
        /// Whether to enable Web App Routing.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public ManagedClusterIngressProfileWebAppRoutingArgs()
        {
        }
    }
}
