// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.V20170901Preview
{
    [Obsolete(@"Version 2017-09-01-preview will be removed in v2 of the provider.")]
    public static class GetDataset
    {
        /// <summary>
        /// Dataset resource type.
        /// </summary>
        public static Task<GetDatasetResult> InvokeAsync(GetDatasetArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDatasetResult>("azure-native:datafactory/v20170901preview:getDataset", args ?? new GetDatasetArgs(), options.WithDefaults());

        /// <summary>
        /// Dataset resource type.
        /// </summary>
        public static Output<GetDatasetResult> Invoke(GetDatasetInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDatasetResult>("azure-native:datafactory/v20170901preview:getDataset", args ?? new GetDatasetInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDatasetArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The dataset name.
        /// </summary>
        [Input("datasetName", required: true)]
        public string DatasetName { get; set; } = null!;

        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName", required: true)]
        public string FactoryName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDatasetArgs()
        {
        }
    }

    public sealed class GetDatasetInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The dataset name.
        /// </summary>
        [Input("datasetName", required: true)]
        public Input<string> DatasetName { get; set; } = null!;

        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName", required: true)]
        public Input<string> FactoryName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetDatasetInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDatasetResult
    {
        /// <summary>
        /// Etag identifies change in the resource.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The resource identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Dataset properties.
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDatasetResult(
            string etag,

            string id,

            string name,

            object properties,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
