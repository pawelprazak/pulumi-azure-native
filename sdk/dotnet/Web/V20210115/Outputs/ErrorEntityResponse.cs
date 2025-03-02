// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20210115.Outputs
{

    /// <summary>
    /// Body of the error response returned from the API.
    /// </summary>
    [OutputType]
    public sealed class ErrorEntityResponse
    {
        /// <summary>
        /// Basic error code.
        /// </summary>
        public readonly string? Code;
        /// <summary>
        /// Type of error.
        /// </summary>
        public readonly string? ExtendedCode;
        /// <summary>
        /// Inner errors.
        /// </summary>
        public readonly ImmutableArray<Outputs.ErrorEntityResponse> InnerErrors;
        /// <summary>
        /// Any details of the error.
        /// </summary>
        public readonly string? Message;
        /// <summary>
        /// Message template.
        /// </summary>
        public readonly string? MessageTemplate;
        /// <summary>
        /// Parameters for the template.
        /// </summary>
        public readonly ImmutableArray<string> Parameters;

        [OutputConstructor]
        private ErrorEntityResponse(
            string? code,

            string? extendedCode,

            ImmutableArray<Outputs.ErrorEntityResponse> innerErrors,

            string? message,

            string? messageTemplate,

            ImmutableArray<string> parameters)
        {
            Code = code;
            ExtendedCode = extendedCode;
            InnerErrors = innerErrors;
            Message = message;
            MessageTemplate = messageTemplate;
            Parameters = parameters;
        }
    }
}
