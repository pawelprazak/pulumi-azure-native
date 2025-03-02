// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Devices.V20171115.Outputs
{

    /// <summary>
    /// The description of an X509 CA Certificate.
    /// </summary>
    [OutputType]
    public sealed class CertificatePropertiesResponse
    {
        /// <summary>
        /// The certificate's creation date and time.
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// The certificate's expiration date and time.
        /// </summary>
        public readonly string Expiry;
        /// <summary>
        /// Determines whether certificate has been verified.
        /// </summary>
        public readonly bool IsVerified;
        /// <summary>
        /// The certificate's subject name.
        /// </summary>
        public readonly string Subject;
        /// <summary>
        /// The certificate's thumbprint.
        /// </summary>
        public readonly string Thumbprint;
        /// <summary>
        /// The certificate's last update date and time.
        /// </summary>
        public readonly string Updated;

        [OutputConstructor]
        private CertificatePropertiesResponse(
            string created,

            string expiry,

            bool isVerified,

            string subject,

            string thumbprint,

            string updated)
        {
            Created = created;
            Expiry = expiry;
            IsVerified = isVerified;
            Subject = subject;
            Thumbprint = thumbprint;
            Updated = updated;
        }
    }
}
