// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network
{
    public static class GetNspAssociationsProxy
    {
        /// <summary>
        /// The NSP resource association resource
        /// API Version: 2021-02-01-preview.
        /// </summary>
        public static Task<GetNspAssociationsProxyResult> InvokeAsync(GetNspAssociationsProxyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNspAssociationsProxyResult>("azure-native:network:getNspAssociationsProxy", args ?? new GetNspAssociationsProxyArgs(), options.WithDefaults());

        /// <summary>
        /// The NSP resource association resource
        /// API Version: 2021-02-01-preview.
        /// </summary>
        public static Output<GetNspAssociationsProxyResult> Invoke(GetNspAssociationsProxyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetNspAssociationsProxyResult>("azure-native:network:getNspAssociationsProxy", args ?? new GetNspAssociationsProxyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNspAssociationsProxyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the NSP association.
        /// </summary>
        [Input("associationName", required: true)]
        public string AssociationName { get; set; } = null!;

        /// <summary>
        /// The name of the network security perimeter.
        /// </summary>
        [Input("networkSecurityPerimeterName", required: true)]
        public string NetworkSecurityPerimeterName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetNspAssociationsProxyArgs()
        {
        }
    }

    public sealed class GetNspAssociationsProxyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the NSP association.
        /// </summary>
        [Input("associationName", required: true)]
        public Input<string> AssociationName { get; set; } = null!;

        /// <summary>
        /// The name of the network security perimeter.
        /// </summary>
        [Input("networkSecurityPerimeterName", required: true)]
        public Input<string> NetworkSecurityPerimeterName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetNspAssociationsProxyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetNspAssociationsProxyResult
    {
        /// <summary>
        /// Access mode on the association.
        /// </summary>
        public readonly string? AccessMode;
        /// <summary>
        /// Specifies if there are provisioning issues
        /// </summary>
        public readonly string HasProvisioningIssues;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The PaaS resource to be associated.
        /// </summary>
        public readonly Outputs.SubResourceResponse? PrivateLinkResource;
        /// <summary>
        /// Profile id to which the PaaS resource is associated.
        /// </summary>
        public readonly Outputs.SubResourceResponse? Profile;
        /// <summary>
        /// The provisioning state of the resource  association resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetNspAssociationsProxyResult(
            string? accessMode,

            string hasProvisioningIssues,

            string id,

            string? location,

            string name,

            Outputs.SubResourceResponse? privateLinkResource,

            Outputs.SubResourceResponse? profile,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            AccessMode = accessMode;
            HasProvisioningIssues = hasProvisioningIssues;
            Id = id;
            Location = location;
            Name = name;
            PrivateLinkResource = privateLinkResource;
            Profile = profile;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
        }
    }
}
