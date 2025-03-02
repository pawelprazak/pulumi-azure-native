// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataShare
{
    [Obsolete(@"Please use one of the variants: ScheduledTrigger.")]
    public static class GetTrigger
    {
        /// <summary>
        /// A Trigger data transfer object.
        /// API Version: 2020-09-01.
        /// </summary>
        public static Task<GetTriggerResult> InvokeAsync(GetTriggerArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTriggerResult>("azure-native:datashare:getTrigger", args ?? new GetTriggerArgs(), options.WithDefaults());

        /// <summary>
        /// A Trigger data transfer object.
        /// API Version: 2020-09-01.
        /// </summary>
        public static Output<GetTriggerResult> Invoke(GetTriggerInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTriggerResult>("azure-native:datashare:getTrigger", args ?? new GetTriggerInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTriggerArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public string ShareSubscriptionName { get; set; } = null!;

        /// <summary>
        /// The name of the trigger.
        /// </summary>
        [Input("triggerName", required: true)]
        public string TriggerName { get; set; } = null!;

        public GetTriggerArgs()
        {
        }
    }

    public sealed class GetTriggerInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public Input<string> ShareSubscriptionName { get; set; } = null!;

        /// <summary>
        /// The name of the trigger.
        /// </summary>
        [Input("triggerName", required: true)]
        public Input<string> TriggerName { get; set; } = null!;

        public GetTriggerInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTriggerResult
    {
        /// <summary>
        /// The resource id of the azure resource
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of synchronization on trigger.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the azure resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// System Data of the Azure resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Type of the azure resource
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetTriggerResult(
            string id,

            string kind,

            string name,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Kind = kind;
            Name = name;
            SystemData = systemData;
            Type = type;
        }
    }
}
