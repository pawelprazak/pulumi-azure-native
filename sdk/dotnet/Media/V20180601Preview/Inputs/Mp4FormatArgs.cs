// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20180601Preview.Inputs
{

    /// <summary>
    /// Describes the properties for an output ISO MP4 file.
    /// </summary>
    public sealed class Mp4FormatArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The pattern of the file names for the generated output files. The following macros are supported in the file name: {Basename} - The base name of the input video {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {Bitrate} - The audio/video bitrate. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. Any unsubstituted macros will be collapsed and removed from the filename.
        /// </summary>
        [Input("filenamePattern")]
        public Input<string>? FilenamePattern { get; set; }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.Mp4Format'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        [Input("outputFiles")]
        private InputList<Inputs.OutputFileArgs>? _outputFiles;

        /// <summary>
        /// The list of output files to produce.  Each entry in the list is a set of audio and video layer labels to be muxed together .
        /// </summary>
        public InputList<Inputs.OutputFileArgs> OutputFiles
        {
            get => _outputFiles ?? (_outputFiles = new InputList<Inputs.OutputFileArgs>());
            set => _outputFiles = value;
        }

        public Mp4FormatArgs()
        {
        }
    }
}
