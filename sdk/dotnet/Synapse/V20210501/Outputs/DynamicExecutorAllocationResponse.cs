// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse.V20210501.Outputs
{

    /// <summary>
    /// Dynamic Executor Allocation Properties
    /// </summary>
    [OutputType]
    public sealed class DynamicExecutorAllocationResponse
    {
        /// <summary>
        /// Indicates whether Dynamic Executor Allocation is enabled or not.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private DynamicExecutorAllocationResponse(bool? enabled)
        {
            Enabled = enabled;
        }
    }
}
