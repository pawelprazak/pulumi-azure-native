// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20170401
{
    public static class GetActivityLogAlert
    {
        /// <summary>
        /// An activity log alert resource.
        /// </summary>
        public static Task<GetActivityLogAlertResult> InvokeAsync(GetActivityLogAlertArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetActivityLogAlertResult>("azure-native:insights/v20170401:getActivityLogAlert", args ?? new GetActivityLogAlertArgs(), options.WithDefaults());

        /// <summary>
        /// An activity log alert resource.
        /// </summary>
        public static Output<GetActivityLogAlertResult> Invoke(GetActivityLogAlertInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetActivityLogAlertResult>("azure-native:insights/v20170401:getActivityLogAlert", args ?? new GetActivityLogAlertInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetActivityLogAlertArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the activity log alert.
        /// </summary>
        [Input("activityLogAlertName", required: true)]
        public string ActivityLogAlertName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetActivityLogAlertArgs()
        {
        }
    }

    public sealed class GetActivityLogAlertInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the activity log alert.
        /// </summary>
        [Input("activityLogAlertName", required: true)]
        public Input<string> ActivityLogAlertName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetActivityLogAlertInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetActivityLogAlertResult
    {
        /// <summary>
        /// The actions that will activate when the condition is met.
        /// </summary>
        public readonly Outputs.ActivityLogAlertActionListResponse Actions;
        /// <summary>
        /// The condition that will cause this alert to activate.
        /// </summary>
        public readonly Outputs.ActivityLogAlertAllOfConditionResponse Condition;
        /// <summary>
        /// A description of this activity log alert.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Azure resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Azure resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
        /// </summary>
        public readonly ImmutableArray<string> Scopes;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Azure resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetActivityLogAlertResult(
            Outputs.ActivityLogAlertActionListResponse actions,

            Outputs.ActivityLogAlertAllOfConditionResponse condition,

            string? description,

            bool? enabled,

            string id,

            string location,

            string name,

            ImmutableArray<string> scopes,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Actions = actions;
            Condition = condition;
            Description = description;
            Enabled = enabled;
            Id = id;
            Location = location;
            Name = name;
            Scopes = scopes;
            Tags = tags;
            Type = type;
        }
    }
}
