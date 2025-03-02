// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20210401
{
    public static class GetDataCollectionEndpoint
    {
        /// <summary>
        /// Definition of ARM tracked top level resource.
        /// </summary>
        public static Task<GetDataCollectionEndpointResult> InvokeAsync(GetDataCollectionEndpointArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDataCollectionEndpointResult>("azure-native:insights/v20210401:getDataCollectionEndpoint", args ?? new GetDataCollectionEndpointArgs(), options.WithDefaults());

        /// <summary>
        /// Definition of ARM tracked top level resource.
        /// </summary>
        public static Output<GetDataCollectionEndpointResult> Invoke(GetDataCollectionEndpointInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDataCollectionEndpointResult>("azure-native:insights/v20210401:getDataCollectionEndpoint", args ?? new GetDataCollectionEndpointInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDataCollectionEndpointArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the data collection endpoint. The name is case insensitive.
        /// </summary>
        [Input("dataCollectionEndpointName", required: true)]
        public string DataCollectionEndpointName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDataCollectionEndpointArgs()
        {
        }
    }

    public sealed class GetDataCollectionEndpointInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the data collection endpoint. The name is case insensitive.
        /// </summary>
        [Input("dataCollectionEndpointName", required: true)]
        public Input<string> DataCollectionEndpointName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetDataCollectionEndpointInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDataCollectionEndpointResult
    {
        /// <summary>
        /// The endpoint used by agents to access their configuration.
        /// </summary>
        public readonly Outputs.DataCollectionEndpointResponseConfigurationAccess? ConfigurationAccess;
        /// <summary>
        /// Description of the data collection endpoint.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Resource entity tag (ETag).
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Fully qualified ID of the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The immutable ID of this data collection endpoint resource. This property is READ-ONLY.
        /// </summary>
        public readonly string? ImmutableId;
        /// <summary>
        /// The kind of the resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// The geo-location where the resource lives.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The endpoint used by clients to ingest logs.
        /// </summary>
        public readonly Outputs.DataCollectionEndpointResponseLogsIngestion? LogsIngestion;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Network access control rules for the endpoints.
        /// </summary>
        public readonly Outputs.DataCollectionEndpointResponseNetworkAcls? NetworkAcls;
        /// <summary>
        /// The resource provisioning state. This property is READ-ONLY.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.DataCollectionEndpointResourceResponseSystemData SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDataCollectionEndpointResult(
            Outputs.DataCollectionEndpointResponseConfigurationAccess? configurationAccess,

            string? description,

            string etag,

            string id,

            string? immutableId,

            string? kind,

            string location,

            Outputs.DataCollectionEndpointResponseLogsIngestion? logsIngestion,

            string name,

            Outputs.DataCollectionEndpointResponseNetworkAcls? networkAcls,

            string provisioningState,

            Outputs.DataCollectionEndpointResourceResponseSystemData systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            ConfigurationAccess = configurationAccess;
            Description = description;
            Etag = etag;
            Id = id;
            ImmutableId = immutableId;
            Kind = kind;
            Location = location;
            LogsIngestion = logsIngestion;
            Name = name;
            NetworkAcls = networkAcls;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
