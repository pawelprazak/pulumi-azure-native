// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Storage.V20210901.Inputs
{

    /// <summary>
    /// The blob service properties for blob restore policy
    /// </summary>
    public sealed class RestorePolicyPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.
        /// </summary>
        [Input("days")]
        public Input<int>? Days { get; set; }

        /// <summary>
        /// Blob restore is enabled if set to true.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public RestorePolicyPropertiesArgs()
        {
        }
    }
}
