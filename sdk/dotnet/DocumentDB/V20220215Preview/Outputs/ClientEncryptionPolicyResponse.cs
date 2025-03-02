// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB.V20220215Preview.Outputs
{

    /// <summary>
    /// Cosmos DB client encryption policy.
    /// </summary>
    [OutputType]
    public sealed class ClientEncryptionPolicyResponse
    {
        /// <summary>
        /// Paths of the item that need encryption along with path-specific settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClientEncryptionIncludedPathResponse> IncludedPaths;
        /// <summary>
        /// Version of the client encryption policy definition. Please note, user passed value is ignored. Default policy version is 1.
        /// </summary>
        public readonly int? PolicyFormatVersion;

        [OutputConstructor]
        private ClientEncryptionPolicyResponse(
            ImmutableArray<Outputs.ClientEncryptionIncludedPathResponse> includedPaths,

            int? policyFormatVersion)
        {
            IncludedPaths = includedPaths;
            PolicyFormatVersion = policyFormatVersion;
        }
    }
}
