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
    /// Reference to an Azure ARC custom location resource.
    /// </summary>
    [OutputType]
    public sealed class CustomLocationResourceIdResponse
    {
        /// <summary>
        /// Azure ARC custom location resource ID.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private CustomLocationResourceIdResponse(string id)
        {
            Id = id;
        }
    }
}
