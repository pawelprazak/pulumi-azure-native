// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataShare.V20181101Preview
{
    public static class GetScheduledSynchronizationSetting
    {
        /// <summary>
        /// A type of synchronization setting based on schedule
        /// </summary>
        public static Task<GetScheduledSynchronizationSettingResult> InvokeAsync(GetScheduledSynchronizationSettingArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetScheduledSynchronizationSettingResult>("azure-native:datashare/v20181101preview:getScheduledSynchronizationSetting", args ?? new GetScheduledSynchronizationSettingArgs(), options.WithDefaults());

        /// <summary>
        /// A type of synchronization setting based on schedule
        /// </summary>
        public static Output<GetScheduledSynchronizationSettingResult> Invoke(GetScheduledSynchronizationSettingInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetScheduledSynchronizationSettingResult>("azure-native:datashare/v20181101preview:getScheduledSynchronizationSetting", args ?? new GetScheduledSynchronizationSettingInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetScheduledSynchronizationSettingArgs : Pulumi.InvokeArgs
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
        /// The name of the share.
        /// </summary>
        [Input("shareName", required: true)]
        public string ShareName { get; set; } = null!;

        /// <summary>
        /// The name of the synchronizationSetting.
        /// </summary>
        [Input("synchronizationSettingName", required: true)]
        public string SynchronizationSettingName { get; set; } = null!;

        public GetScheduledSynchronizationSettingArgs()
        {
        }
    }

    public sealed class GetScheduledSynchronizationSettingInvokeArgs : Pulumi.InvokeArgs
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
        /// The name of the share.
        /// </summary>
        [Input("shareName", required: true)]
        public Input<string> ShareName { get; set; } = null!;

        /// <summary>
        /// The name of the synchronizationSetting.
        /// </summary>
        [Input("synchronizationSettingName", required: true)]
        public Input<string> SynchronizationSettingName { get; set; } = null!;

        public GetScheduledSynchronizationSettingInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetScheduledSynchronizationSettingResult
    {
        /// <summary>
        /// Time at which the synchronization setting was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// The resource id of the azure resource
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of synchronization setting.
        /// Expected value is 'ScheduleBased'.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the azure resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets or sets the provisioning state
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Recurrence Interval
        /// </summary>
        public readonly string RecurrenceInterval;
        /// <summary>
        /// Synchronization time
        /// </summary>
        public readonly string SynchronizationTime;
        /// <summary>
        /// Type of the azure resource
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Name of the user who created the synchronization setting.
        /// </summary>
        public readonly string UserName;

        [OutputConstructor]
        private GetScheduledSynchronizationSettingResult(
            string createdAt,

            string id,

            string kind,

            string name,

            string provisioningState,

            string recurrenceInterval,

            string synchronizationTime,

            string type,

            string userName)
        {
            CreatedAt = createdAt;
            Id = id;
            Kind = kind;
            Name = name;
            ProvisioningState = provisioningState;
            RecurrenceInterval = recurrenceInterval;
            SynchronizationTime = synchronizationTime;
            Type = type;
            UserName = userName;
        }
    }
}
