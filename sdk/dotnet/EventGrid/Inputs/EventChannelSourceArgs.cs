// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EventGrid.Inputs
{

    /// <summary>
    /// Properties of the source of an event channel.
    /// </summary>
    public sealed class EventChannelSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The identifier of the resource that's the source of the events.
        /// This represents a unique resource in the partner's resource model.
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        public EventChannelSourceArgs()
        {
        }
    }
}
