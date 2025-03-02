// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EventGrid.V20211201.Inputs
{

    /// <summary>
    /// Information about the deadletter destination with resource identity.
    /// </summary>
    public sealed class DeadLetterWithResourceIdentityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
        /// </summary>
        [Input("deadLetterDestination")]
        public Input<Inputs.StorageBlobDeadLetterDestinationArgs>? DeadLetterDestination { get; set; }

        /// <summary>
        /// The identity to use when dead-lettering events.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.EventSubscriptionIdentityArgs>? Identity { get; set; }

        public DeadLetterWithResourceIdentityArgs()
        {
        }
    }
}
