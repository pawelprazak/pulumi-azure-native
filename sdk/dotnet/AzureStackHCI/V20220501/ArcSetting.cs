// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureStackHCI.V20220501
{
    /// <summary>
    /// ArcSetting details.
    /// </summary>
    [AzureNativeResourceType("azure-native:azurestackhci/v20220501:ArcSetting")]
    public partial class ArcSetting : Pulumi.CustomResource
    {
        /// <summary>
        /// Aggregate state of Arc agent across the nodes in this HCI cluster.
        /// </summary>
        [Output("aggregateState")]
        public Output<string> AggregateState { get; private set; } = null!;

        /// <summary>
        /// App id of arc AAD identity.
        /// </summary>
        [Output("arcApplicationClientId")]
        public Output<string?> ArcApplicationClientId { get; private set; } = null!;

        /// <summary>
        /// Object id of arc AAD identity.
        /// </summary>
        [Output("arcApplicationObjectId")]
        public Output<string?> ArcApplicationObjectId { get; private set; } = null!;

        /// <summary>
        /// Tenant id of arc AAD identity.
        /// </summary>
        [Output("arcApplicationTenantId")]
        public Output<string?> ArcApplicationTenantId { get; private set; } = null!;

        /// <summary>
        /// The resource group that hosts the Arc agents, ie. Hybrid Compute Machine resources.
        /// </summary>
        [Output("arcInstanceResourceGroup")]
        public Output<string?> ArcInstanceResourceGroup { get; private set; } = null!;

        /// <summary>
        /// Object id of arc AAD service principal.
        /// </summary>
        [Output("arcServicePrincipalObjectId")]
        public Output<string?> ArcServicePrincipalObjectId { get; private set; } = null!;

        /// <summary>
        /// contains connectivity related configuration for ARC resources
        /// </summary>
        [Output("connectivityProperties")]
        public Output<ImmutableArray<Outputs.ArcConnectivityPropertiesResponse>> ConnectivityProperties { get; private set; } = null!;

        /// <summary>
        /// The timestamp of resource creation (UTC).
        /// </summary>
        [Output("createdAt")]
        public Output<string?> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// The identity that created the resource.
        /// </summary>
        [Output("createdBy")]
        public Output<string?> CreatedBy { get; private set; } = null!;

        /// <summary>
        /// The type of identity that created the resource.
        /// </summary>
        [Output("createdByType")]
        public Output<string?> CreatedByType { get; private set; } = null!;

        /// <summary>
        /// The timestamp of resource last modification (UTC)
        /// </summary>
        [Output("lastModifiedAt")]
        public Output<string?> LastModifiedAt { get; private set; } = null!;

        /// <summary>
        /// The identity that last modified the resource.
        /// </summary>
        [Output("lastModifiedBy")]
        public Output<string?> LastModifiedBy { get; private set; } = null!;

        /// <summary>
        /// The type of identity that last modified the resource.
        /// </summary>
        [Output("lastModifiedByType")]
        public Output<string?> LastModifiedByType { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// State of Arc agent in each of the nodes.
        /// </summary>
        [Output("perNodeDetails")]
        public Output<ImmutableArray<Outputs.PerNodeStateResponse>> PerNodeDetails { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the ArcSetting proxy resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ArcSetting resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ArcSetting(string name, ArcSettingArgs args, CustomResourceOptions? options = null)
            : base("azure-native:azurestackhci/v20220501:ArcSetting", name, args ?? new ArcSettingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ArcSetting(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:azurestackhci/v20220501:ArcSetting", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:azurestackhci:ArcSetting"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20210101preview:ArcSetting"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20210901:ArcSetting"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20220101:ArcSetting"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20220301:ArcSetting"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ArcSetting resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ArcSetting Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ArcSetting(name, id, options);
        }
    }

    public sealed class ArcSettingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// App id of arc AAD identity.
        /// </summary>
        [Input("arcApplicationClientId")]
        public Input<string>? ArcApplicationClientId { get; set; }

        /// <summary>
        /// Object id of arc AAD identity.
        /// </summary>
        [Input("arcApplicationObjectId")]
        public Input<string>? ArcApplicationObjectId { get; set; }

        /// <summary>
        /// Tenant id of arc AAD identity.
        /// </summary>
        [Input("arcApplicationTenantId")]
        public Input<string>? ArcApplicationTenantId { get; set; }

        /// <summary>
        /// The resource group that hosts the Arc agents, ie. Hybrid Compute Machine resources.
        /// </summary>
        [Input("arcInstanceResourceGroup")]
        public Input<string>? ArcInstanceResourceGroup { get; set; }

        /// <summary>
        /// Object id of arc AAD service principal.
        /// </summary>
        [Input("arcServicePrincipalObjectId")]
        public Input<string>? ArcServicePrincipalObjectId { get; set; }

        /// <summary>
        /// The name of the proxy resource holding details of HCI ArcSetting information.
        /// </summary>
        [Input("arcSettingName")]
        public Input<string>? ArcSettingName { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        [Input("connectivityProperties")]
        private InputList<Inputs.ArcConnectivityPropertiesArgs>? _connectivityProperties;

        /// <summary>
        /// contains connectivity related configuration for ARC resources
        /// </summary>
        public InputList<Inputs.ArcConnectivityPropertiesArgs> ConnectivityProperties
        {
            get => _connectivityProperties ?? (_connectivityProperties = new InputList<Inputs.ArcConnectivityPropertiesArgs>());
            set => _connectivityProperties = value;
        }

        /// <summary>
        /// The timestamp of resource creation (UTC).
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// The identity that created the resource.
        /// </summary>
        [Input("createdBy")]
        public Input<string>? CreatedBy { get; set; }

        /// <summary>
        /// The type of identity that created the resource.
        /// </summary>
        [Input("createdByType")]
        public InputUnion<string, Pulumi.AzureNative.AzureStackHCI.V20220501.CreatedByType>? CreatedByType { get; set; }

        /// <summary>
        /// The timestamp of resource last modification (UTC)
        /// </summary>
        [Input("lastModifiedAt")]
        public Input<string>? LastModifiedAt { get; set; }

        /// <summary>
        /// The identity that last modified the resource.
        /// </summary>
        [Input("lastModifiedBy")]
        public Input<string>? LastModifiedBy { get; set; }

        /// <summary>
        /// The type of identity that last modified the resource.
        /// </summary>
        [Input("lastModifiedByType")]
        public InputUnion<string, Pulumi.AzureNative.AzureStackHCI.V20220501.CreatedByType>? LastModifiedByType { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ArcSettingArgs()
        {
        }
    }
}
