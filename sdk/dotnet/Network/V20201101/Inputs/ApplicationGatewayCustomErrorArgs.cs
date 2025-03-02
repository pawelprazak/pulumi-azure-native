// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20201101.Inputs
{

    /// <summary>
    /// Customer error of an application gateway.
    /// </summary>
    public sealed class ApplicationGatewayCustomErrorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Error page URL of the application gateway customer error.
        /// </summary>
        [Input("customErrorPageUrl")]
        public Input<string>? CustomErrorPageUrl { get; set; }

        /// <summary>
        /// Status code of the application gateway customer error.
        /// </summary>
        [Input("statusCode")]
        public InputUnion<string, Pulumi.AzureNative.Network.V20201101.ApplicationGatewayCustomErrorStatusCode>? StatusCode { get; set; }

        public ApplicationGatewayCustomErrorArgs()
        {
        }
    }
}
