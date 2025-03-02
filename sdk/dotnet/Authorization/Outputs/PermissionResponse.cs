// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Authorization.Outputs
{

    /// <summary>
    /// Role definition permissions.
    /// </summary>
    [OutputType]
    public sealed class PermissionResponse
    {
        /// <summary>
        /// Allowed actions.
        /// </summary>
        public readonly ImmutableArray<string> Actions;
        /// <summary>
        /// Allowed Data actions.
        /// </summary>
        public readonly ImmutableArray<string> DataActions;
        /// <summary>
        /// Denied actions.
        /// </summary>
        public readonly ImmutableArray<string> NotActions;
        /// <summary>
        /// Denied Data actions.
        /// </summary>
        public readonly ImmutableArray<string> NotDataActions;

        [OutputConstructor]
        private PermissionResponse(
            ImmutableArray<string> actions,

            ImmutableArray<string> dataActions,

            ImmutableArray<string> notActions,

            ImmutableArray<string> notDataActions)
        {
            Actions = actions;
            DataActions = dataActions;
            NotActions = notActions;
            NotDataActions = notDataActions;
        }
    }
}
