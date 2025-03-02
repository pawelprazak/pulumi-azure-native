// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.V20200331.Inputs
{

    /// <summary>
    /// Defines the parameters for the url redirect action.
    /// </summary>
    public sealed class UrlRedirectActionParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// </summary>
        [Input("customFragment")]
        public Input<string>? CustomFragment { get; set; }

        /// <summary>
        /// Host to redirect. Leave empty to use the incoming host as the destination host.
        /// </summary>
        [Input("customHostname")]
        public Input<string>? CustomHostname { get; set; }

        /// <summary>
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination path.
        /// </summary>
        [Input("customPath")]
        public Input<string>? CustomPath { get; set; }

        /// <summary>
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string; leave empty to preserve the incoming query string. Query string must be in &lt;key&gt;=&lt;value&gt; format. ? and &amp; will be added automatically so do not include them.
        /// </summary>
        [Input("customQueryString")]
        public Input<string>? CustomQueryString { get; set; }

        /// <summary>
        /// Protocol to use for the redirect. The default value is MatchRequest
        /// </summary>
        [Input("destinationProtocol")]
        public InputUnion<string, Pulumi.AzureNative.Cdn.V20200331.DestinationProtocol>? DestinationProtocol { get; set; }

        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// The redirect type the rule will use when redirecting traffic.
        /// </summary>
        [Input("redirectType", required: true)]
        public InputUnion<string, Pulumi.AzureNative.Cdn.V20200331.RedirectType> RedirectType { get; set; } = null!;

        public UrlRedirectActionParametersArgs()
        {
        }
    }
}
