// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20160901.Outputs
{

    /// <summary>
    /// Authentication certificates of an application gateway.
    /// </summary>
    [OutputType]
    public sealed class ApplicationGatewayAuthenticationCertificateResponse
    {
        /// <summary>
        /// Certificate public data.
        /// </summary>
        public readonly string? Data;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Provisioning state of the authentication certificate resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string? ProvisioningState;

        [OutputConstructor]
        private ApplicationGatewayAuthenticationCertificateResponse(
            string? data,

            string? etag,

            string? id,

            string? name,

            string? provisioningState)
        {
            Data = data;
            Etag = etag;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
        }
    }
}
