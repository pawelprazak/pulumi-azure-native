// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HybridConnectivity.V20220501Preview
{
    public static class GetEndpoint
    {
        /// <summary>
        /// The endpoint for the target resource.
        /// </summary>
        public static Task<GetEndpointResult> InvokeAsync(GetEndpointArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEndpointResult>("azure-native:hybridconnectivity/v20220501preview:getEndpoint", args ?? new GetEndpointArgs(), options.WithDefaults());

        /// <summary>
        /// The endpoint for the target resource.
        /// </summary>
        public static Output<GetEndpointResult> Invoke(GetEndpointInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetEndpointResult>("azure-native:hybridconnectivity/v20220501preview:getEndpoint", args ?? new GetEndpointInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEndpointArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The endpoint name.
        /// </summary>
        [Input("endpointName", required: true)]
        public string EndpointName { get; set; } = null!;

        /// <summary>
        /// The fully qualified Azure Resource manager identifier of the resource to be connected.
        /// </summary>
        [Input("resourceUri", required: true)]
        public string ResourceUri { get; set; } = null!;

        public GetEndpointArgs()
        {
        }
    }

    public sealed class GetEndpointInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The endpoint name.
        /// </summary>
        [Input("endpointName", required: true)]
        public Input<string> EndpointName { get; set; } = null!;

        /// <summary>
        /// The fully qualified Azure Resource manager identifier of the resource to be connected.
        /// </summary>
        [Input("resourceUri", required: true)]
        public Input<string> ResourceUri { get; set; } = null!;

        public GetEndpointInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEndpointResult
    {
        /// <summary>
        /// The timestamp of resource creation (UTC).
        /// </summary>
        public readonly string? CreatedAt;
        /// <summary>
        /// The identity that created the resource.
        /// </summary>
        public readonly string? CreatedBy;
        /// <summary>
        /// The type of identity that created the resource.
        /// </summary>
        public readonly string? CreatedByType;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The timestamp of resource last modification (UTC)
        /// </summary>
        public readonly string? LastModifiedAt;
        /// <summary>
        /// The identity that last modified the resource.
        /// </summary>
        public readonly string? LastModifiedBy;
        /// <summary>
        /// The type of identity that last modified the resource.
        /// </summary>
        public readonly string? LastModifiedByType;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The resource provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource Id of the connectivity endpoint (optional).
        /// </summary>
        public readonly string? ResourceId;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetEndpointResult(
            string? createdAt,

            string? createdBy,

            string? createdByType,

            string id,

            string? lastModifiedAt,

            string? lastModifiedBy,

            string? lastModifiedByType,

            string name,

            string provisioningState,

            string? resourceId,

            string type)
        {
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            Id = id;
            LastModifiedAt = lastModifiedAt;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            Name = name;
            ProvisioningState = provisioningState;
            ResourceId = resourceId;
            Type = type;
        }
    }
}
