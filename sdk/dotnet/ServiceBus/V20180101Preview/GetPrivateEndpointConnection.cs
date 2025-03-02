// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceBus.V20180101Preview
{
    public static class GetPrivateEndpointConnection
    {
        /// <summary>
        /// Properties of the PrivateEndpointConnection.
        /// </summary>
        public static Task<GetPrivateEndpointConnectionResult> InvokeAsync(GetPrivateEndpointConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrivateEndpointConnectionResult>("azure-native:servicebus/v20180101preview:getPrivateEndpointConnection", args ?? new GetPrivateEndpointConnectionArgs(), options.WithDefaults());

        /// <summary>
        /// Properties of the PrivateEndpointConnection.
        /// </summary>
        public static Output<GetPrivateEndpointConnectionResult> Invoke(GetPrivateEndpointConnectionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPrivateEndpointConnectionResult>("azure-native:servicebus/v20180101preview:getPrivateEndpointConnection", args ?? new GetPrivateEndpointConnectionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPrivateEndpointConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// The PrivateEndpointConnection name
        /// </summary>
        [Input("privateEndpointConnectionName", required: true)]
        public string PrivateEndpointConnectionName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPrivateEndpointConnectionArgs()
        {
        }
    }

    public sealed class GetPrivateEndpointConnectionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// The PrivateEndpointConnection name
        /// </summary>
        [Input("privateEndpointConnectionName", required: true)]
        public Input<string> PrivateEndpointConnectionName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetPrivateEndpointConnectionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPrivateEndpointConnectionResult
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The Private Endpoint resource for this Connection.
        /// </summary>
        public readonly Outputs.PrivateEndpointResponse? PrivateEndpoint;
        /// <summary>
        /// Details about the state of the connection.
        /// </summary>
        public readonly Outputs.ConnectionStateResponse? PrivateLinkServiceConnectionState;
        /// <summary>
        /// Provisioning state of the Private Endpoint Connection.
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPrivateEndpointConnectionResult(
            string id,

            string name,

            Outputs.PrivateEndpointResponse? privateEndpoint,

            Outputs.ConnectionStateResponse? privateLinkServiceConnectionState,

            string? provisioningState,

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
