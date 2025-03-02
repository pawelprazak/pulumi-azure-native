// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Blueprint.V20171111Preview
{
    /// <summary>
    /// Represents a Blueprint assignment.
    /// </summary>
    [Obsolete(@"Version 2017-11-11-preview will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:blueprint/v20171111preview:Assignment")]
    public partial class Assignment : Pulumi.CustomResource
    {
        /// <summary>
        /// ID of the Blueprint definition resource.
        /// </summary>
        [Output("blueprintId")]
        public Output<string?> BlueprintId { get; private set; } = null!;

        /// <summary>
        /// Multi-line explain this resource.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// One-liner string explain this resource.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Managed Service Identity for this Blueprint assignment
        /// </summary>
        [Output("identity")]
        public Output<Outputs.ManagedServiceIdentityResponse> Identity { get; private set; } = null!;

        /// <summary>
        /// The location of this Blueprint assignment.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Defines how Blueprint-managed resources will be locked.
        /// </summary>
        [Output("locks")]
        public Output<Outputs.AssignmentLockSettingsResponse?> Locks { get; private set; } = null!;

        /// <summary>
        /// Name of this resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Blueprint parameter values.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, Outputs.ParameterValueBaseResponse>> Parameters { get; private set; } = null!;

        /// <summary>
        /// State of the assignment.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Names and locations of resource group placeholders.
        /// </summary>
        [Output("resourceGroups")]
        public Output<ImmutableDictionary<string, Outputs.ResourceGroupValueResponse>> ResourceGroups { get; private set; } = null!;

        /// <summary>
        /// Status of Blueprint assignment. This field is readonly.
        /// </summary>
        [Output("status")]
        public Output<Outputs.AssignmentStatusResponse> Status { get; private set; } = null!;

        /// <summary>
        /// Type of this resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Assignment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Assignment(string name, AssignmentArgs args, CustomResourceOptions? options = null)
            : base("azure-native:blueprint/v20171111preview:Assignment", name, args ?? new AssignmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Assignment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:blueprint/v20171111preview:Assignment", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Assignment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Assignment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Assignment(name, id, options);
        }
    }

    public sealed class AssignmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// name of the assignment.
        /// </summary>
        [Input("assignmentName")]
        public Input<string>? AssignmentName { get; set; }

        /// <summary>
        /// ID of the Blueprint definition resource.
        /// </summary>
        [Input("blueprintId")]
        public Input<string>? BlueprintId { get; set; }

        /// <summary>
        /// Multi-line explain this resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// One-liner string explain this resource.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Managed Service Identity for this Blueprint assignment
        /// </summary>
        [Input("identity", required: true)]
        public Input<Inputs.ManagedServiceIdentityArgs> Identity { get; set; } = null!;

        /// <summary>
        /// The location of this Blueprint assignment.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Defines how Blueprint-managed resources will be locked.
        /// </summary>
        [Input("locks")]
        public Input<Inputs.AssignmentLockSettingsArgs>? Locks { get; set; }

        [Input("parameters", required: true)]
        private InputMap<Inputs.ParameterValueBaseArgs>? _parameters;

        /// <summary>
        /// Blueprint parameter values.
        /// </summary>
        public InputMap<Inputs.ParameterValueBaseArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterValueBaseArgs>());
            set => _parameters = value;
        }

        [Input("resourceGroups", required: true)]
        private InputMap<Inputs.ResourceGroupValueArgs>? _resourceGroups;

        /// <summary>
        /// Names and locations of resource group placeholders.
        /// </summary>
        public InputMap<Inputs.ResourceGroupValueArgs> ResourceGroups
        {
            get => _resourceGroups ?? (_resourceGroups = new InputMap<Inputs.ResourceGroupValueArgs>());
            set => _resourceGroups = value;
        }

        /// <summary>
        /// azure subscriptionId, which we assign the blueprint to.
        /// </summary>
        [Input("subscriptionId")]
        public Input<string>? SubscriptionId { get; set; }

        public AssignmentArgs()
        {
        }
    }
}
