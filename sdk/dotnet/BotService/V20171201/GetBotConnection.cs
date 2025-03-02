// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.BotService.V20171201
{
    [Obsolete(@"Version 2017-12-01 will be removed in v2 of the provider.")]
    public static class GetBotConnection
    {
        /// <summary>
        /// Bot channel resource definition
        /// </summary>
        public static Task<GetBotConnectionResult> InvokeAsync(GetBotConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBotConnectionResult>("azure-native:botservice/v20171201:getBotConnection", args ?? new GetBotConnectionArgs(), options.WithDefaults());

        /// <summary>
        /// Bot channel resource definition
        /// </summary>
        public static Output<GetBotConnectionResult> Invoke(GetBotConnectionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBotConnectionResult>("azure-native:botservice/v20171201:getBotConnection", args ?? new GetBotConnectionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBotConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Bot Service Connection Setting resource
        /// </summary>
        [Input("connectionName", required: true)]
        public string ConnectionName { get; set; } = null!;

        /// <summary>
        /// The name of the Bot resource group in the user subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Bot resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public GetBotConnectionArgs()
        {
        }
    }

    public sealed class GetBotConnectionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Bot Service Connection Setting resource
        /// </summary>
        [Input("connectionName", required: true)]
        public Input<string> ConnectionName { get; set; } = null!;

        /// <summary>
        /// The name of the Bot resource group in the user subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Bot resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        public GetBotConnectionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBotConnectionResult
    {
        /// <summary>
        /// Entity Tag
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Specifies the resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Required. Gets or sets the Kind of the resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Specifies the name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The set of properties specific to bot channel resource
        /// </summary>
        public readonly Outputs.ConnectionSettingPropertiesResponse Properties;
        /// <summary>
        /// Gets or sets the SKU of the resource.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Specifies the type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetBotConnectionResult(
            string? etag,

            string id,

            string? kind,

            string? location,

            string name,

            Outputs.ConnectionSettingPropertiesResponse properties,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Etag = etag;
            Id = id;
            Kind = kind;
            Location = location;
            Name = name;
            Properties = properties;
            Sku = sku;
            Tags = tags;
            Type = type;
        }
    }
}
