// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorageCache.V20191101.Outputs
{

    /// <summary>
    /// Storage container for use as an Unknown Storage Target.
    /// </summary>
    [OutputType]
    public sealed class UnknownTargetResponse
    {
        /// <summary>
        /// Dictionary of string-&gt;string pairs containing information about the Storage Target.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? UnknownMap;

        [OutputConstructor]
        private UnknownTargetResponse(ImmutableDictionary<string, string>? unknownMap)
        {
            UnknownMap = unknownMap;
        }
    }
}
