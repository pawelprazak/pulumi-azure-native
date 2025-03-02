// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EventHub.V20180101Preview
{
    /// <summary>
    /// Single Namespace item in List or Get Operation
    /// </summary>
    [AzureNativeResourceType("azure-native:eventhub/v20180101preview:Namespace")]
    public partial class Namespace : Pulumi.CustomResource
    {
        /// <summary>
        /// Cluster ARM ID of the Namespace.
        /// </summary>
        [Output("clusterArmId")]
        public Output<string?> ClusterArmId { get; private set; } = null!;

        /// <summary>
        /// The time the Namespace was created.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Properties of BYOK Encryption description
        /// </summary>
        [Output("encryption")]
        public Output<Outputs.EncryptionResponse?> Encryption { get; private set; } = null!;

        /// <summary>
        /// Properties of BYOK Identity description
        /// </summary>
        [Output("identity")]
        public Output<Outputs.IdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// Value that indicates whether AutoInflate is enabled for eventhub namespace.
        /// </summary>
        [Output("isAutoInflateEnabled")]
        public Output<bool?> IsAutoInflateEnabled { get; private set; } = null!;

        /// <summary>
        /// Value that indicates whether Kafka is enabled for eventhub namespace.
        /// </summary>
        [Output("kafkaEnabled")]
        public Output<bool?> KafkaEnabled { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true)
        /// </summary>
        [Output("maximumThroughputUnits")]
        public Output<int?> MaximumThroughputUnits { get; private set; } = null!;

        /// <summary>
        /// Identifier for Azure Insights metrics.
        /// </summary>
        [Output("metricId")]
        public Output<string> MetricId { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the Namespace.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Endpoint you can use to perform Service Bus operations.
        /// </summary>
        [Output("serviceBusEndpoint")]
        public Output<string> ServiceBusEndpoint { get; private set; } = null!;

        /// <summary>
        /// Properties of sku resource
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Status of the Namespace.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

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
        /// The time the Namespace was updated.
        /// </summary>
        [Output("updatedAt")]
        public Output<string> UpdatedAt { get; private set; } = null!;

        /// <summary>
        /// Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones.
        /// </summary>
        [Output("zoneRedundant")]
        public Output<bool?> ZoneRedundant { get; private set; } = null!;


        /// <summary>
        /// Create a Namespace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Namespace(string name, NamespaceArgs args, CustomResourceOptions? options = null)
            : base("azure-native:eventhub/v20180101preview:Namespace", name, args ?? new NamespaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Namespace(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:eventhub/v20180101preview:Namespace", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:eventhub:Namespace"},
                    new Pulumi.Alias { Type = "azure-native:eventhub/v20140901:Namespace"},
                    new Pulumi.Alias { Type = "azure-native:eventhub/v20150801:Namespace"},
                    new Pulumi.Alias { Type = "azure-native:eventhub/v20170401:Namespace"},
                    new Pulumi.Alias { Type = "azure-native:eventhub/v20210101preview:Namespace"},
                    new Pulumi.Alias { Type = "azure-native:eventhub/v20210601preview:Namespace"},
                    new Pulumi.Alias { Type = "azure-native:eventhub/v20211101:Namespace"},
                    new Pulumi.Alias { Type = "azure-native:eventhub/v20220101preview:Namespace"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Namespace resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Namespace Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Namespace(name, id, options);
        }
    }

    public sealed class NamespaceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cluster ARM ID of the Namespace.
        /// </summary>
        [Input("clusterArmId")]
        public Input<string>? ClusterArmId { get; set; }

        /// <summary>
        /// Properties of BYOK Encryption description
        /// </summary>
        [Input("encryption")]
        public Input<Inputs.EncryptionArgs>? Encryption { get; set; }

        /// <summary>
        /// Properties of BYOK Identity description
        /// </summary>
        [Input("identity")]
        public Input<Inputs.IdentityArgs>? Identity { get; set; }

        /// <summary>
        /// Value that indicates whether AutoInflate is enabled for eventhub namespace.
        /// </summary>
        [Input("isAutoInflateEnabled")]
        public Input<bool>? IsAutoInflateEnabled { get; set; }

        /// <summary>
        /// Value that indicates whether Kafka is enabled for eventhub namespace.
        /// </summary>
        [Input("kafkaEnabled")]
        public Input<bool>? KafkaEnabled { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true)
        /// </summary>
        [Input("maximumThroughputUnits")]
        public Input<int>? MaximumThroughputUnits { get; set; }

        /// <summary>
        /// The Namespace name
        /// </summary>
        [Input("namespaceName")]
        public Input<string>? NamespaceName { get; set; }

        /// <summary>
        /// Name of the resource group within the azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Properties of sku resource
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

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
        /// Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones.
        /// </summary>
        [Input("zoneRedundant")]
        public Input<bool>? ZoneRedundant { get; set; }

        public NamespaceArgs()
        {
        }
    }
}
