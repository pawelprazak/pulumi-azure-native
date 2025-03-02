// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.KeyVault.V20190901.Inputs
{

    /// <summary>
    /// SKU details
    /// </summary>
    public sealed class SkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SKU family name
        /// </summary>
        [Input("family", required: true)]
        public InputUnion<string, Pulumi.AzureNative.KeyVault.V20190901.SkuFamily> Family { get; set; } = null!;

        /// <summary>
        /// SKU name to specify whether the key vault is a standard vault or a premium vault.
        /// </summary>
        [Input("name", required: true)]
        public Input<Pulumi.AzureNative.KeyVault.V20190901.SkuName> Name { get; set; } = null!;

        public SkuArgs()
        {
        }
    }
}
