// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20220202Preview.Outputs
{

    /// <summary>
    /// Security profile for the container service cluster.
    /// </summary>
    [OutputType]
    public sealed class ManagedClusterSecurityProfileResponse
    {
        /// <summary>
        /// Azure Defender settings for the security profile.
        /// </summary>
        public readonly Outputs.ManagedClusterSecurityProfileAzureDefenderResponse? AzureDefender;
        /// <summary>
        /// Azure Key Vault [key management service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
        /// </summary>
        public readonly Outputs.AzureKeyVaultKmsResponse? AzureKeyVaultKms;

        [OutputConstructor]
        private ManagedClusterSecurityProfileResponse(
            Outputs.ManagedClusterSecurityProfileAzureDefenderResponse? azureDefender,

            Outputs.AzureKeyVaultKmsResponse? azureKeyVaultKms)
        {
            AzureDefender = azureDefender;
            AzureKeyVaultKms = azureKeyVaultKms;
        }
    }
}
