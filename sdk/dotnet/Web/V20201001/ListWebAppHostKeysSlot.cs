// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20201001
{
    public static class ListWebAppHostKeysSlot
    {
        /// <summary>
        /// Functions host level keys.
        /// </summary>
        public static Task<ListWebAppHostKeysSlotResult> InvokeAsync(ListWebAppHostKeysSlotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppHostKeysSlotResult>("azure-native:web/v20201001:listWebAppHostKeysSlot", args ?? new ListWebAppHostKeysSlotArgs(), options.WithDefaults());

        /// <summary>
        /// Functions host level keys.
        /// </summary>
        public static Output<ListWebAppHostKeysSlotResult> Invoke(ListWebAppHostKeysSlotInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListWebAppHostKeysSlotResult>("azure-native:web/v20201001:listWebAppHostKeysSlot", args ?? new ListWebAppHostKeysSlotInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListWebAppHostKeysSlotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Site name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the deployment slot.
        /// </summary>
        [Input("slot", required: true)]
        public string Slot { get; set; } = null!;

        public ListWebAppHostKeysSlotArgs()
        {
        }
    }

    public sealed class ListWebAppHostKeysSlotInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Site name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the deployment slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        public ListWebAppHostKeysSlotInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppHostKeysSlotResult
    {
        /// <summary>
        /// Host level function keys.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? FunctionKeys;
        /// <summary>
        /// Secret key.
        /// </summary>
        public readonly string? MasterKey;
        /// <summary>
        /// System keys.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? SystemKeys;

        [OutputConstructor]
        private ListWebAppHostKeysSlotResult(
            ImmutableDictionary<string, string>? functionKeys,

            string? masterKey,

            ImmutableDictionary<string, string>? systemKeys)
        {
            FunctionKeys = functionKeys;
            MasterKey = masterKey;
            SystemKeys = systemKeys;
        }
    }
}
