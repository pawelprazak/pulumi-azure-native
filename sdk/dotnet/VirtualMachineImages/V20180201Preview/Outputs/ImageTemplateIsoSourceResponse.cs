// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.VirtualMachineImages.V20180201Preview.Outputs
{

    /// <summary>
    /// Describes an image source that is an installation ISO. Currently only supports Red Hat Enterprise Linux 7.2-7.5 ISO's.
    /// </summary>
    [OutputType]
    public sealed class ImageTemplateIsoSourceResponse
    {
        /// <summary>
        /// SHA256 Checksum of the ISO image.
        /// </summary>
        public readonly string Sha256Checksum;
        /// <summary>
        /// URL to get the ISO image. This URL has to be accessible to the resource provider at the time of the imageTemplate creation.
        /// </summary>
        public readonly string SourceURI;
        /// <summary>
        /// Specifies the type of source image you want to start with.
        /// Expected value is 'ISO'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ImageTemplateIsoSourceResponse(
            string sha256Checksum,

            string sourceURI,

            string type)
        {
            Sha256Checksum = sha256Checksum;
            SourceURI = sourceURI;
            Type = type;
        }
    }
}
