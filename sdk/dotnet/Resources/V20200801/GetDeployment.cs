// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Resources.V20200801
{
    public static class GetDeployment
    {
        /// <summary>
        /// Deployment information.
        /// </summary>
        public static Task<GetDeploymentResult> InvokeAsync(GetDeploymentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDeploymentResult>("azure-native:resources/v20200801:getDeployment", args ?? new GetDeploymentArgs(), options.WithDefaults());

        /// <summary>
        /// Deployment information.
        /// </summary>
        public static Output<GetDeploymentResult> Invoke(GetDeploymentInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDeploymentResult>("azure-native:resources/v20200801:getDeployment", args ?? new GetDeploymentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDeploymentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [Input("deploymentName", required: true)]
        public string DeploymentName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDeploymentArgs()
        {
        }
    }

    public sealed class GetDeploymentInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [Input("deploymentName", required: true)]
        public Input<string> DeploymentName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetDeploymentInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDeploymentResult
    {
        /// <summary>
        /// The ID of the deployment.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// the location of the deployment.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Deployment properties.
        /// </summary>
        public readonly Outputs.DeploymentPropertiesExtendedResponse Properties;
        /// <summary>
        /// Deployment tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the deployment.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDeploymentResult(
            string id,

            string? location,

            string name,

            Outputs.DeploymentPropertiesExtendedResponse properties,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Id = id;
            Location = location;
            Name = name;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
