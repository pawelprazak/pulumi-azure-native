// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.Outputs
{

    /// <summary>
    /// Describes the settings to produce a JPEG image from the input video.
    /// </summary>
    [OutputType]
    public sealed class JpgLayerResponse
    {
        /// <summary>
        /// The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input.
        /// </summary>
        public readonly string? Height;
        /// <summary>
        /// The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file.
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.JpgLayer'.
        /// </summary>
        public readonly string OdataType;
        /// <summary>
        /// The compression quality of the JPEG output. Range is from 0-100 and the default is 70.
        /// </summary>
        public readonly int? Quality;
        /// <summary>
        /// The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input.
        /// </summary>
        public readonly string? Width;

        [OutputConstructor]
        private JpgLayerResponse(
            string? height,

            string? label,

            string odataType,

            int? quality,

            string? width)
        {
            Height = height;
            Label = label;
            OdataType = odataType;
            Quality = quality;
            Width = width;
        }
    }
}
