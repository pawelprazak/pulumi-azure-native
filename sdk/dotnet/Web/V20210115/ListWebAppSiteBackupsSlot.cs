// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20210115
{
    public static class ListWebAppSiteBackupsSlot
    {
        /// <summary>
        /// Collection of backup items.
        /// </summary>
        public static Task<ListWebAppSiteBackupsSlotResult> InvokeAsync(ListWebAppSiteBackupsSlotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppSiteBackupsSlotResult>("azure-native:web/v20210115:listWebAppSiteBackupsSlot", args ?? new ListWebAppSiteBackupsSlotArgs(), options.WithDefaults());

        /// <summary>
        /// Collection of backup items.
        /// </summary>
        public static Output<ListWebAppSiteBackupsSlotResult> Invoke(ListWebAppSiteBackupsSlotInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListWebAppSiteBackupsSlotResult>("azure-native:web/v20210115:listWebAppSiteBackupsSlot", args ?? new ListWebAppSiteBackupsSlotInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListWebAppSiteBackupsSlotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the deployment slot. If a slot is not specified, the API will get backups of the production slot.
        /// </summary>
        [Input("slot", required: true)]
        public string Slot { get; set; } = null!;

        public ListWebAppSiteBackupsSlotArgs()
        {
        }
    }

    public sealed class ListWebAppSiteBackupsSlotInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the deployment slot. If a slot is not specified, the API will get backups of the production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        public ListWebAppSiteBackupsSlotInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppSiteBackupsSlotResult
    {
        /// <summary>
        /// Link to next page of resources.
        /// </summary>
        public readonly string NextLink;
        /// <summary>
        /// Collection of resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.BackupItemResponse> Value;

        [OutputConstructor]
        private ListWebAppSiteBackupsSlotResult(
            string nextLink,

            ImmutableArray<Outputs.BackupItemResponse> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
