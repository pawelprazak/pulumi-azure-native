// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EventGrid.V20201015Preview.Inputs
{

    /// <summary>
    /// Describes an EventGrid Resource Sku.
    /// </summary>
    public sealed class ResourceSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Sku name of the resource. The possible values are: Basic or Premium.
        /// </summary>
        [Input("name")]
        public InputUnion<string, Pulumi.AzureNative.EventGrid.V20201015Preview.Sku>? Name { get; set; }

        public ResourceSkuArgs()
        {
            Name = "Basic";
        }
    }
}
