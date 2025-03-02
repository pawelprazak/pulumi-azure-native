// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Devices.V20220205
{
    public static class ListIotDpsResourceKeysForKeyName
    {
        /// <summary>
        /// Description of the shared access key.
        /// </summary>
        public static Task<ListIotDpsResourceKeysForKeyNameResult> InvokeAsync(ListIotDpsResourceKeysForKeyNameArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListIotDpsResourceKeysForKeyNameResult>("azure-native:devices/v20220205:listIotDpsResourceKeysForKeyName", args ?? new ListIotDpsResourceKeysForKeyNameArgs(), options.WithDefaults());

        /// <summary>
        /// Description of the shared access key.
        /// </summary>
        public static Output<ListIotDpsResourceKeysForKeyNameResult> Invoke(ListIotDpsResourceKeysForKeyNameInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListIotDpsResourceKeysForKeyNameResult>("azure-native:devices/v20220205:listIotDpsResourceKeysForKeyName", args ?? new ListIotDpsResourceKeysForKeyNameInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListIotDpsResourceKeysForKeyNameArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Logical key name to get key-values for.
        /// </summary>
        [Input("keyName", required: true)]
        public string KeyName { get; set; } = null!;

        /// <summary>
        /// Name of the provisioning service.
        /// </summary>
        [Input("provisioningServiceName", required: true)]
        public string ProvisioningServiceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the provisioning service.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListIotDpsResourceKeysForKeyNameArgs()
        {
        }
    }

    public sealed class ListIotDpsResourceKeysForKeyNameInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Logical key name to get key-values for.
        /// </summary>
        [Input("keyName", required: true)]
        public Input<string> KeyName { get; set; } = null!;

        /// <summary>
        /// Name of the provisioning service.
        /// </summary>
        [Input("provisioningServiceName", required: true)]
        public Input<string> ProvisioningServiceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the provisioning service.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListIotDpsResourceKeysForKeyNameInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListIotDpsResourceKeysForKeyNameResult
    {
        /// <summary>
        /// Name of the key.
        /// </summary>
        public readonly string KeyName;
        /// <summary>
        /// Primary SAS key value.
        /// </summary>
        public readonly string? PrimaryKey;
        /// <summary>
        /// Rights that this key has.
        /// </summary>
        public readonly string Rights;
        /// <summary>
        /// Secondary SAS key value.
        /// </summary>
        public readonly string? SecondaryKey;

        [OutputConstructor]
        private ListIotDpsResourceKeysForKeyNameResult(
            string keyName,

            string? primaryKey,

            string rights,

            string? secondaryKey)
        {
            KeyName = keyName;
            PrimaryKey = primaryKey;
            Rights = rights;
            SecondaryKey = secondaryKey;
        }
    }
}
