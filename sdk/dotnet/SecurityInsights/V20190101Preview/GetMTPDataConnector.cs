// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20190101Preview
{
    public static class GetMTPDataConnector
    {
        /// <summary>
        /// Represents MTP (Microsoft Threat Protection) data connector.
        /// </summary>
        public static Task<GetMTPDataConnectorResult> InvokeAsync(GetMTPDataConnectorArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMTPDataConnectorResult>("azure-native:securityinsights/v20190101preview:getMTPDataConnector", args ?? new GetMTPDataConnectorArgs(), options.WithDefaults());

        /// <summary>
        /// Represents MTP (Microsoft Threat Protection) data connector.
        /// </summary>
        public static Output<GetMTPDataConnectorResult> Invoke(GetMTPDataConnectorInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetMTPDataConnectorResult>("azure-native:securityinsights/v20190101preview:getMTPDataConnector", args ?? new GetMTPDataConnectorInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMTPDataConnectorArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Connector ID
        /// </summary>
        [Input("dataConnectorId", required: true)]
        public string DataConnectorId { get; set; } = null!;

        /// <summary>
        /// The namespace of workspaces resource provider- Microsoft.OperationalInsights.
        /// </summary>
        [Input("operationalInsightsResourceProvider", required: true)]
        public string OperationalInsightsResourceProvider { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetMTPDataConnectorArgs()
        {
        }
    }

    public sealed class GetMTPDataConnectorInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Connector ID
        /// </summary>
        [Input("dataConnectorId", required: true)]
        public Input<string> DataConnectorId { get; set; } = null!;

        /// <summary>
        /// The namespace of workspaces resource provider- Microsoft.OperationalInsights.
        /// </summary>
        [Input("operationalInsightsResourceProvider", required: true)]
        public Input<string> OperationalInsightsResourceProvider { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetMTPDataConnectorInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMTPDataConnectorResult
    {
        /// <summary>
        /// The available data types for the connector.
        /// </summary>
        public readonly Outputs.MTPDataConnectorDataTypesResponse DataTypes;
        /// <summary>
        /// Etag of the azure resource
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Azure resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// 
        /// Expected value is 'MicrosoftThreatProtection'.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Azure resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The tenant id to connect to, and get the data from.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// Azure resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetMTPDataConnectorResult(
            Outputs.MTPDataConnectorDataTypesResponse dataTypes,

            string? etag,

            string id,

            string kind,

            string name,

            string tenantId,

            string type)
        {
            DataTypes = dataTypes;
            Etag = etag;
            Id = id;
            Kind = kind;
            Name = name;
            TenantId = tenantId;
            Type = type;
        }
    }
}
