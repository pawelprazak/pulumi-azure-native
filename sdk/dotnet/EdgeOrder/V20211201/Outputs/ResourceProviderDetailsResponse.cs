// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EdgeOrder.V20211201.Outputs
{

    /// <summary>
    /// Management RP details
    /// </summary>
    [OutputType]
    public sealed class ResourceProviderDetailsResponse
    {
        /// <summary>
        /// Resource provider namespace
        /// </summary>
        public readonly string ResourceProviderNamespace;

        [OutputConstructor]
        private ResourceProviderDetailsResponse(string resourceProviderNamespace)
        {
            ResourceProviderNamespace = resourceProviderNamespace;
        }
    }
}
