// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.TestBase.V20220401Preview.Inputs
{

    /// <summary>
    /// A notification event receivers.
    /// </summary>
    public sealed class NotificationEventReceiverArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of the notification event receiver.
        /// </summary>
        [Input("receiverType")]
        public Input<string>? ReceiverType { get; set; }

        /// <summary>
        /// The notification event receiver value.
        /// </summary>
        [Input("receiverValue")]
        public Input<Inputs.NotificationReceiverValueArgs>? ReceiverValue { get; set; }

        public NotificationEventReceiverArgs()
        {
        }
    }
}
