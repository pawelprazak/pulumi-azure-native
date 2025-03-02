// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20210201.Inputs
{

    /// <summary>
    /// Contains the IpTag associated with the object.
    /// </summary>
    public sealed class IpTagArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IP tag type. Example: FirstPartyUsage.
        /// </summary>
        [Input("ipTagType")]
        public Input<string>? IpTagType { get; set; }

        /// <summary>
        /// The value of the IP tag associated with the public IP. Example: SQL.
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public IpTagArgs()
        {
        }
    }
}
