// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.V20200901.Outputs
{

    /// <summary>
    /// Defines the parameters for the Url Signing action.
    /// </summary>
    [OutputType]
    public sealed class UrlSigningActionParametersResponse
    {
        /// <summary>
        /// Algorithm to use for URL signing
        /// </summary>
        public readonly string? Algorithm;
        public readonly string OdataType;
        /// <summary>
        /// Defines which query string parameters in the url to be considered for expires, key id etc. 
        /// </summary>
        public readonly ImmutableArray<Outputs.UrlSigningParamIdentifierResponse> ParameterNameOverride;

        [OutputConstructor]
        private UrlSigningActionParametersResponse(
            string? algorithm,

            string odataType,

            ImmutableArray<Outputs.UrlSigningParamIdentifierResponse> parameterNameOverride)
        {
            Algorithm = algorithm;
            OdataType = odataType;
            ParameterNameOverride = parameterNameOverride;
        }
    }
}
