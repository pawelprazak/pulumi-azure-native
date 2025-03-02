// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20211101.Inputs
{

    /// <summary>
    /// Represents a token claim.
    /// </summary>
    public sealed class ContentKeyPolicyTokenClaimArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Token claim type.
        /// </summary>
        [Input("claimType")]
        public Input<string>? ClaimType { get; set; }

        /// <summary>
        /// Token claim value.
        /// </summary>
        [Input("claimValue")]
        public Input<string>? ClaimValue { get; set; }

        public ContentKeyPolicyTokenClaimArgs()
        {
        }
    }
}
