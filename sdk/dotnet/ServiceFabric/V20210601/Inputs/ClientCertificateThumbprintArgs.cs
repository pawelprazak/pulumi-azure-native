// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceFabric.V20210601.Inputs
{

    /// <summary>
    /// Describes the client certificate details using thumbprint.
    /// </summary>
    public sealed class ClientCertificateThumbprintArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The thumbprint of the client certificate.
        /// </summary>
        [Input("certificateThumbprint", required: true)]
        public Input<string> CertificateThumbprint { get; set; } = null!;

        /// <summary>
        /// Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster.
        /// </summary>
        [Input("isAdmin", required: true)]
        public Input<bool> IsAdmin { get; set; } = null!;

        public ClientCertificateThumbprintArgs()
        {
        }
    }
}
