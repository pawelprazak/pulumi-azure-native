// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MobileNetwork.V20220301Preview.Inputs
{

    /// <summary>
    /// Reference to an Azure ARC custom location resource.
    /// </summary>
    public sealed class CustomLocationResourceIdArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Azure ARC custom location resource ID.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public CustomLocationResourceIdArgs()
        {
        }
    }
}
