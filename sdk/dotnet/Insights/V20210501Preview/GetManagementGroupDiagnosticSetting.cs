// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20210501Preview
{
    public static class GetManagementGroupDiagnosticSetting
    {
        /// <summary>
        /// The management group diagnostic setting resource.
        /// </summary>
        public static Task<GetManagementGroupDiagnosticSettingResult> InvokeAsync(GetManagementGroupDiagnosticSettingArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetManagementGroupDiagnosticSettingResult>("azure-native:insights/v20210501preview:getManagementGroupDiagnosticSetting", args ?? new GetManagementGroupDiagnosticSettingArgs(), options.WithDefaults());

        /// <summary>
        /// The management group diagnostic setting resource.
        /// </summary>
        public static Output<GetManagementGroupDiagnosticSettingResult> Invoke(GetManagementGroupDiagnosticSettingInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetManagementGroupDiagnosticSettingResult>("azure-native:insights/v20210501preview:getManagementGroupDiagnosticSetting", args ?? new GetManagementGroupDiagnosticSettingInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetManagementGroupDiagnosticSettingArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The management group id.
        /// </summary>
        [Input("managementGroupId", required: true)]
        public string ManagementGroupId { get; set; } = null!;

        /// <summary>
        /// The name of the diagnostic setting.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetManagementGroupDiagnosticSettingArgs()
        {
        }
    }

    public sealed class GetManagementGroupDiagnosticSettingInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The management group id.
        /// </summary>
        [Input("managementGroupId", required: true)]
        public Input<string> ManagementGroupId { get; set; } = null!;

        /// <summary>
        /// The name of the diagnostic setting.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetManagementGroupDiagnosticSettingInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetManagementGroupDiagnosticSettingResult
    {
        /// <summary>
        /// The resource Id for the event hub authorization rule.
        /// </summary>
        public readonly string? EventHubAuthorizationRuleId;
        /// <summary>
        /// The name of the event hub. If none is specified, the default event hub will be selected.
        /// </summary>
        public readonly string? EventHubName;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The list of logs settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ManagementGroupLogSettingsResponse> Logs;
        /// <summary>
        /// The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.
        /// </summary>
        public readonly string? MarketplacePartnerId;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
        /// </summary>
        public readonly string? ServiceBusRuleId;
        /// <summary>
        /// The resource ID of the storage account to which you would like to send Diagnostic Logs.
        /// </summary>
        public readonly string? StorageAccountId;
        /// <summary>
        /// The system metadata related to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        public readonly string? WorkspaceId;

        [OutputConstructor]
        private GetManagementGroupDiagnosticSettingResult(
            string? eventHubAuthorizationRuleId,

            string? eventHubName,

            string id,

            ImmutableArray<Outputs.ManagementGroupLogSettingsResponse> logs,

            string? marketplacePartnerId,

            string name,

            string? serviceBusRuleId,

            string? storageAccountId,

            Outputs.SystemDataResponse systemData,

            string type,

            string? workspaceId)
        {
            EventHubAuthorizationRuleId = eventHubAuthorizationRuleId;
            EventHubName = eventHubName;
            Id = id;
            Logs = logs;
            MarketplacePartnerId = marketplacePartnerId;
            Name = name;
            ServiceBusRuleId = serviceBusRuleId;
            StorageAccountId = storageAccountId;
            SystemData = systemData;
            Type = type;
            WorkspaceId = workspaceId;
        }
    }
}
