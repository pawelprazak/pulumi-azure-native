// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DesktopVirtualization.V20201110Preview
{
    [Obsolete(@"Version 2020-11-10-preview will be removed in v2 of the provider.")]
    public static class GetHostPool
    {
        /// <summary>
        /// Represents a HostPool definition.
        /// </summary>
        public static Task<GetHostPoolResult> InvokeAsync(GetHostPoolArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetHostPoolResult>("azure-native:desktopvirtualization/v20201110preview:getHostPool", args ?? new GetHostPoolArgs(), options.WithDefaults());

        /// <summary>
        /// Represents a HostPool definition.
        /// </summary>
        public static Output<GetHostPoolResult> Invoke(GetHostPoolInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetHostPoolResult>("azure-native:desktopvirtualization/v20201110preview:getHostPool", args ?? new GetHostPoolInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetHostPoolArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the host pool within the specified resource group
        /// </summary>
        [Input("hostPoolName", required: true)]
        public string HostPoolName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetHostPoolArgs()
        {
        }
    }

    public sealed class GetHostPoolInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the host pool within the specified resource group
        /// </summary>
        [Input("hostPoolName", required: true)]
        public Input<string> HostPoolName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetHostPoolInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetHostPoolResult
    {
        /// <summary>
        /// List of applicationGroup links.
        /// </summary>
        public readonly ImmutableArray<string> ApplicationGroupReferences;
        /// <summary>
        /// Custom rdp property of HostPool.
        /// </summary>
        public readonly string? CustomRdpProperty;
        /// <summary>
        /// Description of HostPool.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Friendly name of HostPool.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// HostPool type for desktop.
        /// </summary>
        public readonly string HostPoolType;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The type of the load balancer.
        /// </summary>
        public readonly string LoadBalancerType;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The max session limit of HostPool.
        /// </summary>
        public readonly int? MaxSessionLimit;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// PersonalDesktopAssignment type for HostPool.
        /// </summary>
        public readonly string? PersonalDesktopAssignmentType;
        /// <summary>
        /// The type of preferred application group type, default to Desktop Application Group
        /// </summary>
        public readonly string PreferredAppGroupType;
        /// <summary>
        /// The registration info of HostPool.
        /// </summary>
        public readonly Outputs.RegistrationInfoResponse? RegistrationInfo;
        /// <summary>
        /// The ring number of HostPool.
        /// </summary>
        public readonly int? Ring;
        /// <summary>
        /// ClientId for the registered Relying Party used to issue WVD SSO certificates.
        /// </summary>
        public readonly string? SsoClientId;
        /// <summary>
        /// Path to Azure KeyVault storing the secret used for communication to ADFS.
        /// </summary>
        public readonly string? SsoClientSecretKeyVaultPath;
        /// <summary>
        /// The type of single sign on Secret Type.
        /// </summary>
        public readonly string? SsoSecretType;
        /// <summary>
        /// URL to customer ADFS server for signing WVD SSO certificates.
        /// </summary>
        public readonly string? SsoadfsAuthority;
        /// <summary>
        /// The flag to turn on/off StartVMOnConnect feature.
        /// </summary>
        public readonly bool? StartVMOnConnect;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Is validation environment.
        /// </summary>
        public readonly bool? ValidationEnvironment;
        /// <summary>
        /// VM template for sessionhosts configuration within hostpool.
        /// </summary>
        public readonly string? VmTemplate;

        [OutputConstructor]
        private GetHostPoolResult(
            ImmutableArray<string> applicationGroupReferences,

            string? customRdpProperty,

            string? description,

            string? friendlyName,

            string hostPoolType,

            string id,

            string loadBalancerType,

            string location,

            int? maxSessionLimit,

            string name,

            string? personalDesktopAssignmentType,

            string preferredAppGroupType,

            Outputs.RegistrationInfoResponse? registrationInfo,

            int? ring,

            string? ssoClientId,

            string? ssoClientSecretKeyVaultPath,

            string? ssoSecretType,

            string? ssoadfsAuthority,

            bool? startVMOnConnect,

            ImmutableDictionary<string, string>? tags,

            string type,

            bool? validationEnvironment,

            string? vmTemplate)
        {
            ApplicationGroupReferences = applicationGroupReferences;
            CustomRdpProperty = customRdpProperty;
            Description = description;
            FriendlyName = friendlyName;
            HostPoolType = hostPoolType;
            Id = id;
            LoadBalancerType = loadBalancerType;
            Location = location;
            MaxSessionLimit = maxSessionLimit;
            Name = name;
            PersonalDesktopAssignmentType = personalDesktopAssignmentType;
            PreferredAppGroupType = preferredAppGroupType;
            RegistrationInfo = registrationInfo;
            Ring = ring;
            SsoClientId = ssoClientId;
            SsoClientSecretKeyVaultPath = ssoClientSecretKeyVaultPath;
            SsoSecretType = ssoSecretType;
            SsoadfsAuthority = ssoadfsAuthority;
            StartVMOnConnect = startVMOnConnect;
            Tags = tags;
            Type = type;
            ValidationEnvironment = validationEnvironment;
            VmTemplate = vmTemplate;
        }
    }
}
