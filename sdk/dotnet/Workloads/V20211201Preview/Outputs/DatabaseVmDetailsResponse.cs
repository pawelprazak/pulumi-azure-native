// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.V20211201Preview.Outputs
{

    /// <summary>
    /// The Database VM Details.
    /// </summary>
    [OutputType]
    public sealed class DatabaseVmDetailsResponse
    {
        /// <summary>
        /// Defines the SAP Instance status.
        /// </summary>
        public readonly string Status;
        public readonly string VirtualMachineId;

        [OutputConstructor]
        private DatabaseVmDetailsResponse(
            string status,

            string virtualMachineId)
        {
            Status = status;
            VirtualMachineId = virtualMachineId;
        }
    }
}
