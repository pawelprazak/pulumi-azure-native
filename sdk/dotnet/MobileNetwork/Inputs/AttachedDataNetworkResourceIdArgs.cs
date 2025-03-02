// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MobileNetwork.Inputs
{

    /// <summary>
    /// Reference to an Attached Data Network resource.
    /// </summary>
    public sealed class AttachedDataNetworkResourceIdArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Attached Data Network resource ID.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public AttachedDataNetworkResourceIdArgs()
        {
        }
    }
}
