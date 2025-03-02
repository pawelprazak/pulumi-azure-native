// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20211001.Outputs
{

    /// <summary>
    /// Contains information about the soft deletion policy of the gallery.
    /// </summary>
    [OutputType]
    public sealed class SoftDeletePolicyResponse
    {
        /// <summary>
        /// Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time.
        /// </summary>
        public readonly bool? IsSoftDeleteEnabled;

        [OutputConstructor]
        private SoftDeletePolicyResponse(bool? isSoftDeleteEnabled)
        {
            IsSoftDeleteEnabled = isSoftDeleteEnabled;
        }
    }
}
