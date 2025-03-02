// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.VideoAnalyzer.V20211101Preview.Inputs
{

    /// <summary>
    /// Describes an input signal to be used on a pipeline node.
    /// </summary>
    public sealed class NodeInputArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the upstream node in the pipeline which output is used as input of the current node.
        /// </summary>
        [Input("nodeName", required: true)]
        public Input<string> NodeName { get; set; } = null!;

        public NodeInputArgs()
        {
        }
    }
}
