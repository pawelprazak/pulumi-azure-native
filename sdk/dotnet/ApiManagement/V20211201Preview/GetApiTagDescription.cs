// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ApiManagement.V20211201Preview
{
    public static class GetApiTagDescription
    {
        /// <summary>
        /// Contract details.
        /// </summary>
        public static Task<GetApiTagDescriptionResult> InvokeAsync(GetApiTagDescriptionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApiTagDescriptionResult>("azure-native:apimanagement/v20211201preview:getApiTagDescription", args ?? new GetApiTagDescriptionArgs(), options.WithDefaults());

        /// <summary>
        /// Contract details.
        /// </summary>
        public static Output<GetApiTagDescriptionResult> Invoke(GetApiTagDescriptionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetApiTagDescriptionResult>("azure-native:apimanagement/v20211201preview:getApiTagDescription", args ?? new GetApiTagDescriptionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApiTagDescriptionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
        /// </summary>
        [Input("apiId", required: true)]
        public string ApiId { get; set; } = null!;

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

        /// <summary>
        /// Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names.
        /// </summary>
        [Input("tagDescriptionId", required: true)]
        public string TagDescriptionId { get; set; } = null!;

        public GetApiTagDescriptionArgs()
        {
        }
    }

    public sealed class GetApiTagDescriptionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

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

        /// <summary>
        /// Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names.
        /// </summary>
        [Input("tagDescriptionId", required: true)]
        public Input<string> TagDescriptionId { get; set; } = null!;

        public GetApiTagDescriptionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApiTagDescriptionResult
    {
        /// <summary>
        /// Description of the Tag.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Tag name.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// Description of the external resources describing the tag.
        /// </summary>
        public readonly string? ExternalDocsDescription;
        /// <summary>
        /// Absolute URL of external resources describing the tag.
        /// </summary>
        public readonly string? ExternalDocsUrl;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Identifier of the tag in the form of /tags/{tagId}
        /// </summary>
        public readonly string? TagId;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetApiTagDescriptionResult(
            string? description,

            string? displayName,

            string? externalDocsDescription,

            string? externalDocsUrl,

            string id,

            string name,

            string? tagId,

            string type)
        {
            Description = description;
            DisplayName = displayName;
            ExternalDocsDescription = externalDocsDescription;
            ExternalDocsUrl = externalDocsUrl;
            Id = id;
            Name = name;
            TagId = tagId;
            Type = type;
        }
    }
}
