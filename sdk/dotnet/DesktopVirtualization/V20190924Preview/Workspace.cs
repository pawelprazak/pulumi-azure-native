// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DesktopVirtualization.V20190924Preview
{
    /// <summary>
    /// Represents a Workspace definition.
    /// </summary>
    [Obsolete(@"Version 2019-09-24-preview will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:desktopvirtualization/v20190924preview:Workspace")]
    public partial class Workspace : Pulumi.CustomResource
    {
        /// <summary>
        /// List of applicationGroup resource Ids.
        /// </summary>
        [Output("applicationGroupReferences")]
        public Output<ImmutableArray<string>> ApplicationGroupReferences { get; private set; } = null!;

        /// <summary>
        /// Description of Workspace.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Friendly name of Workspace.
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Workspace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workspace(string name, WorkspaceArgs args, CustomResourceOptions? options = null)
            : base("azure-native:desktopvirtualization/v20190924preview:Workspace", name, args ?? new WorkspaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workspace(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:desktopvirtualization/v20190924preview:Workspace", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20190123preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20191210preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20200921preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20201019preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20201102preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20201110preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20210114preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20210201preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20210309preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20210401preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20210712:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20210903preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20220210preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-native:desktopvirtualization/v20220401preview:Workspace"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Workspace resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workspace Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Workspace(name, id, options);
        }
    }

    public sealed class WorkspaceArgs : Pulumi.ResourceArgs
    {
        [Input("applicationGroupReferences")]
        private InputList<string>? _applicationGroupReferences;

        /// <summary>
        /// List of applicationGroup resource Ids.
        /// </summary>
        public InputList<string> ApplicationGroupReferences
        {
            get => _applicationGroupReferences ?? (_applicationGroupReferences = new InputList<string>());
            set => _applicationGroupReferences = value;
        }

        /// <summary>
        /// Description of Workspace.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Friendly name of Workspace.
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName")]
        public Input<string>? WorkspaceName { get; set; }

        public WorkspaceArgs()
        {
        }
    }
}
