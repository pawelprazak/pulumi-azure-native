// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HardwareSecurityModules.V20181031Preview.Inputs
{

    /// <summary>
    /// SKU of the dedicated HSM
    /// </summary>
    public sealed class SkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SKU of the dedicated HSM
        /// </summary>
        [Input("name")]
        public InputUnion<string, Pulumi.AzureNative.HardwareSecurityModules.V20181031Preview.SkuName>? Name { get; set; }

        public SkuArgs()
        {
        }
    }
}
