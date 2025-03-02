// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceFabric.V20210701Preview.Inputs
{

    /// <summary>
    /// IPTag associated with the object.
    /// </summary>
    public sealed class IPTagArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IP tag type.
        /// </summary>
        [Input("ipTagType", required: true)]
        public Input<string> IpTagType { get; set; } = null!;

        /// <summary>
        /// The value of the IP tag.
        /// </summary>
        [Input("tag", required: true)]
        public Input<string> Tag { get; set; } = null!;

        public IPTagArgs()
        {
        }
    }
}
