// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20151001
{
    public static class GetMediaService
    {
        /// <summary>
        /// The properties of a Media Service resource.
        /// </summary>
        public static Task<GetMediaServiceResult> InvokeAsync(GetMediaServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMediaServiceResult>("azure-native:media/v20151001:getMediaService", args ?? new GetMediaServiceArgs(), options.WithDefaults());

        /// <summary>
        /// The properties of a Media Service resource.
        /// </summary>
        public static Output<GetMediaServiceResult> Invoke(GetMediaServiceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetMediaServiceResult>("azure-native:media/v20151001:getMediaService", args ?? new GetMediaServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMediaServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Media Service.
        /// </summary>
        [Input("mediaServiceName", required: true)]
        public string MediaServiceName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetMediaServiceArgs()
        {
        }
    }

    public sealed class GetMediaServiceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Media Service.
        /// </summary>
        [Input("mediaServiceName", required: true)]
        public Input<string> MediaServiceName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetMediaServiceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMediaServiceResult
    {
        /// <summary>
        /// Read-only property that lists the Media Services REST API endpoints for this resource. If supplied on a PUT or PATCH, the value will be ignored.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApiEndpointResponse> ApiEndpoints;
        /// <summary>
        /// The id of the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The geographic location of the resource. This must be one of the supported and registered Azure Geo Regions (for example, West US, East US, Southeast Asia, and so forth).
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The storage accounts for this resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.StorageAccountResponse> StorageAccounts;
        /// <summary>
        /// Tags to help categorize the resource in the Azure portal.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetMediaServiceResult(
            ImmutableArray<Outputs.ApiEndpointResponse> apiEndpoints,

            string id,

            string? location,

            string name,

            ImmutableArray<Outputs.StorageAccountResponse> storageAccounts,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            ApiEndpoints = apiEndpoints;
            Id = id;
            Location = location;
            Name = name;
            StorageAccounts = storageAccounts;
            Tags = tags;
            Type = type;
        }
    }
}
