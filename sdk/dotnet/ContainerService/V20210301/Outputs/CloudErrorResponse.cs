// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20210301.Outputs
{

    /// <summary>
    /// An error response from the Container service.
    /// </summary>
    [OutputType]
    public sealed class CloudErrorResponse
    {
        /// <summary>
        /// Details about the error.
        /// </summary>
        public readonly Outputs.CloudErrorBodyResponse? Error;

        [OutputConstructor]
        private CloudErrorResponse(Outputs.CloudErrorBodyResponse? error)
        {
            Error = error;
        }
    }
}
