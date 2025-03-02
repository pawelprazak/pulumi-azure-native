// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.V20210601
{
    public static class GetProfile
    {
        /// <summary>
        /// A profile is a logical grouping of endpoints that share the same settings.
        /// </summary>
        public static Task<GetProfileResult> InvokeAsync(GetProfileArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProfileResult>("azure-native:cdn/v20210601:getProfile", args ?? new GetProfileArgs(), options.WithDefaults());

        /// <summary>
        /// A profile is a logical grouping of endpoints that share the same settings.
        /// </summary>
        public static Output<GetProfileResult> Invoke(GetProfileInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetProfileResult>("azure-native:cdn/v20210601:getProfile", args ?? new GetProfileInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProfileArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public string ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetProfileArgs()
        {
        }
    }

    public sealed class GetProfileInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetProfileInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProfileResult
    {
        /// <summary>
        /// The Id of the frontdoor.
        /// </summary>
        public readonly string FrontDoorId;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of the profile. Used by portal to differentiate traditional CDN profile and new AFD profile.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        public readonly int? OriginResponseTimeoutSeconds;
        /// <summary>
        /// Provisioning status of the profile.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource status of the profile.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// The pricing tier (defines Azure Front Door Standard or Premium or a CDN provider, feature list and rate) of the profile.
        /// </summary>
        public readonly Outputs.SkuResponse Sku;
        /// <summary>
        /// Read only system data
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetProfileResult(
            string frontDoorId,

            string id,

            string kind,

            string location,

            string name,

            int? originResponseTimeoutSeconds,

            string provisioningState,

            string resourceState,

            Outputs.SkuResponse sku,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            FrontDoorId = frontDoorId;
            Id = id;
            Kind = kind;
            Location = location;
            Name = name;
            OriginResponseTimeoutSeconds = originResponseTimeoutSeconds;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            Sku = sku;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
