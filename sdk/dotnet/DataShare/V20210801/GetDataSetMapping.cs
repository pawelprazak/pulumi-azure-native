// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataShare.V20210801
{
    [Obsolete(@"Please use one of the variants: ADLSGen2FileDataSetMapping, ADLSGen2FileSystemDataSetMapping, ADLSGen2FolderDataSetMapping, BlobContainerDataSetMapping, BlobDataSetMapping, BlobFolderDataSetMapping, KustoClusterDataSetMapping, KustoDatabaseDataSetMapping, KustoTableDataSetMapping, SqlDBTableDataSetMapping, SqlDWTableDataSetMapping, SynapseWorkspaceSqlPoolTableDataSetMapping.")]
    public static class GetDataSetMapping
    {
        /// <summary>
        /// A data set mapping data transfer object.
        /// </summary>
        public static Task<GetDataSetMappingResult> InvokeAsync(GetDataSetMappingArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDataSetMappingResult>("azure-native:datashare/v20210801:getDataSetMapping", args ?? new GetDataSetMappingArgs(), options.WithDefaults());

        /// <summary>
        /// A data set mapping data transfer object.
        /// </summary>
        public static Output<GetDataSetMappingResult> Invoke(GetDataSetMappingInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDataSetMappingResult>("azure-native:datashare/v20210801:getDataSetMapping", args ?? new GetDataSetMappingInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDataSetMappingArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the dataSetMapping.
        /// </summary>
        [Input("dataSetMappingName", required: true)]
        public string DataSetMappingName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public string ShareSubscriptionName { get; set; } = null!;

        public GetDataSetMappingArgs()
        {
        }
    }

    public sealed class GetDataSetMappingInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the dataSetMapping.
        /// </summary>
        [Input("dataSetMappingName", required: true)]
        public Input<string> DataSetMappingName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public Input<string> ShareSubscriptionName { get; set; } = null!;

        public GetDataSetMappingInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDataSetMappingResult
    {
        /// <summary>
        /// The resource id of the azure resource
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of data set mapping.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the azure resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// System Data of the Azure resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Type of the azure resource
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDataSetMappingResult(
            string id,

            string kind,

            string name,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Kind = kind;
            Name = name;
            SystemData = systemData;
            Type = type;
        }
    }
}
