// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20180601Preview.Outputs
{

    /// <summary>
    /// Describes the de-interlacing settings.
    /// </summary>
    [OutputType]
    public sealed class DeinterlaceResponse
    {
        /// <summary>
        /// The deinterlacing mode. Defaults to AutoPixelAdaptive.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// The field parity for de-interlacing, defaults to Auto.
        /// </summary>
        public readonly string? Parity;

        [OutputConstructor]
        private DeinterlaceResponse(
            string? mode,

            string? parity)
        {
            Mode = mode;
            Parity = parity;
        }
    }
}
