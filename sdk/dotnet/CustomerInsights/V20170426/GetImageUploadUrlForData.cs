// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CustomerInsights.V20170426
{
    public static class GetImageUploadUrlForData
    {
        /// <summary>
        /// The image definition.
        /// </summary>
        public static Task<GetImageUploadUrlForDataResult> InvokeAsync(GetImageUploadUrlForDataArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetImageUploadUrlForDataResult>("azure-native:customerinsights/v20170426:getImageUploadUrlForData", args ?? new GetImageUploadUrlForDataArgs(), options.WithDefaults());

        /// <summary>
        /// The image definition.
        /// </summary>
        public static Output<GetImageUploadUrlForDataResult> Invoke(GetImageUploadUrlForDataInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetImageUploadUrlForDataResult>("azure-native:customerinsights/v20170426:getImageUploadUrlForData", args ?? new GetImageUploadUrlForDataInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetImageUploadUrlForDataArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Type of entity. Can be Profile or Interaction.
        /// </summary>
        [Input("entityType")]
        public string? EntityType { get; set; }

        /// <summary>
        /// Name of the entity type.
        /// </summary>
        [Input("entityTypeName")]
        public string? EntityTypeName { get; set; }

        /// <summary>
        /// The name of the hub.
        /// </summary>
        [Input("hubName", required: true)]
        public string HubName { get; set; } = null!;

        /// <summary>
        /// Relative path of the image.
        /// </summary>
        [Input("relativePath")]
        public string? RelativePath { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetImageUploadUrlForDataArgs()
        {
        }
    }

    public sealed class GetImageUploadUrlForDataInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Type of entity. Can be Profile or Interaction.
        /// </summary>
        [Input("entityType")]
        public Input<string>? EntityType { get; set; }

        /// <summary>
        /// Name of the entity type.
        /// </summary>
        [Input("entityTypeName")]
        public Input<string>? EntityTypeName { get; set; }

        /// <summary>
        /// The name of the hub.
        /// </summary>
        [Input("hubName", required: true)]
        public Input<string> HubName { get; set; } = null!;

        /// <summary>
        /// Relative path of the image.
        /// </summary>
        [Input("relativePath")]
        public Input<string>? RelativePath { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetImageUploadUrlForDataInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetImageUploadUrlForDataResult
    {
        /// <summary>
        /// Content URL for the image blob.
        /// </summary>
        public readonly string? ContentUrl;
        /// <summary>
        /// Whether image exists already.
        /// </summary>
        public readonly bool? ImageExists;
        /// <summary>
        /// Relative path of the image.
        /// </summary>
        public readonly string? RelativePath;

        [OutputConstructor]
        private GetImageUploadUrlForDataResult(
            string? contentUrl,

            bool? imageExists,

            string? relativePath)
        {
            ContentUrl = contentUrl;
            ImageExists = imageExists;
            RelativePath = relativePath;
        }
    }
}
