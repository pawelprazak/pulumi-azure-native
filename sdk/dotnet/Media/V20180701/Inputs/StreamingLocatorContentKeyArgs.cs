// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20180701.Inputs
{

    /// <summary>
    /// Class for content key in Streaming Locator
    /// </summary>
    public sealed class StreamingLocatorContentKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of Content Key
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Label of Content Key as specified in the Streaming Policy
        /// </summary>
        [Input("labelReferenceInStreamingPolicy")]
        public Input<string>? LabelReferenceInStreamingPolicy { get; set; }

        /// <summary>
        /// Value of Content Key
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public StreamingLocatorContentKeyArgs()
        {
        }
    }
}
