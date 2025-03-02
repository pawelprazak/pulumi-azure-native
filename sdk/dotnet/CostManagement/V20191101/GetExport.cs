// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CostManagement.V20191101
{
    public static class GetExport
    {
        /// <summary>
        /// A export resource.
        /// </summary>
        public static Task<GetExportResult> InvokeAsync(GetExportArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetExportResult>("azure-native:costmanagement/v20191101:getExport", args ?? new GetExportArgs(), options.WithDefaults());

        /// <summary>
        /// A export resource.
        /// </summary>
        public static Output<GetExportResult> Invoke(GetExportInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetExportResult>("azure-native:costmanagement/v20191101:getExport", args ?? new GetExportInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetExportArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Export Name.
        /// </summary>
        [Input("exportName", required: true)]
        public string ExportName { get; set; } = null!;

        /// <summary>
        /// The scope associated with query and export operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId} for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope, and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}' specific for partners.
        /// </summary>
        [Input("scope", required: true)]
        public string Scope { get; set; } = null!;

        public GetExportArgs()
        {
        }
    }

    public sealed class GetExportInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Export Name.
        /// </summary>
        [Input("exportName", required: true)]
        public Input<string> ExportName { get; set; } = null!;

        /// <summary>
        /// The scope associated with query and export operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId} for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope, and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}' specific for partners.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        public GetExportInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetExportResult
    {
        /// <summary>
        /// Has definition for the export.
        /// </summary>
        public readonly Outputs.ExportDefinitionResponse Definition;
        /// <summary>
        /// Has delivery information for the export.
        /// </summary>
        public readonly Outputs.ExportDeliveryInfoResponse DeliveryInfo;
        /// <summary>
        /// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
        /// </summary>
        public readonly string? ETag;
        /// <summary>
        /// The format of the export being delivered.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Has schedule information for the export.
        /// </summary>
        public readonly Outputs.ExportScheduleResponse? Schedule;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetExportResult(
            Outputs.ExportDefinitionResponse definition,

            Outputs.ExportDeliveryInfoResponse deliveryInfo,

            string? eTag,

            string? format,

            string id,

            string name,

            Outputs.ExportScheduleResponse? schedule,

            string type)
        {
            Definition = definition;
            DeliveryInfo = deliveryInfo;
            ETag = eTag;
            Format = format;
            Id = id;
            Name = name;
            Schedule = schedule;
            Type = type;
        }
    }
}
