// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20201101.Inputs
{

    /// <summary>
    /// Properties of VPN client root certificate of VpnServerConfiguration.
    /// </summary>
    public sealed class VpnServerConfigVpnClientRootCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The certificate name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The certificate public data.
        /// </summary>
        [Input("publicCertData")]
        public Input<string>? PublicCertData { get; set; }

        public VpnServerConfigVpnClientRootCertificateArgs()
        {
        }
    }
}
