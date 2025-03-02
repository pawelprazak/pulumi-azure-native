// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DevTestLab.V20150521Preview.Outputs
{

    /// <summary>
    /// Properties for creating a custom image from a VHD.
    /// </summary>
    [OutputType]
    public sealed class CustomImagePropertiesCustomResponse
    {
        /// <summary>
        /// The image name.
        /// </summary>
        public readonly string? ImageName;
        /// <summary>
        /// Indicates whether sysprep has been run on the VHD.
        /// </summary>
        public readonly bool? SysPrep;

        [OutputConstructor]
        private CustomImagePropertiesCustomResponse(
            string? imageName,

            bool? sysPrep)
        {
            ImageName = imageName;
            SysPrep = sysPrep;
        }
    }
}
