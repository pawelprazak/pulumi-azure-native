// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorageCache.V20210901.Inputs
{

    /// <summary>
    /// SKU for the Cache.
    /// </summary>
    public sealed class CacheSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SKU name for this Cache.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public CacheSkuArgs()
        {
        }
    }
}
