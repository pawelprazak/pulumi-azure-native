// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.KubernetesConfiguration.Outputs
{

    /// <summary>
    /// Identity for the managed cluster.
    /// </summary>
    [OutputType]
    public sealed class ConfigurationIdentityResponse
    {
        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        public readonly string PrincipalId;
        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None' will not use Managed Identity for the configuration.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ConfigurationIdentityResponse(
            string principalId,

            string tenantId,

            string? type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }
    }
}
