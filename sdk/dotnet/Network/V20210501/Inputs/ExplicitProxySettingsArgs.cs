// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20210501.Inputs
{

    /// <summary>
    /// Explicit Proxy Settings in Firewall Policy.
    /// </summary>
    public sealed class ExplicitProxySettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// When set to true, explicit proxy mode is enabled.
        /// </summary>
        [Input("enableExplicitProxy")]
        public Input<bool>? EnableExplicitProxy { get; set; }

        /// <summary>
        /// Port number for explicit proxy http protocol, cannot be greater than 64000.
        /// </summary>
        [Input("httpPort")]
        public Input<int>? HttpPort { get; set; }

        /// <summary>
        /// Port number for explicit proxy https protocol, cannot be greater than 64000.
        /// </summary>
        [Input("httpsPort")]
        public Input<int>? HttpsPort { get; set; }

        /// <summary>
        /// SAS URL for PAC file.
        /// </summary>
        [Input("pacFile")]
        public Input<string>? PacFile { get; set; }

        /// <summary>
        /// Port number for firewall to serve PAC file.
        /// </summary>
        [Input("pacFilePort")]
        public Input<int>? PacFilePort { get; set; }

        public ExplicitProxySettingsArgs()
        {
        }
    }
}
