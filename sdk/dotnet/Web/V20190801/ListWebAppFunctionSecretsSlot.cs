// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20190801
{
    public static class ListWebAppFunctionSecretsSlot
    {
        /// <summary>
        /// Function secrets.
        /// </summary>
        public static Task<ListWebAppFunctionSecretsSlotResult> InvokeAsync(ListWebAppFunctionSecretsSlotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppFunctionSecretsSlotResult>("azure-native:web/v20190801:listWebAppFunctionSecretsSlot", args ?? new ListWebAppFunctionSecretsSlotArgs(), options.WithDefaults());

        /// <summary>
        /// Function secrets.
        /// </summary>
        public static Output<ListWebAppFunctionSecretsSlotResult> Invoke(ListWebAppFunctionSecretsSlotInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListWebAppFunctionSecretsSlotResult>("azure-native:web/v20190801:listWebAppFunctionSecretsSlot", args ?? new ListWebAppFunctionSecretsSlotInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListWebAppFunctionSecretsSlotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Function name.
        /// </summary>
        [Input("functionName", required: true)]
        public string FunctionName { get; set; } = null!;

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

        public ListWebAppFunctionSecretsSlotArgs()
        {
        }
    }

    public sealed class ListWebAppFunctionSecretsSlotInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Function name.
        /// </summary>
        [Input("functionName", required: true)]
        public Input<string> FunctionName { get; set; } = null!;

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

        public ListWebAppFunctionSecretsSlotInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppFunctionSecretsSlotResult
    {
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Secret key.
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Trigger URL.
        /// </summary>
        public readonly string? TriggerUrl;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListWebAppFunctionSecretsSlotResult(
            string id,

            string? key,

            string? kind,

            string name,

            string? triggerUrl,

            string type)
        {
            Id = id;
            Key = key;
            Kind = kind;
            Name = name;
            TriggerUrl = triggerUrl;
            Type = type;
        }
    }
}
