// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Elastic.V20210901Preview.Inputs
{

    /// <summary>
    /// Microsoft.Elastic SKU.
    /// </summary>
    public sealed class ResourceSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the SKU.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ResourceSkuArgs()
        {
        }
    }
}
