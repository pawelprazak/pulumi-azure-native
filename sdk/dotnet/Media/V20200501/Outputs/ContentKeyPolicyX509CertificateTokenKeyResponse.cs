// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20200501.Outputs
{

    /// <summary>
    /// Specifies a certificate for token validation.
    /// </summary>
    [OutputType]
    public sealed class ContentKeyPolicyX509CertificateTokenKeyResponse
    {
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.ContentKeyPolicyX509CertificateTokenKey'.
        /// </summary>
        public readonly string OdataType;
        /// <summary>
        /// The raw data field of a certificate in PKCS 12 format (X509Certificate2 in .NET)
        /// </summary>
        public readonly string RawBody;

        [OutputConstructor]
        private ContentKeyPolicyX509CertificateTokenKeyResponse(
            string odataType,

            string rawBody)
        {
            OdataType = odataType;
            RawBody = rawBody;
        }
    }
}
