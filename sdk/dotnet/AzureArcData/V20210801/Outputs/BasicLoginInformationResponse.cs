// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureArcData.V20210801.Outputs
{

    /// <summary>
    /// Username and password for basic login authentication.
    /// </summary>
    [OutputType]
    public sealed class BasicLoginInformationResponse
    {
        /// <summary>
        /// Login username.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private BasicLoginInformationResponse(string? username)
        {
            Username = username;
        }
    }
}
