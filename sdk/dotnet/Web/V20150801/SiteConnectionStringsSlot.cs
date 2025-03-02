// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20150801
{
    /// <summary>
    /// String dictionary resource
    /// </summary>
    [Obsolete(@"Version 2015-08-01 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:web/v20150801:SiteConnectionStringsSlot")]
    public partial class SiteConnectionStringsSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// Kind of resource
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Connection strings
        /// </summary>
        [Output("properties")]
        public Output<ImmutableDictionary<string, Outputs.ConnStringValueTypePairResponse>> Properties { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SiteConnectionStringsSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SiteConnectionStringsSlot(string name, SiteConnectionStringsSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-native:web/v20150801:SiteConnectionStringsSlot", name, args ?? new SiteConnectionStringsSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SiteConnectionStringsSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:web/v20150801:SiteConnectionStringsSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:web:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20160801:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20180201:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20181101:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20190801:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20200601:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20200901:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20201001:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20201201:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210101:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210115:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210201:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210301:SiteConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-native:web/v20220301:SiteConnectionStringsSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SiteConnectionStringsSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SiteConnectionStringsSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SiteConnectionStringsSlot(name, id, options);
        }
    }

    public sealed class SiteConnectionStringsSlotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("properties")]
        private InputMap<Inputs.ConnStringValueTypePairArgs>? _properties;

        /// <summary>
        /// Connection strings
        /// </summary>
        public InputMap<Inputs.ConnStringValueTypePairArgs> Properties
        {
            get => _properties ?? (_properties = new InputMap<Inputs.ConnStringValueTypePairArgs>());
            set => _properties = value;
        }

        /// <summary>
        /// Name of resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of web app slot. If not specified then will default to production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

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
        /// Resource type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public SiteConnectionStringsSlotArgs()
        {
        }
    }
}
