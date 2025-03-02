// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorSimple.V20161001
{
    [Obsolete(@"Version 2016-10-01 will be removed in v2 of the provider.")]
    public static class GetChapSetting
    {
        /// <summary>
        /// Challenge-Handshake Authentication Protocol (CHAP) setting
        /// </summary>
        public static Task<GetChapSettingResult> InvokeAsync(GetChapSettingArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetChapSettingResult>("azure-native:storsimple/v20161001:getChapSetting", args ?? new GetChapSettingArgs(), options.WithDefaults());

        /// <summary>
        /// Challenge-Handshake Authentication Protocol (CHAP) setting
        /// </summary>
        public static Output<GetChapSettingResult> Invoke(GetChapSettingInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetChapSettingResult>("azure-native:storsimple/v20161001:getChapSetting", args ?? new GetChapSettingInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetChapSettingArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The user name of chap to be fetched.
        /// </summary>
        [Input("chapUserName", required: true)]
        public string ChapUserName { get; set; } = null!;

        /// <summary>
        /// The device name.
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

        public GetChapSettingArgs()
        {
        }
    }

    public sealed class GetChapSettingInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The user name of chap to be fetched.
        /// </summary>
        [Input("chapUserName", required: true)]
        public Input<string> ChapUserName { get; set; } = null!;

        /// <summary>
        /// The device name.
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

        public GetChapSettingInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetChapSettingResult
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The chap password.
        /// </summary>
        public readonly Outputs.AsymmetricEncryptedSecretResponse Password;
        /// <summary>
        /// The type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetChapSettingResult(
            string id,

            string name,

            Outputs.AsymmetricEncryptedSecretResponse password,

            string type)
        {
            Id = id;
            Name = name;
            Password = password;
            Type = type;
        }
    }
}
