// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.KeyVault.V20210601Preview.Inputs
{

    /// <summary>
    /// SKU details
    /// </summary>
    public sealed class ManagedHsmSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SKU Family of the managed HSM Pool
        /// </summary>
        [Input("family", required: true)]
        public InputUnion<string, Pulumi.AzureNative.KeyVault.V20210601Preview.ManagedHsmSkuFamily> Family { get; set; } = null!;

        /// <summary>
        /// SKU of the managed HSM Pool
        /// </summary>
        [Input("name", required: true)]
        public Input<Pulumi.AzureNative.KeyVault.V20210601Preview.ManagedHsmSkuName> Name { get; set; } = null!;

        public ManagedHsmSkuArgs()
        {
        }
    }
}
