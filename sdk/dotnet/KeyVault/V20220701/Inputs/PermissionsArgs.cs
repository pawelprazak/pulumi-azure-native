// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.KeyVault.V20220701.Inputs
{

    /// <summary>
    /// Permissions the identity has for keys, secrets, certificates and storage.
    /// </summary>
    public sealed class PermissionsArgs : Pulumi.ResourceArgs
    {
        [Input("certificates")]
        private InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.CertificatePermissions>>? _certificates;

        /// <summary>
        /// Permissions to certificates
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.CertificatePermissions>> Certificates
        {
            get => _certificates ?? (_certificates = new InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.CertificatePermissions>>());
            set => _certificates = value;
        }

        [Input("keys")]
        private InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.KeyPermissions>>? _keys;

        /// <summary>
        /// Permissions to keys
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.KeyPermissions>> Keys
        {
            get => _keys ?? (_keys = new InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.KeyPermissions>>());
            set => _keys = value;
        }

        [Input("secrets")]
        private InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.SecretPermissions>>? _secrets;

        /// <summary>
        /// Permissions to secrets
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.SecretPermissions>> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.SecretPermissions>>());
            set => _secrets = value;
        }

        [Input("storage")]
        private InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.StoragePermissions>>? _storage;

        /// <summary>
        /// Permissions to storage accounts
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.StoragePermissions>> Storage
        {
            get => _storage ?? (_storage = new InputList<Union<string, Pulumi.AzureNative.KeyVault.V20220701.StoragePermissions>>());
            set => _storage = value;
        }

        public PermissionsArgs()
        {
        }
    }
}
