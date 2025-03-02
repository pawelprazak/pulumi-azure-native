// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ChangeAnalysis.V20200401Preview
{
    public static class GetConfigurationProfile
    {
        /// <summary>
        /// A profile object that contains change analysis configuration, such as notification settings, for this subscription
        /// </summary>
        public static Task<GetConfigurationProfileResult> InvokeAsync(GetConfigurationProfileArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConfigurationProfileResult>("azure-native:changeanalysis/v20200401preview:getConfigurationProfile", args ?? new GetConfigurationProfileArgs(), options.WithDefaults());

        /// <summary>
        /// A profile object that contains change analysis configuration, such as notification settings, for this subscription
        /// </summary>
        public static Output<GetConfigurationProfileResult> Invoke(GetConfigurationProfileInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConfigurationProfileResult>("azure-native:changeanalysis/v20200401preview:getConfigurationProfile", args ?? new GetConfigurationProfileInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConfigurationProfileArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the configuration profile. The profile name should be set to 'default', all other names will be overwritten.
        /// </summary>
        [Input("profileName", required: true)]
        public string ProfileName { get; set; } = null!;

        public GetConfigurationProfileArgs()
        {
        }
    }

    public sealed class GetConfigurationProfileInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the configuration profile. The profile name should be set to 'default', all other names will be overwritten.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        public GetConfigurationProfileInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConfigurationProfileResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity block returned by ARM resource that supports managed identity.
        /// </summary>
        public readonly Outputs.ResourceIdentityResponse? Identity;
        /// <summary>
        /// The location where the resource is to be deployed.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The properties of a configuration profile.
        /// </summary>
        public readonly Outputs.ConfigurationProfileResourcePropertiesResponse Properties;
        /// <summary>
        /// Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
        /// </summary>
        public readonly Outputs.SystemDataResponse? SystemData;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetConfigurationProfileResult(
            string id,

            Outputs.ResourceIdentityResponse? identity,

            string? location,

            string name,

            Outputs.ConfigurationProfileResourcePropertiesResponse properties,

            Outputs.SystemDataResponse? systemData,

            string type)
        {
            Id = id;
            Identity = identity;
            Location = location;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Type = type;
        }
    }
}
