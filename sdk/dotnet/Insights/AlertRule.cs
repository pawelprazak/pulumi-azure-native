// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights
{
    /// <summary>
    /// The alert rule resource.
    /// API Version: 2016-03-01.
    /// </summary>
    [AzureNativeResourceType("azure-native:insights:AlertRule")]
    public partial class AlertRule : Pulumi.CustomResource
    {
        /// <summary>
        /// action that is performed when the alert rule becomes active, and when an alert condition is resolved.
        /// </summary>
        [Output("action")]
        public Output<Union<Outputs.RuleEmailActionResponse, Outputs.RuleWebhookActionResponse>?> Action { get; private set; } = null!;

        /// <summary>
        /// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
        /// </summary>
        [Output("actions")]
        public Output<ImmutableArray<Union<Outputs.RuleEmailActionResponse, Outputs.RuleWebhookActionResponse>>> Actions { get; private set; } = null!;

        /// <summary>
        /// the condition that results in the alert rule being activated.
        /// </summary>
        [Output("condition")]
        public Output<object> Condition { get; private set; } = null!;

        /// <summary>
        /// the description of the alert rule that will be included in the alert email.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// the flag that indicates whether the alert rule is enabled.
        /// </summary>
        [Output("isEnabled")]
        public Output<bool> IsEnabled { get; private set; } = null!;

        /// <summary>
        /// Last time the rule was updated in ISO8601 format.
        /// </summary>
        [Output("lastUpdatedTime")]
        public Output<string> LastUpdatedTime { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Azure resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// the provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Azure resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a AlertRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AlertRule(string name, AlertRuleArgs args, CustomResourceOptions? options = null)
            : base("azure-native:insights:AlertRule", name, args ?? new AlertRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AlertRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:insights:AlertRule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:insights/v20140401:AlertRule"},
                    new Pulumi.Alias { Type = "azure-native:insights/v20160301:AlertRule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AlertRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AlertRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AlertRule(name, id, options);
        }
    }

    public sealed class AlertRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// action that is performed when the alert rule becomes active, and when an alert condition is resolved.
        /// </summary>
        [Input("action")]
        public InputUnion<Inputs.RuleEmailActionArgs, Inputs.RuleWebhookActionArgs>? Action { get; set; }

        [Input("actions")]
        private InputList<Union<Inputs.RuleEmailActionArgs, Inputs.RuleWebhookActionArgs>>? _actions;

        /// <summary>
        /// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
        /// </summary>
        public InputList<Union<Inputs.RuleEmailActionArgs, Inputs.RuleWebhookActionArgs>> Actions
        {
            get => _actions ?? (_actions = new InputList<Union<Inputs.RuleEmailActionArgs, Inputs.RuleWebhookActionArgs>>());
            set => _actions = value;
        }

        /// <summary>
        /// the condition that results in the alert rule being activated.
        /// </summary>
        [Input("condition", required: true)]
        public object Condition { get; set; } = null!;

        /// <summary>
        /// the description of the alert rule that will be included in the alert email.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// the flag that indicates whether the alert rule is enabled.
        /// </summary>
        [Input("isEnabled", required: true)]
        public Input<bool> IsEnabled { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// the name of the alert rule.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// the provisioning state.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

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

        public AlertRuleArgs()
        {
        }
    }
}
