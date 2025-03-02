// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Security.V20200101
{
    public static class GetJitNetworkAccessPolicy
    {
        public static Task<GetJitNetworkAccessPolicyResult> InvokeAsync(GetJitNetworkAccessPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJitNetworkAccessPolicyResult>("azure-native:security/v20200101:getJitNetworkAccessPolicy", args ?? new GetJitNetworkAccessPolicyArgs(), options.WithDefaults());

        public static Output<GetJitNetworkAccessPolicyResult> Invoke(GetJitNetworkAccessPolicyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetJitNetworkAccessPolicyResult>("azure-native:security/v20200101:getJitNetworkAccessPolicy", args ?? new GetJitNetworkAccessPolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetJitNetworkAccessPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The location where ASC stores the data of the subscription. can be retrieved from Get locations
        /// </summary>
        [Input("ascLocation", required: true)]
        public string AscLocation { get; set; } = null!;

        /// <summary>
        /// Name of a Just-in-Time access configuration policy.
        /// </summary>
        [Input("jitNetworkAccessPolicyName", required: true)]
        public string JitNetworkAccessPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetJitNetworkAccessPolicyArgs()
        {
        }
    }

    public sealed class GetJitNetworkAccessPolicyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The location where ASC stores the data of the subscription. can be retrieved from Get locations
        /// </summary>
        [Input("ascLocation", required: true)]
        public Input<string> AscLocation { get; set; } = null!;

        /// <summary>
        /// Name of a Just-in-Time access configuration policy.
        /// </summary>
        [Input("jitNetworkAccessPolicyName", required: true)]
        public Input<string> JitNetworkAccessPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetJitNetworkAccessPolicyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetJitNetworkAccessPolicyResult
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of the resource
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Location where the resource is stored
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets the provisioning state of the Just-in-Time policy.
        /// </summary>
        public readonly string ProvisioningState;
        public readonly ImmutableArray<Outputs.JitNetworkAccessRequestResponse> Requests;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Configurations for Microsoft.Compute/virtualMachines resource type.
        /// </summary>
        public readonly ImmutableArray<Outputs.JitNetworkAccessPolicyVirtualMachineResponse> VirtualMachines;

        [OutputConstructor]
        private GetJitNetworkAccessPolicyResult(
            string id,

            string? kind,

            string location,

            string name,

            string provisioningState,

            ImmutableArray<Outputs.JitNetworkAccessRequestResponse> requests,

            string type,

            ImmutableArray<Outputs.JitNetworkAccessPolicyVirtualMachineResponse> virtualMachines)
        {
            Id = id;
            Kind = kind;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Requests = requests;
            Type = type;
            VirtualMachines = virtualMachines;
        }
    }
}
