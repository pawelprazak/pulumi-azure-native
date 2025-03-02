// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EventHub.V20140901
{
    [Obsolete(@"Version 2014-09-01 will be removed in v2 of the provider.")]
    public static class GetConsumerGroup
    {
        /// <summary>
        /// Single item in List or Get Consumer group operation
        /// </summary>
        public static Task<GetConsumerGroupResult> InvokeAsync(GetConsumerGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConsumerGroupResult>("azure-native:eventhub/v20140901:getConsumerGroup", args ?? new GetConsumerGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Single item in List or Get Consumer group operation
        /// </summary>
        public static Output<GetConsumerGroupResult> Invoke(GetConsumerGroupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConsumerGroupResult>("azure-native:eventhub/v20140901:getConsumerGroup", args ?? new GetConsumerGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConsumerGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The consumer group name
        /// </summary>
        [Input("consumerGroupName", required: true)]
        public string ConsumerGroupName { get; set; } = null!;

        /// <summary>
        /// The Event Hub name
        /// </summary>
        [Input("eventHubName", required: true)]
        public string EventHubName { get; set; } = null!;

        /// <summary>
        /// The Namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetConsumerGroupArgs()
        {
        }
    }

    public sealed class GetConsumerGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The consumer group name
        /// </summary>
        [Input("consumerGroupName", required: true)]
        public Input<string> ConsumerGroupName { get; set; } = null!;

        /// <summary>
        /// The Event Hub name
        /// </summary>
        [Input("eventHubName", required: true)]
        public Input<string> EventHubName { get; set; } = null!;

        /// <summary>
        /// The Namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetConsumerGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConsumerGroupResult
    {
        /// <summary>
        /// Exact time the message was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// The path of the Event Hub.
        /// </summary>
        public readonly string EventHubPath;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The exact time the message was updated.
        /// </summary>
        public readonly string UpdatedAt;
        /// <summary>
        /// The user metadata.
        /// </summary>
        public readonly string? UserMetadata;

        [OutputConstructor]
        private GetConsumerGroupResult(
            string createdAt,

            string eventHubPath,

            string id,

            string? location,

            string name,

            string type,

            string updatedAt,

            string? userMetadata)
        {
            CreatedAt = createdAt;
            EventHubPath = eventHubPath;
            Id = id;
            Location = location;
            Name = name;
            Type = type;
            UpdatedAt = updatedAt;
            UserMetadata = userMetadata;
        }
    }
}
