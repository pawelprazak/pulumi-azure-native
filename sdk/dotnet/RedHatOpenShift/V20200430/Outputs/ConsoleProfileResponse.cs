// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RedHatOpenShift.V20200430.Outputs
{

    /// <summary>
    /// ConsoleProfile represents a console profile.
    /// </summary>
    [OutputType]
    public sealed class ConsoleProfileResponse
    {
        /// <summary>
        /// The URL to access the cluster console (immutable).
        /// </summary>
        public readonly string? Url;

        [OutputConstructor]
        private ConsoleProfileResponse(string? url)
        {
            Url = url;
        }
    }
}
