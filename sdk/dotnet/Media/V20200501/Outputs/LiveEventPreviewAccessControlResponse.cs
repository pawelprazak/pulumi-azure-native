// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20200501.Outputs
{

    /// <summary>
    /// The IP access control for the live event preview endpoint.
    /// </summary>
    [OutputType]
    public sealed class LiveEventPreviewAccessControlResponse
    {
        /// <summary>
        /// The IP access control properties.
        /// </summary>
        public readonly Outputs.IPAccessControlResponse? Ip;

        [OutputConstructor]
        private LiveEventPreviewAccessControlResponse(Outputs.IPAccessControlResponse? ip)
        {
            Ip = ip;
        }
    }
}
