// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Authorization.V20170401.Inputs
{

    /// <summary>
    /// Lock owner properties.
    /// </summary>
    public sealed class ManagementLockOwnerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The application ID of the lock owner.
        /// </summary>
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        public ManagementLockOwnerArgs()
        {
        }
    }
}
