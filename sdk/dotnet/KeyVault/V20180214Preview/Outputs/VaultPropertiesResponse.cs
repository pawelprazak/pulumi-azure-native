// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.KeyVault.V20180214Preview.Outputs
{

    /// <summary>
    /// Properties of the vault
    /// </summary>
    [OutputType]
    public sealed class VaultPropertiesResponse
    {
        /// <summary>
        /// An array of 0 to 1024 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID.
        /// </summary>
        public readonly ImmutableArray<Outputs.AccessPolicyEntryResponse> AccessPolicies;
        /// <summary>
        /// The vault's create mode to indicate whether the vault need to be recovered or not.
        /// </summary>
        public readonly string? CreateMode;
        /// <summary>
        /// Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible - that is, the property does not accept false as its value.
        /// </summary>
        public readonly bool? EnablePurgeProtection;
        /// <summary>
        /// Property to specify whether the 'soft delete' functionality is enabled for this key vault. It does not accept false value.
        /// </summary>
        public readonly bool? EnableSoftDelete;
        /// <summary>
        /// Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault.
        /// </summary>
        public readonly bool? EnabledForDeployment;
        /// <summary>
        /// Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        public readonly bool? EnabledForDiskEncryption;
        /// <summary>
        /// Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.
        /// </summary>
        public readonly bool? EnabledForTemplateDeployment;
        /// <summary>
        /// A collection of rules governing the accessibility of the vault from specific network locations.
        /// </summary>
        public readonly Outputs.NetworkRuleSetResponse? NetworkAcls;
        /// <summary>
        /// SKU details
        /// </summary>
        public readonly Outputs.SkuResponse Sku;
        /// <summary>
        /// The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The URI of the vault for performing operations on keys and secrets.
        /// </summary>
        public readonly string? VaultUri;

        [OutputConstructor]
        private VaultPropertiesResponse(
            ImmutableArray<Outputs.AccessPolicyEntryResponse> accessPolicies,

            string? createMode,

            bool? enablePurgeProtection,

            bool? enableSoftDelete,

            bool? enabledForDeployment,

            bool? enabledForDiskEncryption,

            bool? enabledForTemplateDeployment,

            Outputs.NetworkRuleSetResponse? networkAcls,

            Outputs.SkuResponse sku,

            string tenantId,

            string? vaultUri)
        {
            AccessPolicies = accessPolicies;
            CreateMode = createMode;
            EnablePurgeProtection = enablePurgeProtection;
            EnableSoftDelete = enableSoftDelete;
            EnabledForDeployment = enabledForDeployment;
            EnabledForDiskEncryption = enabledForDiskEncryption;
            EnabledForTemplateDeployment = enabledForTemplateDeployment;
            NetworkAcls = networkAcls;
            Sku = sku;
            TenantId = tenantId;
            VaultUri = vaultUri;
        }
    }
}
