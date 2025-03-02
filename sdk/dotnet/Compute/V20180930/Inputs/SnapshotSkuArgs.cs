// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20180930.Inputs
{

    /// <summary>
    /// The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS.
    /// </summary>
    public sealed class SnapshotSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The sku name.
        /// </summary>
        [Input("name")]
        public InputUnion<string, Pulumi.AzureNative.Compute.V20180930.SnapshotStorageAccountTypes>? Name { get; set; }

        public SnapshotSkuArgs()
        {
        }
    }
}
