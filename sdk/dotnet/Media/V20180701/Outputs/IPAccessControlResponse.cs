// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20180701.Outputs
{

    /// <summary>
    /// The IP access control.
    /// </summary>
    [OutputType]
    public sealed class IPAccessControlResponse
    {
        /// <summary>
        /// The IP allow list.
        /// </summary>
        public readonly ImmutableArray<Outputs.IPRangeResponse> Allow;

        [OutputConstructor]
        private IPAccessControlResponse(ImmutableArray<Outputs.IPRangeResponse> allow)
        {
            Allow = allow;
        }
    }
}
