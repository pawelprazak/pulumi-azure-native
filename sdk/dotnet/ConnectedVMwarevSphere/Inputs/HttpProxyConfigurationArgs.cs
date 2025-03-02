// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs
{

    /// <summary>
    /// HTTP Proxy configuration for the VM.
    /// </summary>
    public sealed class HttpProxyConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets httpsProxy url.
        /// </summary>
        [Input("httpsProxy")]
        public Input<string>? HttpsProxy { get; set; }

        public HttpProxyConfigurationArgs()
        {
        }
    }
}
