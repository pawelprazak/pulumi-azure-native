// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HybridCompute.V20220510Preview.Inputs
{

    /// <summary>
    /// Properties that define a Azure Arc PrivateLinkScope resource.
    /// </summary>
    public sealed class HybridComputePrivateLinkScopePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        [Input("publicNetworkAccess")]
        public InputUnion<string, Pulumi.AzureNative.HybridCompute.V20220510Preview.PublicNetworkAccessType>? PublicNetworkAccess { get; set; }

        public HybridComputePrivateLinkScopePropertiesArgs()
        {
        }
    }
}
