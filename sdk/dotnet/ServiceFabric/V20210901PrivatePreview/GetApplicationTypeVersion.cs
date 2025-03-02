// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceFabric.V20210901PrivatePreview
{
    public static class GetApplicationTypeVersion
    {
        /// <summary>
        /// An application type version resource for the specified application type name resource.
        /// </summary>
        public static Task<GetApplicationTypeVersionResult> InvokeAsync(GetApplicationTypeVersionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApplicationTypeVersionResult>("azure-native:servicefabric/v20210901privatepreview:getApplicationTypeVersion", args ?? new GetApplicationTypeVersionArgs(), options.WithDefaults());

        /// <summary>
        /// An application type version resource for the specified application type name resource.
        /// </summary>
        public static Output<GetApplicationTypeVersionResult> Invoke(GetApplicationTypeVersionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetApplicationTypeVersionResult>("azure-native:servicefabric/v20210901privatepreview:getApplicationTypeVersion", args ?? new GetApplicationTypeVersionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApplicationTypeVersionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application type name resource.
        /// </summary>
        [Input("applicationTypeName", required: true)]
        public string ApplicationTypeName { get; set; } = null!;

        /// <summary>
        /// The name of the cluster resource.
        /// </summary>
        [Input("clusterName", required: true)]
        public string ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The application type version.
        /// </summary>
        [Input("version", required: true)]
        public string Version { get; set; } = null!;

        public GetApplicationTypeVersionArgs()
        {
        }
    }

    public sealed class GetApplicationTypeVersionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application type name resource.
        /// </summary>
        [Input("applicationTypeName", required: true)]
        public Input<string> ApplicationTypeName { get; set; } = null!;

        /// <summary>
        /// The name of the cluster resource.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The application type version.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public GetApplicationTypeVersionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApplicationTypeVersionResult
    {
        /// <summary>
        /// The URL to the application package
        /// </summary>
        public readonly string AppPackageUrl;
        /// <summary>
        /// Azure resource identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location depends on the parent resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Azure resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Azure resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Azure resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetApplicationTypeVersionResult(
            string appPackageUrl,

            string id,

            string? location,

            string name,

            string provisioningState,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            AppPackageUrl = appPackageUrl;
            Id = id;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
