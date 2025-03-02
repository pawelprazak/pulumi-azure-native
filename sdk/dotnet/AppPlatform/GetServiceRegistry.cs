// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform
{
    public static class GetServiceRegistry
    {
        /// <summary>
        /// Service Registry resource
        /// API Version: 2022-01-01-preview.
        /// </summary>
        public static Task<GetServiceRegistryResult> InvokeAsync(GetServiceRegistryArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceRegistryResult>("azure-native:appplatform:getServiceRegistry", args ?? new GetServiceRegistryArgs(), options.WithDefaults());

        /// <summary>
        /// Service Registry resource
        /// API Version: 2022-01-01-preview.
        /// </summary>
        public static Output<GetServiceRegistryResult> Invoke(GetServiceRegistryInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetServiceRegistryResult>("azure-native:appplatform:getServiceRegistry", args ?? new GetServiceRegistryInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServiceRegistryArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Service resource.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        /// <summary>
        /// The name of Service Registry.
        /// </summary>
        [Input("serviceRegistryName", required: true)]
        public string ServiceRegistryName { get; set; } = null!;

        public GetServiceRegistryArgs()
        {
        }
    }

    public sealed class GetServiceRegistryInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Service resource.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// The name of Service Registry.
        /// </summary>
        [Input("serviceRegistryName", required: true)]
        public Input<string> ServiceRegistryName { get; set; } = null!;

        public GetServiceRegistryInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServiceRegistryResult
    {
        /// <summary>
        /// Fully qualified resource Id for the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Service Registry properties payload
        /// </summary>
        public readonly Outputs.ServiceRegistryPropertiesResponse Properties;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetServiceRegistryResult(
            string id,

            string name,

            Outputs.ServiceRegistryPropertiesResponse properties,

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
