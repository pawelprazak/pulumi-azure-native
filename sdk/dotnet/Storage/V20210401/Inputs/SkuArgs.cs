// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Storage.V20210401.Inputs
{

    /// <summary>
    /// The SKU of the storage account.
    /// </summary>
    public sealed class SkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType.
        /// </summary>
        [Input("name", required: true)]
        public InputUnion<string, Pulumi.AzureNative.Storage.V20210401.SkuName> Name { get; set; } = null!;

        public SkuArgs()
        {
        }
    }
}
