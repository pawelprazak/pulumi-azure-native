// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ApiManagement.V20210401Preview
{
    public static class GetContentItem
    {
        /// <summary>
        /// Content type contract details.
        /// </summary>
        public static Task<GetContentItemResult> InvokeAsync(GetContentItemArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetContentItemResult>("azure-native:apimanagement/v20210401preview:getContentItem", args ?? new GetContentItemArgs(), options.WithDefaults());

        /// <summary>
        /// Content type contract details.
        /// </summary>
        public static Output<GetContentItemResult> Invoke(GetContentItemInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetContentItemResult>("azure-native:apimanagement/v20210401preview:getContentItem", args ?? new GetContentItemInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetContentItemArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Content item identifier.
        /// </summary>
        [Input("contentItemId", required: true)]
        public string ContentItemId { get; set; } = null!;

        /// <summary>
        /// Content type identifier.
        /// </summary>
        [Input("contentTypeId", required: true)]
        public string ContentTypeId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetContentItemArgs()
        {
        }
    }

    public sealed class GetContentItemInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Content item identifier.
        /// </summary>
        [Input("contentItemId", required: true)]
        public Input<string> ContentItemId { get; set; } = null!;

        /// <summary>
        /// Content type identifier.
        /// </summary>
        [Input("contentTypeId", required: true)]
        public Input<string> ContentTypeId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public GetContentItemInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetContentItemResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Properties of the content item.
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetContentItemResult(
            string id,

            string name,

            object properties,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
