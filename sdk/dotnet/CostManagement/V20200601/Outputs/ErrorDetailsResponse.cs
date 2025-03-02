// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CostManagement.V20200601.Outputs
{

    /// <summary>
    /// The details of the error.
    /// </summary>
    [OutputType]
    public sealed class ErrorDetailsResponse
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public readonly string Code;
        /// <summary>
        /// Error message indicating why the operation failed.
        /// </summary>
        public readonly string Message;

        [OutputConstructor]
        private ErrorDetailsResponse(
            string code,

            string message)
        {
            Code = code;
            Message = message;
        }
    }
}
