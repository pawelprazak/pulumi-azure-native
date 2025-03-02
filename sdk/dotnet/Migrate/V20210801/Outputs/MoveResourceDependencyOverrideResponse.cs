// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Migrate.V20210801.Outputs
{

    /// <summary>
    /// Defines the dependency override of the move resource.
    /// </summary>
    [OutputType]
    public sealed class MoveResourceDependencyOverrideResponse
    {
        /// <summary>
        /// Gets or sets the ARM ID of the dependent resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Gets or sets the resource ARM id of either the MoveResource or the resource ARM ID of
        /// the dependent resource.
        /// </summary>
        public readonly string? TargetId;

        [OutputConstructor]
        private MoveResourceDependencyOverrideResponse(
            string? id,

            string? targetId)
        {
            Id = id;
            TargetId = targetId;
        }
    }
}
