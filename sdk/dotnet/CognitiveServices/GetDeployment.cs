// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CognitiveServices
{
    public static class GetDeployment
    {
        /// <summary>
        /// Cognitive Services account deployment.
        /// API Version: 2021-10-01.
        /// </summary>
        public static Task<GetDeploymentResult> InvokeAsync(GetDeploymentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDeploymentResult>("azure-native:cognitiveservices:getDeployment", args ?? new GetDeploymentArgs(), options.WithDefaults());

        /// <summary>
        /// Cognitive Services account deployment.
        /// API Version: 2021-10-01.
        /// </summary>
        public static Output<GetDeploymentResult> Invoke(GetDeploymentInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDeploymentResult>("azure-native:cognitiveservices:getDeployment", args ?? new GetDeploymentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDeploymentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of Cognitive Services account.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the deployment associated with the Cognitive Services Account
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
        /// The name of Cognitive Services account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the deployment associated with the Cognitive Services Account
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
        /// Resource Etag.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Properties of Cognitive Services account deployment.
        /// </summary>
        public readonly Outputs.DeploymentPropertiesResponse Properties;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDeploymentResult(
            string etag,

            string id,

            string name,

            Outputs.DeploymentPropertiesResponse properties,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Type = type;
        }
    }
}
