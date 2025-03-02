// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Maintenance.V20200401
{
    public static class GetMaintenanceConfiguration
    {
        /// <summary>
        /// Maintenance configuration record type
        /// </summary>
        public static Task<GetMaintenanceConfigurationResult> InvokeAsync(GetMaintenanceConfigurationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMaintenanceConfigurationResult>("azure-native:maintenance/v20200401:getMaintenanceConfiguration", args ?? new GetMaintenanceConfigurationArgs(), options.WithDefaults());

        /// <summary>
        /// Maintenance configuration record type
        /// </summary>
        public static Output<GetMaintenanceConfigurationResult> Invoke(GetMaintenanceConfigurationInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetMaintenanceConfigurationResult>("azure-native:maintenance/v20200401:getMaintenanceConfiguration", args ?? new GetMaintenanceConfigurationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMaintenanceConfigurationArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Resource Group Name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Resource Identifier
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public GetMaintenanceConfigurationArgs()
        {
        }
    }

    public sealed class GetMaintenanceConfigurationInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Resource Group Name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Resource Identifier
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        public GetMaintenanceConfigurationInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMaintenanceConfigurationResult
    {
        /// <summary>
        /// Gets or sets extensionProperties of the maintenanceConfiguration. This is for future use only and would be a set of key value pairs for additional information e.g. whether to follow SDP etc.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? ExtensionProperties;
        /// <summary>
        /// Fully qualified identifier of the resource
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Gets or sets location of the resource
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Gets or sets maintenanceScope of the configuration. It represent the impact area of the maintenance
        /// </summary>
        public readonly string? MaintenanceScope;
        /// <summary>
        /// Name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets or sets namespace of the resource e.g. Microsoft.Maintenance or Microsoft.Sql
        /// </summary>
        public readonly string? Namespace;
        /// <summary>
        /// Gets or sets tags of the resource
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Type of the resource
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetMaintenanceConfigurationResult(
            ImmutableDictionary<string, string>? extensionProperties,

            string id,

            string? location,

            string? maintenanceScope,

            string name,

            string? @namespace,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            ExtensionProperties = extensionProperties;
            Id = id;
            Location = location;
            MaintenanceScope = maintenanceScope;
            Name = name;
            Namespace = @namespace;
            Tags = tags;
            Type = type;
        }
    }
}
