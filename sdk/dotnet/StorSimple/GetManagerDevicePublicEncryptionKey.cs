// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorSimple
{
    public static class GetManagerDevicePublicEncryptionKey
    {
        /// <summary>
        /// The public key.
        /// API Version: 2017-06-01.
        /// </summary>
        public static Task<GetManagerDevicePublicEncryptionKeyResult> InvokeAsync(GetManagerDevicePublicEncryptionKeyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetManagerDevicePublicEncryptionKeyResult>("azure-native:storsimple:getManagerDevicePublicEncryptionKey", args ?? new GetManagerDevicePublicEncryptionKeyArgs(), options.WithDefaults());

        /// <summary>
        /// The public key.
        /// API Version: 2017-06-01.
        /// </summary>
        public static Output<GetManagerDevicePublicEncryptionKeyResult> Invoke(GetManagerDevicePublicEncryptionKeyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetManagerDevicePublicEncryptionKeyResult>("azure-native:storsimple:getManagerDevicePublicEncryptionKey", args ?? new GetManagerDevicePublicEncryptionKeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetManagerDevicePublicEncryptionKeyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name
        /// </summary>
        [Input("deviceName", required: true)]
        public string DeviceName { get; set; } = null!;

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

        public GetManagerDevicePublicEncryptionKeyArgs()
        {
        }
    }

    public sealed class GetManagerDevicePublicEncryptionKeyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

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

        public GetManagerDevicePublicEncryptionKeyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetManagerDevicePublicEncryptionKeyResult
    {
        /// <summary>
        /// The key.
        /// </summary>
        public readonly string Key;

        [OutputConstructor]
        private GetManagerDevicePublicEncryptionKeyResult(string key)
        {
            Key = key;
        }
    }
}
