// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20210601Preview.Outputs
{

    /// <summary>
    /// Deployment settings payload
    /// </summary>
    [OutputType]
    public sealed class DeploymentSettingsResponse
    {
        /// <summary>
        /// Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from API version 2021-06-01-preview. Please use the resourceRequests field to set the CPU size.
        /// </summary>
        public readonly int? Cpu;
        /// <summary>
        /// Collection of environment variables
        /// </summary>
        public readonly ImmutableDictionary<string, string>? EnvironmentVariables;
        /// <summary>
        /// JVM parameter
        /// </summary>
        public readonly string? JvmOptions;
        /// <summary>
        /// Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This is deprecated starting from API version 2021-06-01-preview. Please use the resourceRequests field to set the the memory size.
        /// </summary>
        public readonly int? MemoryInGB;
        /// <summary>
        /// The path to the .NET executable relative to zip root
        /// </summary>
        public readonly string? NetCoreMainEntryPath;
        /// <summary>
        /// The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the required CPU and Memory, the old field cpu and memoryInGB will be deprecated later.
        /// </summary>
        public readonly Outputs.ResourceRequestsResponse? ResourceRequests;
        /// <summary>
        /// Runtime version
        /// </summary>
        public readonly string? RuntimeVersion;

        [OutputConstructor]
        private DeploymentSettingsResponse(
            int? cpu,

            ImmutableDictionary<string, string>? environmentVariables,

            string? jvmOptions,

            int? memoryInGB,

            string? netCoreMainEntryPath,

            Outputs.ResourceRequestsResponse? resourceRequests,

            string? runtimeVersion)
        {
            Cpu = cpu;
            EnvironmentVariables = environmentVariables;
            JvmOptions = jvmOptions;
            MemoryInGB = memoryInGB;
            NetCoreMainEntryPath = netCoreMainEntryPath;
            ResourceRequests = resourceRequests;
            RuntimeVersion = runtimeVersion;
        }
    }
}
