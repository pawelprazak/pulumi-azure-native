// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.VirtualMachineImages.V20190501Preview.Outputs
{

    /// <summary>
    /// Describes an image source from [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
    /// </summary>
    [OutputType]
    public sealed class ImageTemplatePlatformImageSourceResponse
    {
        /// <summary>
        /// Image offer from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        /// </summary>
        public readonly string? Offer;
        /// <summary>
        /// Image Publisher in [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        /// </summary>
        public readonly string? Publisher;
        /// <summary>
        /// Image sku from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        /// </summary>
        public readonly string? Sku;
        /// <summary>
        /// Specifies the type of source image you want to start with.
        /// Expected value is 'PlatformImage'.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Image version from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private ImageTemplatePlatformImageSourceResponse(
            string? offer,

            string? publisher,

            string? sku,

            string type,

            string? version)
        {
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Type = type;
            Version = version;
        }
    }
}
