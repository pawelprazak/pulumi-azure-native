// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20200601
{
    public static class GetPrivateEndpointConnection
    {
        /// <summary>
        /// The Private Endpoint Connection resource.
        /// </summary>
        public static Task<GetPrivateEndpointConnectionResult> InvokeAsync(GetPrivateEndpointConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrivateEndpointConnectionResult>("azure-native:machinelearningservices/v20200601:getPrivateEndpointConnection", args ?? new GetPrivateEndpointConnectionArgs(), options.WithDefaults());

        /// <summary>
        /// The Private Endpoint Connection resource.
        /// </summary>
        public static Output<GetPrivateEndpointConnectionResult> Invoke(GetPrivateEndpointConnectionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPrivateEndpointConnectionResult>("azure-native:machinelearningservices/v20200601:getPrivateEndpointConnection", args ?? new GetPrivateEndpointConnectionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPrivateEndpointConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the private endpoint connection associated with the workspace
        /// </summary>
        [Input("privateEndpointConnectionName", required: true)]
        public string PrivateEndpointConnectionName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetPrivateEndpointConnectionArgs()
        {
        }
    }

    public sealed class GetPrivateEndpointConnectionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the private endpoint connection associated with the workspace
        /// </summary>
        [Input("privateEndpointConnectionName", required: true)]
        public Input<string> PrivateEndpointConnectionName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetPrivateEndpointConnectionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPrivateEndpointConnectionResult
    {
        /// <summary>
        /// ResourceId of the private endpoint connection.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Friendly name of the private endpoint connection.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The resource of private end point.
        /// </summary>
        public readonly Outputs.PrivateEndpointResponse? PrivateEndpoint;
        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        public readonly Outputs.PrivateLinkServiceConnectionStateResponse PrivateLinkServiceConnectionState;
        /// <summary>
        /// The provisioning state of the private endpoint connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource type of private endpoint connection.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPrivateEndpointConnectionResult(
            string id,

            string name,

            Outputs.PrivateEndpointResponse? privateEndpoint,

            Outputs.PrivateLinkServiceConnectionStateResponse privateLinkServiceConnectionState,

            string provisioningState,

            string type)
        {
            Id = id;
            Name = name;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
