// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppConfiguration.V20200701Preview
{
    public static class GetConfigurationStore
    {
        /// <summary>
        /// The configuration store along with all resource properties. The Configuration Store will have all information to begin utilizing it.
        /// </summary>
        public static Task<GetConfigurationStoreResult> InvokeAsync(GetConfigurationStoreArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConfigurationStoreResult>("azure-native:appconfiguration/v20200701preview:getConfigurationStore", args ?? new GetConfigurationStoreArgs(), options.WithDefaults());

        /// <summary>
        /// The configuration store along with all resource properties. The Configuration Store will have all information to begin utilizing it.
        /// </summary>
        public static Output<GetConfigurationStoreResult> Invoke(GetConfigurationStoreInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConfigurationStoreResult>("azure-native:appconfiguration/v20200701preview:getConfigurationStore", args ?? new GetConfigurationStoreInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConfigurationStoreArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the configuration store.
        /// </summary>
        [Input("configStoreName", required: true)]
        public string ConfigStoreName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetConfigurationStoreArgs()
        {
        }
    }

    public sealed class GetConfigurationStoreInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the configuration store.
        /// </summary>
        [Input("configStoreName", required: true)]
        public Input<string> ConfigStoreName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetConfigurationStoreInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConfigurationStoreResult
    {
        /// <summary>
        /// The creation date of configuration store.
        /// </summary>
        public readonly string CreationDate;
        /// <summary>
        /// The encryption settings of the configuration store.
        /// </summary>
        public readonly Outputs.EncryptionPropertiesResponse? Encryption;
        /// <summary>
        /// The DNS endpoint where the configuration store API will be available.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// The resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The managed identity information, if configured.
        /// </summary>
        public readonly Outputs.ResourceIdentityResponse? Identity;
        /// <summary>
        /// The location of the resource. This cannot be changed after the resource is created.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The list of private endpoint connections that are set up for this resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateEndpointConnectionReferenceResponse> PrivateEndpointConnections;
        /// <summary>
        /// The provisioning state of the configuration store.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Control permission for data plane traffic coming from public networks while private endpoint is enabled.
        /// </summary>
        public readonly string? PublicNetworkAccess;
        /// <summary>
        /// The sku of the configuration store.
        /// </summary>
        public readonly Outputs.SkuResponse Sku;
        /// <summary>
        /// The tags of the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetConfigurationStoreResult(
            string creationDate,

            Outputs.EncryptionPropertiesResponse? encryption,

            string endpoint,

            string id,

            Outputs.ResourceIdentityResponse? identity,

            string location,

            string name,

            ImmutableArray<Outputs.PrivateEndpointConnectionReferenceResponse> privateEndpointConnections,

            string provisioningState,

            string? publicNetworkAccess,

            Outputs.SkuResponse sku,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            CreationDate = creationDate;
            Encryption = encryption;
            Endpoint = endpoint;
            Id = id;
            Identity = identity;
            Location = location;
            Name = name;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            PublicNetworkAccess = publicNetworkAccess;
            Sku = sku;
            Tags = tags;
            Type = type;
        }
    }
}
