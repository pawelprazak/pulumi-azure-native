// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20191201
{
    [Obsolete(@"Version 2019-12-01 will be removed in v2 of the provider.")]
    public static class GetDedicatedHostGroup
    {
        /// <summary>
        /// Specifies information about the dedicated host group that the dedicated hosts should be assigned to. &lt;br&gt;&lt;br&gt; Currently, a dedicated host can only be added to a dedicated host group at creation time. An existing dedicated host cannot be added to another dedicated host group.
        /// </summary>
        public static Task<GetDedicatedHostGroupResult> InvokeAsync(GetDedicatedHostGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDedicatedHostGroupResult>("azure-native:compute/v20191201:getDedicatedHostGroup", args ?? new GetDedicatedHostGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Specifies information about the dedicated host group that the dedicated hosts should be assigned to. &lt;br&gt;&lt;br&gt; Currently, a dedicated host can only be added to a dedicated host group at creation time. An existing dedicated host cannot be added to another dedicated host group.
        /// </summary>
        public static Output<GetDedicatedHostGroupResult> Invoke(GetDedicatedHostGroupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDedicatedHostGroupResult>("azure-native:compute/v20191201:getDedicatedHostGroup", args ?? new GetDedicatedHostGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDedicatedHostGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the dedicated host group.
        /// </summary>
        [Input("hostGroupName", required: true)]
        public string HostGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDedicatedHostGroupArgs()
        {
        }
    }

    public sealed class GetDedicatedHostGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the dedicated host group.
        /// </summary>
        [Input("hostGroupName", required: true)]
        public Input<string> HostGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetDedicatedHostGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDedicatedHostGroupResult
    {
        /// <summary>
        /// A list of references to all dedicated hosts in the dedicated host group.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceReadOnlyResponse> Hosts;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Number of fault domains that the host group can span.
        /// </summary>
        public readonly int PlatformFaultDomainCount;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetDedicatedHostGroupResult(
            ImmutableArray<Outputs.SubResourceReadOnlyResponse> hosts,

            string id,

            string location,

            string name,

            int platformFaultDomainCount,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<string> zones)
        {
            Hosts = hosts;
            Id = id;
            Location = location;
            Name = name;
            PlatformFaultDomainCount = platformFaultDomainCount;
            Tags = tags;
            Type = type;
            Zones = zones;
        }
    }
}
