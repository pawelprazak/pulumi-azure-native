// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MobileNetwork.V20220301Preview.Outputs
{

    /// <summary>
    /// Reference to a Data Network resource.
    /// </summary>
    [OutputType]
    public sealed class DataNetworkResourceIdResponse
    {
        /// <summary>
        /// Data Network resource ID.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private DataNetworkResourceIdResponse(string id)
        {
            Id = id;
        }
    }
}
