// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerRegistry.V20191201Preview.Inputs
{

    public sealed class EncryptionPropertyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key vault properties.
        /// </summary>
        [Input("keyVaultProperties")]
        public Input<Inputs.KeyVaultPropertiesArgs>? KeyVaultProperties { get; set; }

        /// <summary>
        /// Indicates whether or not the encryption is enabled for container registry.
        /// </summary>
        [Input("status")]
        public InputUnion<string, Pulumi.AzureNative.ContainerRegistry.V20191201Preview.EncryptionStatus>? Status { get; set; }

        public EncryptionPropertyArgs()
        {
        }
    }
}
