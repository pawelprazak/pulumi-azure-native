// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20151101Preview.Outputs
{

    /// <summary>
    /// Contains information about SSH certificate public key data.
    /// </summary>
    [OutputType]
    public sealed class ContainerServiceSshPublicKeyResponse
    {
        /// <summary>
        /// Gets or sets Certificate public key used to authenticate with VM through SSH. The certificate must be in Pem format with or without headers.
        /// </summary>
        public readonly string KeyData;

        [OutputConstructor]
        private ContainerServiceSshPublicKeyResponse(string keyData)
        {
            KeyData = keyData;
        }
    }
}
