// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureStackHCI.V20210901
{
    /// <summary>
    /// Cluster details.
    /// </summary>
    [AzureNativeResourceType("azure-native:azurestackhci/v20210901:Cluster")]
    public partial class Cluster : Pulumi.CustomResource
    {
        /// <summary>
        /// App id of cluster AAD identity.
        /// </summary>
        [Output("aadClientId")]
        public Output<string> AadClientId { get; private set; } = null!;

        /// <summary>
        /// Tenant id of cluster AAD identity.
        /// </summary>
        [Output("aadTenantId")]
        public Output<string> AadTenantId { get; private set; } = null!;

        /// <summary>
        /// Type of billing applied to the resource.
        /// </summary>
        [Output("billingModel")]
        public Output<string> BillingModel { get; private set; } = null!;

        /// <summary>
        /// Unique, immutable resource id.
        /// </summary>
        [Output("cloudId")]
        public Output<string> CloudId { get; private set; } = null!;

        /// <summary>
        /// Endpoint configured for management from the Azure portal.
        /// </summary>
        [Output("cloudManagementEndpoint")]
        public Output<string?> CloudManagementEndpoint { get; private set; } = null!;

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
        /// Desired properties of the cluster.
        /// </summary>
        [Output("desiredProperties")]
        public Output<Outputs.ClusterDesiredPropertiesResponse?> DesiredProperties { get; private set; } = null!;

        /// <summary>
        /// Most recent billing meter timestamp.
        /// </summary>
        [Output("lastBillingTimestamp")]
        public Output<string> LastBillingTimestamp { get; private set; } = null!;

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
        /// Most recent cluster sync timestamp.
        /// </summary>
        [Output("lastSyncTimestamp")]
        public Output<string> LastSyncTimestamp { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// First cluster sync timestamp.
        /// </summary>
        [Output("registrationTimestamp")]
        public Output<string> RegistrationTimestamp { get; private set; } = null!;

        /// <summary>
        /// Properties reported by cluster agent.
        /// </summary>
        [Output("reportedProperties")]
        public Output<Outputs.ClusterReportedPropertiesResponse> ReportedProperties { get; private set; } = null!;

        /// <summary>
        /// Status of the cluster agent.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Number of days remaining in the trial period.
        /// </summary>
        [Output("trialDaysRemaining")]
        public Output<double> TrialDaysRemaining { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Cluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Cluster(string name, ClusterArgs args, CustomResourceOptions? options = null)
            : base("azure-native:azurestackhci/v20210901:Cluster", name, args ?? new ClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Cluster(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:azurestackhci/v20210901:Cluster", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:azurestackhci:Cluster"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20200301preview:Cluster"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20201001:Cluster"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20210101preview:Cluster"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20220101:Cluster"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20220301:Cluster"},
                    new Pulumi.Alias { Type = "azure-native:azurestackhci/v20220501:Cluster"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Cluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Cluster Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Cluster(name, id, options);
        }
    }

    public sealed class ClusterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// App id of cluster AAD identity.
        /// </summary>
        [Input("aadClientId", required: true)]
        public Input<string> AadClientId { get; set; } = null!;

        /// <summary>
        /// Tenant id of cluster AAD identity.
        /// </summary>
        [Input("aadTenantId", required: true)]
        public Input<string> AadTenantId { get; set; } = null!;

        /// <summary>
        /// Endpoint configured for management from the Azure portal.
        /// </summary>
        [Input("cloudManagementEndpoint")]
        public Input<string>? CloudManagementEndpoint { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

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
        public InputUnion<string, Pulumi.AzureNative.AzureStackHCI.V20210901.CreatedByType>? CreatedByType { get; set; }

        /// <summary>
        /// Desired properties of the cluster.
        /// </summary>
        [Input("desiredProperties")]
        public Input<Inputs.ClusterDesiredPropertiesArgs>? DesiredProperties { get; set; }

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
        public InputUnion<string, Pulumi.AzureNative.AzureStackHCI.V20210901.CreatedByType>? LastModifiedByType { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ClusterArgs()
        {
        }
    }
}
