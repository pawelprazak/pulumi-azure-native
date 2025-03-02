// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20200901Preview
{
    public static class GetACIService
    {
        /// <summary>
        /// Machine Learning service object wrapped into ARM resource envelope.
        /// </summary>
        public static Task<GetACIServiceResult> InvokeAsync(GetACIServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetACIServiceResult>("azure-native:machinelearningservices/v20200901preview:getACIService", args ?? new GetACIServiceArgs(), options.WithDefaults());

        /// <summary>
        /// Machine Learning service object wrapped into ARM resource envelope.
        /// </summary>
        public static Output<GetACIServiceResult> Invoke(GetACIServiceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetACIServiceResult>("azure-native:machinelearningservices/v20200901preview:getACIService", args ?? new GetACIServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetACIServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Set to True to include Model details.
        /// </summary>
        [Input("expand")]
        public bool? Expand { get; set; }

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Machine Learning service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetACIServiceArgs()
        {
        }
    }

    public sealed class GetACIServiceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Set to True to include Model details.
        /// </summary>
        [Input("expand")]
        public Input<bool>? Expand { get; set; }

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Machine Learning service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetACIServiceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetACIServiceResult
    {
        /// <summary>
        /// Specifies the resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity of the resource.
        /// </summary>
        public readonly Outputs.IdentityResponse? Identity;
        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Specifies the name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Service properties
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// The sku of the workspace.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Specifies the type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetACIServiceResult(
            string id,

            Outputs.IdentityResponse? identity,

            string? location,

            string name,

            object properties,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Id = id;
            Identity = identity;
            Location = location;
            Name = name;
            Properties = properties;
            Sku = sku;
            Tags = tags;
            Type = type;
        }
    }
}
