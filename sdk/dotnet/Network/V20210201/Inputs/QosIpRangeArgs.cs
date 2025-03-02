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
    /// Qos Traffic Profiler IP Range properties.
    /// </summary>
    public sealed class QosIpRangeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// End IP Address.
        /// </summary>
        [Input("endIP")]
        public Input<string>? EndIP { get; set; }

        /// <summary>
        /// Start IP Address.
        /// </summary>
        [Input("startIP")]
        public Input<string>? StartIP { get; set; }

        public QosIpRangeArgs()
        {
        }
    }
}
