// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Aad.V20170601
{
    /// <summary>
    /// Domain service.
    /// </summary>
    [Obsolete(@"Version 2017-06-01 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:aad/v20170601:DomainService")]
    public partial class DomainService : Pulumi.CustomResource
    {
        /// <summary>
        /// Deployment Id
        /// </summary>
        [Output("deploymentId")]
        public Output<string> DeploymentId { get; private set; } = null!;

        /// <summary>
        /// Domain Configuration Type
        /// </summary>
        [Output("domainConfigurationType")]
        public Output<string?> DomainConfigurationType { get; private set; } = null!;

        /// <summary>
        /// List of Domain Controller IP Address
        /// </summary>
        [Output("domainControllerIpAddress")]
        public Output<ImmutableArray<string>> DomainControllerIpAddress { get; private set; } = null!;

        /// <summary>
        /// The name of the Azure domain that the user would like to deploy Domain Services to.
        /// </summary>
        [Output("domainName")]
        public Output<string?> DomainName { get; private set; } = null!;

        /// <summary>
        /// DomainSecurity Settings
        /// </summary>
        [Output("domainSecuritySettings")]
        public Output<Outputs.DomainSecuritySettingsResponse?> DomainSecuritySettings { get; private set; } = null!;

        /// <summary>
        /// Resource etag
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Enabled or Disabled flag to turn on Group-based filtered sync
        /// </summary>
        [Output("filteredSync")]
        public Output<string?> FilteredSync { get; private set; } = null!;

        /// <summary>
        /// List of Domain Health Alerts
        /// </summary>
        [Output("healthAlerts")]
        public Output<ImmutableArray<Outputs.HealthAlertResponse>> HealthAlerts { get; private set; } = null!;

        /// <summary>
        /// Last domain evaluation run DateTime
        /// </summary>
        [Output("healthLastEvaluated")]
        public Output<string> HealthLastEvaluated { get; private set; } = null!;

        /// <summary>
        /// List of Domain Health Monitors
        /// </summary>
        [Output("healthMonitors")]
        public Output<ImmutableArray<Outputs.HealthMonitorResponse>> HealthMonitors { get; private set; } = null!;

        /// <summary>
        /// Secure LDAP Settings
        /// </summary>
        [Output("ldapsSettings")]
        public Output<Outputs.LdapsSettingsResponse?> LdapsSettings { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Migration Properties
        /// </summary>
        [Output("migrationProperties")]
        public Output<Outputs.MigrationPropertiesResponse> MigrationProperties { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Notification Settings
        /// </summary>
        [Output("notificationSettings")]
        public Output<Outputs.NotificationSettingsResponse?> NotificationSettings { get; private set; } = null!;

        /// <summary>
        /// the current deployment or provisioning state, which only appears in the response.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource Forest Settings
        /// </summary>
        [Output("resourceForestSettings")]
        public Output<Outputs.ResourceForestSettingsResponse?> ResourceForestSettings { get; private set; } = null!;

        /// <summary>
        /// Status of Domain Service instance
        /// </summary>
        [Output("serviceStatus")]
        public Output<string> ServiceStatus { get; private set; } = null!;

        /// <summary>
        /// Sku Type
        /// </summary>
        [Output("sku")]
        public Output<string?> Sku { get; private set; } = null!;

        /// <summary>
        /// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
        /// </summary>
        [Output("subnetId")]
        public Output<string?> SubnetId { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Azure Active Directory Tenant Id
        /// </summary>
        [Output("tenantId")]
        public Output<string> TenantId { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Data Model Version
        /// </summary>
        [Output("version")]
        public Output<int> Version { get; private set; } = null!;

        /// <summary>
        /// Virtual network site id
        /// </summary>
        [Output("vnetSiteId")]
        public Output<string> VnetSiteId { get; private set; } = null!;


        /// <summary>
        /// Create a DomainService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DomainService(string name, DomainServiceArgs args, CustomResourceOptions? options = null)
            : base("azure-native:aad/v20170601:DomainService", name, args ?? new DomainServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DomainService(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:aad/v20170601:DomainService", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:aad:DomainService"},
                    new Pulumi.Alias { Type = "azure-native:aad/v20170101:DomainService"},
                    new Pulumi.Alias { Type = "azure-native:aad/v20200101:DomainService"},
                    new Pulumi.Alias { Type = "azure-native:aad/v20210301:DomainService"},
                    new Pulumi.Alias { Type = "azure-native:aad/v20210501:DomainService"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DomainService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DomainService Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DomainService(name, id, options);
        }
    }

    public sealed class DomainServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Domain Configuration Type
        /// </summary>
        [Input("domainConfigurationType")]
        public Input<string>? DomainConfigurationType { get; set; }

        /// <summary>
        /// The name of the Azure domain that the user would like to deploy Domain Services to.
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        /// <summary>
        /// DomainSecurity Settings
        /// </summary>
        [Input("domainSecuritySettings")]
        public Input<Inputs.DomainSecuritySettingsArgs>? DomainSecuritySettings { get; set; }

        /// <summary>
        /// The name of the domain service.
        /// </summary>
        [Input("domainServiceName")]
        public Input<string>? DomainServiceName { get; set; }

        /// <summary>
        /// Enabled or Disabled flag to turn on Group-based filtered sync
        /// </summary>
        [Input("filteredSync")]
        public InputUnion<string, Pulumi.AzureNative.Aad.V20170601.FilteredSync>? FilteredSync { get; set; }

        /// <summary>
        /// Secure LDAP Settings
        /// </summary>
        [Input("ldapsSettings")]
        public Input<Inputs.LdapsSettingsArgs>? LdapsSettings { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Notification Settings
        /// </summary>
        [Input("notificationSettings")]
        public Input<Inputs.NotificationSettingsArgs>? NotificationSettings { get; set; }

        /// <summary>
        /// Resource Forest Settings
        /// </summary>
        [Input("resourceForestSettings")]
        public Input<Inputs.ResourceForestSettingsArgs>? ResourceForestSettings { get; set; }

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Sku Type
        /// </summary>
        [Input("sku")]
        public Input<string>? Sku { get; set; }

        /// <summary>
        /// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public DomainServiceArgs()
        {
        }
    }
}
