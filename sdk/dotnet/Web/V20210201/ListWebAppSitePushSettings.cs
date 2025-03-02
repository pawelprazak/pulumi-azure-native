// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20210201
{
    public static class ListWebAppSitePushSettings
    {
        /// <summary>
        /// Push settings for the App.
        /// </summary>
        public static Task<ListWebAppSitePushSettingsResult> InvokeAsync(ListWebAppSitePushSettingsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppSitePushSettingsResult>("azure-native:web/v20210201:listWebAppSitePushSettings", args ?? new ListWebAppSitePushSettingsArgs(), options.WithDefaults());

        /// <summary>
        /// Push settings for the App.
        /// </summary>
        public static Output<ListWebAppSitePushSettingsResult> Invoke(ListWebAppSitePushSettingsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListWebAppSitePushSettingsResult>("azure-native:web/v20210201:listWebAppSitePushSettings", args ?? new ListWebAppSitePushSettingsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListWebAppSitePushSettingsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of web app.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListWebAppSitePushSettingsArgs()
        {
        }
    }

    public sealed class ListWebAppSitePushSettingsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of web app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListWebAppSitePushSettingsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppSitePushSettingsResult
    {
        /// <summary>
        /// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
        /// </summary>
        public readonly string? DynamicTagsJson;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Gets or sets a flag indicating whether the Push endpoint is enabled.
        /// </summary>
        public readonly bool IsPushEnabled;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
        /// </summary>
        public readonly string? TagWhitelistJson;
        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'. 
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        public readonly string? TagsRequiringAuth;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListWebAppSitePushSettingsResult(
            string? dynamicTagsJson,

            string id,

            bool isPushEnabled,

            string? kind,

            string name,

            string? tagWhitelistJson,

            string? tagsRequiringAuth,

            string type)
        {
            DynamicTagsJson = dynamicTagsJson;
            Id = id;
            IsPushEnabled = isPushEnabled;
            Kind = kind;
            Name = name;
            TagWhitelistJson = tagWhitelistJson;
            TagsRequiringAuth = tagsRequiringAuth;
            Type = type;
        }
    }
}
