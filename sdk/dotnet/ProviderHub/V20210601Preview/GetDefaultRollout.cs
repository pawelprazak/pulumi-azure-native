// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ProviderHub.V20210601Preview
{
    public static class GetDefaultRollout
    {
        /// <summary>
        /// Default rollout definition.
        /// </summary>
        public static Task<GetDefaultRolloutResult> InvokeAsync(GetDefaultRolloutArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDefaultRolloutResult>("azure-native:providerhub/v20210601preview:getDefaultRollout", args ?? new GetDefaultRolloutArgs(), options.WithDefaults());

        /// <summary>
        /// Default rollout definition.
        /// </summary>
        public static Output<GetDefaultRolloutResult> Invoke(GetDefaultRolloutInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDefaultRolloutResult>("azure-native:providerhub/v20210601preview:getDefaultRollout", args ?? new GetDefaultRolloutInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDefaultRolloutArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource provider hosted within ProviderHub.
        /// </summary>
        [Input("providerNamespace", required: true)]
        public string ProviderNamespace { get; set; } = null!;

        /// <summary>
        /// The rollout name.
        /// </summary>
        [Input("rolloutName", required: true)]
        public string RolloutName { get; set; } = null!;

        public GetDefaultRolloutArgs()
        {
        }
    }

    public sealed class GetDefaultRolloutInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource provider hosted within ProviderHub.
        /// </summary>
        [Input("providerNamespace", required: true)]
        public Input<string> ProviderNamespace { get; set; } = null!;

        /// <summary>
        /// The rollout name.
        /// </summary>
        [Input("rolloutName", required: true)]
        public Input<string> RolloutName { get; set; } = null!;

        public GetDefaultRolloutInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDefaultRolloutResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Properties of the rollout.
        /// </summary>
        public readonly Outputs.DefaultRolloutResponseProperties Properties;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDefaultRolloutResult(
            string id,

            string name,

            Outputs.DefaultRolloutResponseProperties properties,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Type = type;
        }
    }
}
