// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Batch.V20181201.Outputs
{

    [OutputType]
    public sealed class TaskContainerSettingsResponse
    {
        /// <summary>
        /// These additional options are supplied as arguments to the "docker create" command, in addition to those controlled by the Batch Service.
        /// </summary>
        public readonly string? ContainerRunOptions;
        /// <summary>
        /// This is the full image reference, as would be specified to "docker pull". If no tag is provided as part of the image name, the tag ":latest" is used as a default.
        /// </summary>
        public readonly string ImageName;
        /// <summary>
        /// This setting can be omitted if was already provided at pool creation.
        /// </summary>
        public readonly Outputs.ContainerRegistryResponse? Registry;

        [OutputConstructor]
        private TaskContainerSettingsResponse(
            string? containerRunOptions,

            string imageName,

            Outputs.ContainerRegistryResponse? registry)
        {
            ContainerRunOptions = containerRunOptions;
            ImageName = imageName;
            Registry = registry;
        }
    }
}
