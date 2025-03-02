// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Peering.V20190801Preview
{
    [Obsolete(@"Version 2019-08-01-preview will be removed in v2 of the provider.")]
    public static class GetPeeringServicePrefix
    {
        /// <summary>
        /// The peering service prefix class.
        /// </summary>
        public static Task<GetPeeringServicePrefixResult> InvokeAsync(GetPeeringServicePrefixArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPeeringServicePrefixResult>("azure-native:peering/v20190801preview:getPeeringServicePrefix", args ?? new GetPeeringServicePrefixArgs(), options.WithDefaults());

        /// <summary>
        /// The peering service prefix class.
        /// </summary>
        public static Output<GetPeeringServicePrefixResult> Invoke(GetPeeringServicePrefixInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPeeringServicePrefixResult>("azure-native:peering/v20190801preview:getPeeringServicePrefix", args ?? new GetPeeringServicePrefixInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPeeringServicePrefixArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The peering service name.
        /// </summary>
        [Input("peeringServiceName", required: true)]
        public string PeeringServiceName { get; set; } = null!;

        /// <summary>
        /// The prefix name.
        /// </summary>
        [Input("prefixName", required: true)]
        public string PrefixName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPeeringServicePrefixArgs()
        {
        }
    }

    public sealed class GetPeeringServicePrefixInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The peering service name.
        /// </summary>
        [Input("peeringServiceName", required: true)]
        public Input<string> PeeringServiceName { get; set; } = null!;

        /// <summary>
        /// The prefix name.
        /// </summary>
        [Input("prefixName", required: true)]
        public Input<string> PrefixName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetPeeringServicePrefixInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPeeringServicePrefixResult
    {
        /// <summary>
        /// The ID of the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The prefix learned type
        /// </summary>
        public readonly string? LearnedType;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Valid route prefix
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// The prefix validation state
        /// </summary>
        public readonly string? PrefixValidationState;
        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPeeringServicePrefixResult(
            string id,

            string? learnedType,

            string name,

            string? prefix,

            string? prefixValidationState,

            string provisioningState,

            string type)
        {
            Id = id;
            LearnedType = learnedType;
            Name = name;
            Prefix = prefix;
            PrefixValidationState = prefixValidationState;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
