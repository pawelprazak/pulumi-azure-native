// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Resources.V20190801.Outputs
{

    /// <summary>
    /// The alias type. 
    /// </summary>
    [OutputType]
    public sealed class AliasTypeResponse
    {
        /// <summary>
        /// The alias name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The paths for an alias.
        /// </summary>
        public readonly ImmutableArray<Outputs.AliasPathTypeResponse> Paths;

        [OutputConstructor]
        private AliasTypeResponse(
            string? name,

            ImmutableArray<Outputs.AliasPathTypeResponse> paths)
        {
            Name = name;
            Paths = paths;
        }
    }
}
