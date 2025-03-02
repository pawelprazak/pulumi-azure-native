// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceBus.V20170401
{
    /// <summary>
    /// Description of a namespace authorization rule.
    /// </summary>
    [AzureNativeResourceType("azure-native:servicebus/v20170401:TopicAuthorizationRule")]
    public partial class TopicAuthorizationRule : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The rights associated with the rule.
        /// </summary>
        [Output("rights")]
        public Output<ImmutableArray<string>> Rights { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a TopicAuthorizationRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TopicAuthorizationRule(string name, TopicAuthorizationRuleArgs args, CustomResourceOptions? options = null)
            : base("azure-native:servicebus/v20170401:TopicAuthorizationRule", name, args ?? new TopicAuthorizationRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TopicAuthorizationRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:servicebus/v20170401:TopicAuthorizationRule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:servicebus:TopicAuthorizationRule"},
                    new Pulumi.Alias { Type = "azure-native:servicebus/v20140901:TopicAuthorizationRule"},
                    new Pulumi.Alias { Type = "azure-native:servicebus/v20150801:TopicAuthorizationRule"},
                    new Pulumi.Alias { Type = "azure-native:servicebus/v20180101preview:TopicAuthorizationRule"},
                    new Pulumi.Alias { Type = "azure-native:servicebus/v20210101preview:TopicAuthorizationRule"},
                    new Pulumi.Alias { Type = "azure-native:servicebus/v20210601preview:TopicAuthorizationRule"},
                    new Pulumi.Alias { Type = "azure-native:servicebus/v20211101:TopicAuthorizationRule"},
                    new Pulumi.Alias { Type = "azure-native:servicebus/v20220101preview:TopicAuthorizationRule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TopicAuthorizationRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TopicAuthorizationRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TopicAuthorizationRule(name, id, options);
        }
    }

    public sealed class TopicAuthorizationRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The authorization rule name.
        /// </summary>
        [Input("authorizationRuleName")]
        public Input<string>? AuthorizationRuleName { get; set; }

        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("rights", required: true)]
        private InputList<Pulumi.AzureNative.ServiceBus.V20170401.AccessRights>? _rights;

        /// <summary>
        /// The rights associated with the rule.
        /// </summary>
        public InputList<Pulumi.AzureNative.ServiceBus.V20170401.AccessRights> Rights
        {
            get => _rights ?? (_rights = new InputList<Pulumi.AzureNative.ServiceBus.V20170401.AccessRights>());
            set => _rights = value;
        }

        /// <summary>
        /// The topic name.
        /// </summary>
        [Input("topicName", required: true)]
        public Input<string> TopicName { get; set; } = null!;

        public TopicAuthorizationRuleArgs()
        {
        }
    }
}
