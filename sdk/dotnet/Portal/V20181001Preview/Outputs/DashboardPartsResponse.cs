// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Portal.V20181001Preview.Outputs
{

    /// <summary>
    /// A dashboard part.
    /// </summary>
    [OutputType]
    public sealed class DashboardPartsResponse
    {
        /// <summary>
        /// A dashboard part metadata.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// The dashboard's part position.
        /// </summary>
        public readonly Outputs.DashboardPartsResponsePosition Position;

        [OutputConstructor]
        private DashboardPartsResponse(
            object? metadata,

            Outputs.DashboardPartsResponsePosition position)
        {
            Metadata = metadata;
            Position = position;
        }
    }
}
