// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20180301.Outputs
{

    /// <summary>
    /// An email receiver.
    /// </summary>
    [OutputType]
    public sealed class EmailReceiverResponse
    {
        /// <summary>
        /// The email address of this receiver.
        /// </summary>
        public readonly string EmailAddress;
        /// <summary>
        /// The name of the email receiver. Names must be unique across all receivers within an action group.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The receiver status of the e-mail.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private EmailReceiverResponse(
            string emailAddress,

            string name,

            string status)
        {
            EmailAddress = emailAddress;
            Name = name;
            Status = status;
        }
    }
}
