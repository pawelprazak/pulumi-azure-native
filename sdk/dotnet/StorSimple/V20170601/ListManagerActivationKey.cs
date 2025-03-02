// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorSimple.V20170601
{
    public static class ListManagerActivationKey
    {
        /// <summary>
        /// The key.
        /// </summary>
        public static Task<ListManagerActivationKeyResult> InvokeAsync(ListManagerActivationKeyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListManagerActivationKeyResult>("azure-native:storsimple/v20170601:listManagerActivationKey", args ?? new ListManagerActivationKeyArgs(), options.WithDefaults());

        /// <summary>
        /// The key.
        /// </summary>
        public static Output<ListManagerActivationKeyResult> Invoke(ListManagerActivationKeyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListManagerActivationKeyResult>("azure-native:storsimple/v20170601:listManagerActivationKey", args ?? new ListManagerActivationKeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListManagerActivationKeyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public string ManagerName { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListManagerActivationKeyArgs()
        {
        }
    }

    public sealed class ListManagerActivationKeyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public Input<string> ManagerName { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListManagerActivationKeyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListManagerActivationKeyResult
    {
        /// <summary>
        /// The activation key for the device.
        /// </summary>
        public readonly string ActivationKey;

        [OutputConstructor]
        private ListManagerActivationKeyResult(string activationKey)
        {
            ActivationKey = activationKey;
        }
    }
}
