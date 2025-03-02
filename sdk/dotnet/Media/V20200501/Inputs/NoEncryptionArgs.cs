// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20200501.Inputs
{

    /// <summary>
    /// Class for NoEncryption scheme
    /// </summary>
    public sealed class NoEncryptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Representing supported protocols
        /// </summary>
        [Input("enabledProtocols")]
        public Input<Inputs.EnabledProtocolsArgs>? EnabledProtocols { get; set; }

        public NoEncryptionArgs()
        {
        }
    }
}
