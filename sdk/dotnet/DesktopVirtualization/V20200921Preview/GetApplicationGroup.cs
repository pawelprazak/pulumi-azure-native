// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DesktopVirtualization.V20200921Preview
{
    [Obsolete(@"Version 2020-09-21-preview will be removed in v2 of the provider.")]
    public static class GetApplicationGroup
    {
        /// <summary>
        /// Represents a ApplicationGroup definition.
        /// </summary>
        public static Task<GetApplicationGroupResult> InvokeAsync(GetApplicationGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApplicationGroupResult>("azure-native:desktopvirtualization/v20200921preview:getApplicationGroup", args ?? new GetApplicationGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Represents a ApplicationGroup definition.
        /// </summary>
        public static Output<GetApplicationGroupResult> Invoke(GetApplicationGroupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetApplicationGroupResult>("azure-native:desktopvirtualization/v20200921preview:getApplicationGroup", args ?? new GetApplicationGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApplicationGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application group
        /// </summary>
        [Input("applicationGroupName", required: true)]
        public string ApplicationGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetApplicationGroupArgs()
        {
        }
    }

    public sealed class GetApplicationGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application group
        /// </summary>
        [Input("applicationGroupName", required: true)]
        public Input<string> ApplicationGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetApplicationGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApplicationGroupResult
    {
        /// <summary>
        /// Resource Type of ApplicationGroup.
        /// </summary>
        public readonly string ApplicationGroupType;
        /// <summary>
        /// Description of ApplicationGroup.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Friendly name of ApplicationGroup.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// HostPool arm path of ApplicationGroup.
        /// </summary>
        public readonly string HostPoolArmPath;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Workspace arm path of ApplicationGroup.
        /// </summary>
        public readonly string WorkspaceArmPath;

        [OutputConstructor]
        private GetApplicationGroupResult(
            string applicationGroupType,

            string? description,

            string? friendlyName,

            string hostPoolArmPath,

            string id,

            string location,

            string name,

            ImmutableDictionary<string, string>? tags,

            string type,

            string workspaceArmPath)
        {
            ApplicationGroupType = applicationGroupType;
            Description = description;
            FriendlyName = friendlyName;
            HostPoolArmPath = hostPoolArmPath;
            Id = id;
            Location = location;
            Name = name;
            Tags = tags;
            Type = type;
            WorkspaceArmPath = workspaceArmPath;
        }
    }
}
