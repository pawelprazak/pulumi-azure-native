// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceFabric.V20210701Preview
{
    public static class GetService
    {
        /// <summary>
        /// The service resource.
        /// </summary>
        public static Task<GetServiceResult> InvokeAsync(GetServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceResult>("azure-native:servicefabric/v20210701preview:getService", args ?? new GetServiceArgs(), options.WithDefaults());

        /// <summary>
        /// The service resource.
        /// </summary>
        public static Output<GetServiceResult> Invoke(GetServiceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetServiceResult>("azure-native:servicefabric/v20210701preview:getService", args ?? new GetServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application resource.
        /// </summary>
        [Input("applicationName", required: true)]
        public string ApplicationName { get; set; } = null!;

        /// <summary>
        /// The name of the cluster resource.
        /// </summary>
        [Input("clusterName", required: true)]
        public string ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the service resource in the format of {applicationName}~{serviceName}.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetServiceArgs()
        {
        }
    }

    public sealed class GetServiceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application resource.
        /// </summary>
        [Input("applicationName", required: true)]
        public Input<string> ApplicationName { get; set; } = null!;

        /// <summary>
        /// The name of the cluster resource.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the service resource in the format of {applicationName}~{serviceName}.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public GetServiceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServiceResult
    {
        /// <summary>
        /// Azure resource identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location depends on the parent resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Azure resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The service resource properties.
        /// </summary>
        public readonly Union<Outputs.StatefulServicePropertiesResponse, Outputs.StatelessServicePropertiesResponse> Properties;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Azure resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Azure resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetServiceResult(
            string id,

            string? location,

            string name,

            Union<Outputs.StatefulServicePropertiesResponse, Outputs.StatelessServicePropertiesResponse> properties,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Id = id;
            Location = location;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
