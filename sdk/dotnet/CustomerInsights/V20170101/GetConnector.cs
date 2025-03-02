// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CustomerInsights.V20170101
{
    [Obsolete(@"Version 2017-01-01 will be removed in v2 of the provider.")]
    public static class GetConnector
    {
        /// <summary>
        /// The connector resource format.
        /// </summary>
        public static Task<GetConnectorResult> InvokeAsync(GetConnectorArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConnectorResult>("azure-native:customerinsights/v20170101:getConnector", args ?? new GetConnectorArgs(), options.WithDefaults());

        /// <summary>
        /// The connector resource format.
        /// </summary>
        public static Output<GetConnectorResult> Invoke(GetConnectorInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConnectorResult>("azure-native:customerinsights/v20170101:getConnector", args ?? new GetConnectorInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConnectorArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the connector.
        /// </summary>
        [Input("connectorName", required: true)]
        public string ConnectorName { get; set; } = null!;

        /// <summary>
        /// The name of the hub.
        /// </summary>
        [Input("hubName", required: true)]
        public string HubName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetConnectorArgs()
        {
        }
    }

    public sealed class GetConnectorInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the connector.
        /// </summary>
        [Input("connectorName", required: true)]
        public Input<string> ConnectorName { get; set; } = null!;

        /// <summary>
        /// The name of the hub.
        /// </summary>
        [Input("hubName", required: true)]
        public Input<string> HubName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetConnectorInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConnectorResult
    {
        /// <summary>
        /// ID of the connector.
        /// </summary>
        public readonly int ConnectorId;
        /// <summary>
        /// Name of the connector.
        /// </summary>
        public readonly string? ConnectorName;
        /// <summary>
        /// The connector properties.
        /// </summary>
        public readonly ImmutableDictionary<string, object> ConnectorProperties;
        /// <summary>
        /// Type of connector.
        /// </summary>
        public readonly string ConnectorType;
        /// <summary>
        /// The created time.
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// Description of the connector.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Display name of the connector.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// If this is an internal connector.
        /// </summary>
        public readonly bool? IsInternal;
        /// <summary>
        /// The last modified time.
        /// </summary>
        public readonly string LastModified;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// State of connector.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The hub name.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetConnectorResult(
            int connectorId,

            string? connectorName,

            ImmutableDictionary<string, object> connectorProperties,

            string connectorType,

            string created,

            string? description,

            string? displayName,

            string id,

            bool? isInternal,

            string lastModified,

            string name,

            string state,

            string tenantId,

            string type)
        {
            ConnectorId = connectorId;
            ConnectorName = connectorName;
            ConnectorProperties = connectorProperties;
            ConnectorType = connectorType;
            Created = created;
            Description = description;
            DisplayName = displayName;
            Id = id;
            IsInternal = isInternal;
            LastModified = lastModified;
            Name = name;
            State = state;
            TenantId = tenantId;
            Type = type;
        }
    }
}
