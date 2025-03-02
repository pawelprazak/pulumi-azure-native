// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerRegistry.V20180201Preview
{
    public static class GetBuildTask
    {
        /// <summary>
        /// The build task that has the resource properties and all build items. The build task will have all information to schedule a build against it.
        /// </summary>
        public static Task<GetBuildTaskResult> InvokeAsync(GetBuildTaskArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBuildTaskResult>("azure-native:containerregistry/v20180201preview:getBuildTask", args ?? new GetBuildTaskArgs(), options.WithDefaults());

        /// <summary>
        /// The build task that has the resource properties and all build items. The build task will have all information to schedule a build against it.
        /// </summary>
        public static Output<GetBuildTaskResult> Invoke(GetBuildTaskInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBuildTaskResult>("azure-native:containerregistry/v20180201preview:getBuildTask", args ?? new GetBuildTaskInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBuildTaskArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the container registry build task.
        /// </summary>
        [Input("buildTaskName", required: true)]
        public string BuildTaskName { get; set; } = null!;

        /// <summary>
        /// The name of the container registry.
        /// </summary>
        [Input("registryName", required: true)]
        public string RegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetBuildTaskArgs()
        {
        }
    }

    public sealed class GetBuildTaskInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the container registry build task.
        /// </summary>
        [Input("buildTaskName", required: true)]
        public Input<string> BuildTaskName { get; set; } = null!;

        /// <summary>
        /// The name of the container registry.
        /// </summary>
        [Input("registryName", required: true)]
        public Input<string> RegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetBuildTaskInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBuildTaskResult
    {
        /// <summary>
        /// The alternative updatable name for a build task.
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// The creation date of build task.
        /// </summary>
        public readonly string CreationDate;
        /// <summary>
        /// The resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The location of the resource. This cannot be changed after the resource is created.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The platform properties against which the build has to happen.
        /// </summary>
        public readonly Outputs.PlatformPropertiesResponse Platform;
        /// <summary>
        /// The provisioning state of the build task.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The properties that describes the source(code) for the build task.
        /// </summary>
        public readonly Outputs.SourceRepositoryPropertiesResponse SourceRepository;
        /// <summary>
        /// The current status of build task.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// The tags of the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Build timeout in seconds.
        /// </summary>
        public readonly int? Timeout;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetBuildTaskResult(
            string alias,

            string creationDate,

            string id,

            string location,

            string name,

            Outputs.PlatformPropertiesResponse platform,

            string provisioningState,

            Outputs.SourceRepositoryPropertiesResponse sourceRepository,

            string? status,

            ImmutableDictionary<string, string>? tags,

            int? timeout,

            string type)
        {
            Alias = alias;
            CreationDate = creationDate;
            Id = id;
            Location = location;
            Name = name;
            Platform = platform;
            ProvisioningState = provisioningState;
            SourceRepository = sourceRepository;
            Status = status;
            Tags = tags;
            Timeout = timeout;
            Type = type;
        }
    }
}
