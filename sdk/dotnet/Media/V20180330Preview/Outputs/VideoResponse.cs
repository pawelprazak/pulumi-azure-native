// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20180330Preview.Outputs
{

    /// <summary>
    /// Describes the basic properties for encoding the input video.
    /// </summary>
    [OutputType]
    public sealed class VideoResponse
    {
        /// <summary>
        /// The distance between two key frames, thereby defining a group of pictures (GOP). The value should be a non-zero integer in the range [1, 30] seconds, specified in ISO 8601 format. The default is 2 seconds (PT2S).
        /// </summary>
        public readonly string? KeyFrameInterval;
        /// <summary>
        /// An optional label for the codec. The label can be used to control muxing behavior.
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.Video'.
        /// </summary>
        public readonly string OdataType;
        /// <summary>
        /// The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
        /// </summary>
        public readonly string? StretchMode;

        [OutputConstructor]
        private VideoResponse(
            string? keyFrameInterval,

            string? label,

            string odataType,

            string? stretchMode)
        {
            KeyFrameInterval = keyFrameInterval;
            Label = label;
            OdataType = odataType;
            StretchMode = stretchMode;
        }
    }
}
