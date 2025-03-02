// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StreamAnalytics
{
    public static class GetInput
    {
        /// <summary>
        /// An input object, containing all information associated with the named input. All inputs are contained under a streaming job.
        /// API Version: 2016-03-01.
        /// </summary>
        public static Task<GetInputResult> InvokeAsync(GetInputArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInputResult>("azure-native:streamanalytics:getInput", args ?? new GetInputArgs(), options.WithDefaults());

        /// <summary>
        /// An input object, containing all information associated with the named input. All inputs are contained under a streaming job.
        /// API Version: 2016-03-01.
        /// </summary>
        public static Output<GetInputResult> Invoke(GetInputInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetInputResult>("azure-native:streamanalytics:getInput", args ?? new GetInputInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInputArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the input.
        /// </summary>
        [Input("inputName", required: true)]
        public string InputName { get; set; } = null!;

        /// <summary>
        /// The name of the streaming job.
        /// </summary>
        [Input("jobName", required: true)]
        public string JobName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetInputArgs()
        {
        }
    }

    public sealed class GetInputInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the input.
        /// </summary>
        [Input("inputName", required: true)]
        public Input<string> InputName { get; set; } = null!;

        /// <summary>
        /// The name of the streaming job.
        /// </summary>
        [Input("jobName", required: true)]
        public Input<string> JobName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetInputInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetInputResult
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The properties that are associated with an input. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly Union<Outputs.ReferenceInputPropertiesResponse, Outputs.StreamInputPropertiesResponse> Properties;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetInputResult(
            string id,

            string? name,

            Union<Outputs.ReferenceInputPropertiesResponse, Outputs.StreamInputPropertiesResponse> properties,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
