// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20220701Preview
{
    public static class GetDynamics365DataConnector
    {
        /// <summary>
        /// Represents Dynamics365 data connector.
        /// </summary>
        public static Task<GetDynamics365DataConnectorResult> InvokeAsync(GetDynamics365DataConnectorArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDynamics365DataConnectorResult>("azure-native:securityinsights/v20220701preview:getDynamics365DataConnector", args ?? new GetDynamics365DataConnectorArgs(), options.WithDefaults());

        /// <summary>
        /// Represents Dynamics365 data connector.
        /// </summary>
        public static Output<GetDynamics365DataConnectorResult> Invoke(GetDynamics365DataConnectorInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDynamics365DataConnectorResult>("azure-native:securityinsights/v20220701preview:getDynamics365DataConnector", args ?? new GetDynamics365DataConnectorInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDynamics365DataConnectorArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Connector ID
        /// </summary>
        [Input("dataConnectorId", required: true)]
        public string DataConnectorId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetDynamics365DataConnectorArgs()
        {
        }
    }

    public sealed class GetDynamics365DataConnectorInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Connector ID
        /// </summary>
        [Input("dataConnectorId", required: true)]
        public Input<string> DataConnectorId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetDynamics365DataConnectorInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDynamics365DataConnectorResult
    {
        /// <summary>
        /// The available data types for the connector.
        /// </summary>
        public readonly Outputs.Dynamics365DataConnectorDataTypesResponse DataTypes;
        /// <summary>
        /// Etag of the azure resource
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The kind of the data connector
        /// Expected value is 'Dynamics365'.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The tenant id to connect to, and get the data from.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDynamics365DataConnectorResult(
            Outputs.Dynamics365DataConnectorDataTypesResponse dataTypes,

            string? etag,

            string id,

            string kind,

            string name,

            Outputs.SystemDataResponse systemData,

            string tenantId,

            string type)
        {
            DataTypes = dataTypes;
            Etag = etag;
            Id = id;
            Kind = kind;
            Name = name;
            SystemData = systemData;
            TenantId = tenantId;
            Type = type;
        }
    }
}
