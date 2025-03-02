// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.Inputs
{

    /// <summary>
    /// Azure blobFS write settings.
    /// </summary>
    public sealed class AzureBlobFSWriteSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates the block size(MB) when writing data to blob. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("blockSizeInMB")]
        public Input<object>? BlockSizeInMB { get; set; }

        /// <summary>
        /// The type of copy behavior for copy sink.
        /// </summary>
        [Input("copyBehavior")]
        public Input<object>? CopyBehavior { get; set; }

        /// <summary>
        /// If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("disableMetricsCollection")]
        public Input<object>? DisableMetricsCollection { get; set; }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// The write setting type.
        /// Expected value is 'AzureBlobFSWriteSettings'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AzureBlobFSWriteSettingsArgs()
        {
        }
    }
}
