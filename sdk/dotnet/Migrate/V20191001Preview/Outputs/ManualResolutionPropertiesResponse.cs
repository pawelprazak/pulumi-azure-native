// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Migrate.V20191001Preview.Outputs
{

    /// <summary>
    /// Defines the properties for manual resolution.
    /// </summary>
    [OutputType]
    public sealed class ManualResolutionPropertiesResponse
    {
        /// <summary>
        /// Gets or sets the target resource ARM ID of the dependent resource if the resource type is Manual.
        /// </summary>
        public readonly string? TargetId;

        [OutputConstructor]
        private ManualResolutionPropertiesResponse(string? targetId)
        {
            TargetId = targetId;
        }
    }
}
