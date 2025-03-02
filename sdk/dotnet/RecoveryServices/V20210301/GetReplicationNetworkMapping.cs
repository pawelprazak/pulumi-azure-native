// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20210301
{
    public static class GetReplicationNetworkMapping
    {
        /// <summary>
        /// Network Mapping model. Ideally it should have been possible to inherit this class from prev version in InheritedModels as long as there is no difference in structure or method signature. Since there were no base Models for certain fields and methods viz NetworkMappingProperties and Load with required return type, the class has been introduced in its entirety with references to base models to facilitate extensions in subsequent versions.
        /// </summary>
        public static Task<GetReplicationNetworkMappingResult> InvokeAsync(GetReplicationNetworkMappingArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetReplicationNetworkMappingResult>("azure-native:recoveryservices/v20210301:getReplicationNetworkMapping", args ?? new GetReplicationNetworkMappingArgs(), options.WithDefaults());

        /// <summary>
        /// Network Mapping model. Ideally it should have been possible to inherit this class from prev version in InheritedModels as long as there is no difference in structure or method signature. Since there were no base Models for certain fields and methods viz NetworkMappingProperties and Load with required return type, the class has been introduced in its entirety with references to base models to facilitate extensions in subsequent versions.
        /// </summary>
        public static Output<GetReplicationNetworkMappingResult> Invoke(GetReplicationNetworkMappingInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetReplicationNetworkMappingResult>("azure-native:recoveryservices/v20210301:getReplicationNetworkMapping", args ?? new GetReplicationNetworkMappingInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetReplicationNetworkMappingArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Primary fabric name.
        /// </summary>
        [Input("fabricName", required: true)]
        public string FabricName { get; set; } = null!;

        /// <summary>
        /// Network mapping name.
        /// </summary>
        [Input("networkMappingName", required: true)]
        public string NetworkMappingName { get; set; } = null!;

        /// <summary>
        /// Primary network name.
        /// </summary>
        [Input("networkName", required: true)]
        public string NetworkName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group where the recovery services vault is present.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the recovery services vault.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public GetReplicationNetworkMappingArgs()
        {
        }
    }

    public sealed class GetReplicationNetworkMappingInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Primary fabric name.
        /// </summary>
        [Input("fabricName", required: true)]
        public Input<string> FabricName { get; set; } = null!;

        /// <summary>
        /// Network mapping name.
        /// </summary>
        [Input("networkMappingName", required: true)]
        public Input<string> NetworkMappingName { get; set; } = null!;

        /// <summary>
        /// Primary network name.
        /// </summary>
        [Input("networkName", required: true)]
        public Input<string> NetworkName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group where the recovery services vault is present.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the recovery services vault.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        public GetReplicationNetworkMappingInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetReplicationNetworkMappingResult
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource Location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource Name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The Network Mapping Properties.
        /// </summary>
        public readonly Outputs.NetworkMappingPropertiesResponse Properties;
        /// <summary>
        /// Resource Type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetReplicationNetworkMappingResult(
            string id,

            string? location,

            string name,

            Outputs.NetworkMappingPropertiesResponse properties,

            string type)
        {
            Id = id;
            Location = location;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
