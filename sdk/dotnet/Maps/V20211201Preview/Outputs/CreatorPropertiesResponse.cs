// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Maps.V20211201Preview.Outputs
{

    /// <summary>
    /// Creator resource properties
    /// </summary>
    [OutputType]
    public sealed class CreatorPropertiesResponse
    {
        /// <summary>
        /// The state of the resource provisioning, terminal states: Succeeded, Failed, Canceled
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The storage units to be allocated. Integer values from 1 to 100, inclusive.
        /// </summary>
        public readonly int StorageUnits;

        [OutputConstructor]
        private CreatorPropertiesResponse(
            string provisioningState,

            int storageUnits)
        {
            ProvisioningState = provisioningState;
            StorageUnits = storageUnits;
        }
    }
}
