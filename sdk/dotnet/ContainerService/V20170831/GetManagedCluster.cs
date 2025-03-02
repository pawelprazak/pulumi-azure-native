// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20170831
{
    [Obsolete(@"Version 2017-08-31 will be removed in v2 of the provider.")]
    public static class GetManagedCluster
    {
        /// <summary>
        /// Managed cluster.
        /// </summary>
        public static Task<GetManagedClusterResult> InvokeAsync(GetManagedClusterArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetManagedClusterResult>("azure-native:containerservice/v20170831:getManagedCluster", args ?? new GetManagedClusterArgs(), options.WithDefaults());

        /// <summary>
        /// Managed cluster.
        /// </summary>
        public static Output<GetManagedClusterResult> Invoke(GetManagedClusterInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetManagedClusterResult>("azure-native:containerservice/v20170831:getManagedCluster", args ?? new GetManagedClusterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetManagedClusterArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the managed cluster resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public GetManagedClusterArgs()
        {
        }
    }

    public sealed class GetManagedClusterInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the managed cluster resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        public GetManagedClusterInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetManagedClusterResult
    {
        /// <summary>
        /// Properties of the agent pool.
        /// </summary>
        public readonly ImmutableArray<Outputs.ContainerServiceAgentPoolProfileResponse> AgentPoolProfiles;
        /// <summary>
        /// DNS prefix specified when creating the managed cluster.
        /// </summary>
        public readonly string? DnsPrefix;
        /// <summary>
        /// FQDN for the master pool.
        /// </summary>
        public readonly string Fqdn;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Version of Kubernetes specified when creating the managed cluster.
        /// </summary>
        public readonly string? KubernetesVersion;
        /// <summary>
        /// Profile for Linux VMs in the container service cluster.
        /// </summary>
        public readonly Outputs.ContainerServiceLinuxProfileResponse? LinuxProfile;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Information about a service principal identity for the cluster to use for manipulating Azure APIs. Either secret or keyVaultSecretRef must be specified.
        /// </summary>
        public readonly Outputs.ContainerServiceServicePrincipalProfileResponse? ServicePrincipalProfile;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetManagedClusterResult(
            ImmutableArray<Outputs.ContainerServiceAgentPoolProfileResponse> agentPoolProfiles,

            string? dnsPrefix,

            string fqdn,

            string id,

            string? kubernetesVersion,

            Outputs.ContainerServiceLinuxProfileResponse? linuxProfile,

            string location,

            string name,

            string provisioningState,

            Outputs.ContainerServiceServicePrincipalProfileResponse? servicePrincipalProfile,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            AgentPoolProfiles = agentPoolProfiles;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
            Id = id;
            KubernetesVersion = kubernetesVersion;
            LinuxProfile = linuxProfile;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            ServicePrincipalProfile = servicePrincipalProfile;
            Tags = tags;
            Type = type;
        }
    }
}
