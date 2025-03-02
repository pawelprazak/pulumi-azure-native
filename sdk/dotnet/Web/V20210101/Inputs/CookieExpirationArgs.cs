// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20210101.Inputs
{

    /// <summary>
    /// The configuration settings of the session cookie's expiration.
    /// </summary>
    public sealed class CookieExpirationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The convention used when determining the session cookie's expiration.
        /// </summary>
        [Input("convention")]
        public Input<Pulumi.AzureNative.Web.V20210101.CookieExpirationConvention>? Convention { get; set; }

        /// <summary>
        /// The time after the request is made when the session cookie should expire.
        /// </summary>
        [Input("timeToExpiration")]
        public Input<string>? TimeToExpiration { get; set; }

        public CookieExpirationArgs()
        {
        }
    }
}
