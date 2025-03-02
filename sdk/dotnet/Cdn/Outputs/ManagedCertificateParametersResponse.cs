// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.Outputs
{

    /// <summary>
    /// Managed Certificate used for https
    /// </summary>
    [OutputType]
    public sealed class ManagedCertificateParametersResponse
    {
        /// <summary>
        /// The type of the Secret to create.
        /// Expected value is 'ManagedCertificate'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ManagedCertificateParametersResponse(string type)
        {
            Type = type;
        }
    }
}
