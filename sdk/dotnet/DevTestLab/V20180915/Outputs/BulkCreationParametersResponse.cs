// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DevTestLab.V20180915.Outputs
{

    /// <summary>
    /// Parameters for creating multiple virtual machines as a single action.
    /// </summary>
    [OutputType]
    public sealed class BulkCreationParametersResponse
    {
        /// <summary>
        /// The number of virtual machine instances to create.
        /// </summary>
        public readonly int? InstanceCount;

        [OutputConstructor]
        private BulkCreationParametersResponse(int? instanceCount)
        {
            InstanceCount = instanceCount;
        }
    }
}
