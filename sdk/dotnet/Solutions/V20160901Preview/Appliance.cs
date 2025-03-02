// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Solutions.V20160901Preview
{
    /// <summary>
    /// Information about appliance.
    /// </summary>
    [Obsolete(@"Version 2016-09-01-preview will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:solutions/v20160901preview:Appliance")]
    public partial class Appliance : Pulumi.CustomResource
    {
        /// <summary>
        /// The fully qualified path of appliance definition Id.
        /// </summary>
        [Output("applianceDefinitionId")]
        public Output<string?> ApplianceDefinitionId { get; private set; } = null!;

        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.IdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// The kind of the appliance. Allowed values are MarketPlace and ServiceCatalog.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// ID of the resource that manages this resource.
        /// </summary>
        [Output("managedBy")]
        public Output<string?> ManagedBy { get; private set; } = null!;

        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        [Output("managedResourceGroupId")]
        public Output<string> ManagedResourceGroupId { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Name and value pairs that define the appliance outputs.
        /// </summary>
        [Output("outputs")]
        public Output<object> Outputs { get; private set; } = null!;

        /// <summary>
        /// Name and value pairs that define the appliance parameters. It can be a JObject or a well formed JSON string.
        /// </summary>
        [Output("parameters")]
        public Output<object?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The plan information.
        /// </summary>
        [Output("plan")]
        public Output<Outputs.PlanResponse?> Plan { get; private set; } = null!;

        /// <summary>
        /// The appliance provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The blob URI where the UI definition file is located.
        /// </summary>
        [Output("uiDefinitionUri")]
        public Output<string?> UiDefinitionUri { get; private set; } = null!;


        /// <summary>
        /// Create a Appliance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Appliance(string name, ApplianceArgs args, CustomResourceOptions? options = null)
            : base("azure-native:solutions/v20160901preview:Appliance", name, args ?? new ApplianceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Appliance(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:solutions/v20160901preview:Appliance", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:solutions:Appliance"},
                    new Pulumi.Alias { Type = "azure-native:solutions/v20170901:Appliance"},
                    new Pulumi.Alias { Type = "azure-native:solutions/v20180601:Appliance"},
                    new Pulumi.Alias { Type = "azure-native:solutions/v20190701:Appliance"},
                    new Pulumi.Alias { Type = "azure-native:solutions/v20200821preview:Appliance"},
                    new Pulumi.Alias { Type = "azure-native:solutions/v20210701:Appliance"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Appliance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Appliance Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Appliance(name, id, options);
        }
    }

    public sealed class ApplianceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The fully qualified path of appliance definition Id.
        /// </summary>
        [Input("applianceDefinitionId")]
        public Input<string>? ApplianceDefinitionId { get; set; }

        /// <summary>
        /// The name of the appliance.
        /// </summary>
        [Input("applianceName")]
        public Input<string>? ApplianceName { get; set; }

        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.IdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The kind of the appliance. Allowed values are MarketPlace and ServiceCatalog.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// ID of the resource that manages this resource.
        /// </summary>
        [Input("managedBy")]
        public Input<string>? ManagedBy { get; set; }

        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        [Input("managedResourceGroupId", required: true)]
        public Input<string> ManagedResourceGroupId { get; set; } = null!;

        /// <summary>
        /// Name and value pairs that define the appliance parameters. It can be a JObject or a well formed JSON string.
        /// </summary>
        [Input("parameters")]
        public Input<object>? Parameters { get; set; }

        /// <summary>
        /// The plan information.
        /// </summary>
        [Input("plan")]
        public Input<Inputs.PlanArgs>? Plan { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The blob URI where the UI definition file is located.
        /// </summary>
        [Input("uiDefinitionUri")]
        public Input<string>? UiDefinitionUri { get; set; }

        public ApplianceArgs()
        {
        }
    }
}
