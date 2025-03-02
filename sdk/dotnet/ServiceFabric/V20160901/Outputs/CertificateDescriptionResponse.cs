// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceFabric.V20160901.Outputs
{

    /// <summary>
    /// Certificate details
    /// </summary>
    [OutputType]
    public sealed class CertificateDescriptionResponse
    {
        /// <summary>
        /// Thumbprint of the primary certificate
        /// </summary>
        public readonly string Thumbprint;
        /// <summary>
        /// Thumbprint of the secondary certificate
        /// </summary>
        public readonly string? ThumbprintSecondary;
        /// <summary>
        /// The local certificate store location
        /// </summary>
        public readonly string? X509StoreName;

        [OutputConstructor]
        private CertificateDescriptionResponse(
            string thumbprint,

            string? thumbprintSecondary,

            string? x509StoreName)
        {
            Thumbprint = thumbprint;
            ThumbprintSecondary = thumbprintSecondary;
            X509StoreName = x509StoreName;
        }
    }
}
