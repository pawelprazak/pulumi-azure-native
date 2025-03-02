// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DeploymentManager.V20191101Preview.Outputs
{

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    [OutputType]
    public sealed class IdentityResponse
    {
        /// <summary>
        /// The list of identities.
        /// </summary>
        public readonly ImmutableArray<string> IdentityIds;
        /// <summary>
        /// The identity type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private IdentityResponse(
            ImmutableArray<string> identityIds,

            string type)
        {
            IdentityIds = identityIds;
            Type = type;
        }
    }
}
