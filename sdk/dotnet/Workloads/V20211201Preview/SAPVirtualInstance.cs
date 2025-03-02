// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.V20211201Preview
{
    /// <summary>
    /// Define the Virtual Instance for SAP.
    /// </summary>
    [AzureNativeResourceType("azure-native:workloads/v20211201preview:SAPVirtualInstance")]
    public partial class SAPVirtualInstance : Pulumi.CustomResource
    {
        /// <summary>
        /// Defines if an existing SAP system is being registered or a new SAP system is being created
        /// </summary>
        [Output("configuration")]
        public Output<object> Configuration { get; private set; } = null!;

        /// <summary>
        /// Defines the environment type - Production/Non Production.
        /// </summary>
        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        /// <summary>
        /// Defines the Virtual Instance for SAP errors.
        /// </summary>
        [Output("errors")]
        public Output<Outputs.SAPVirtualInstanceErrorResponse> Errors { get; private set; } = null!;

        /// <summary>
        /// Defines the SAP Instance health.
        /// </summary>
        [Output("health")]
        public Output<string> Health { get; private set; } = null!;

        /// <summary>
        /// Managed service identity (user assigned identities)
        /// </summary>
        [Output("identity")]
        public Output<Outputs.UserAssignedServiceIdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Managed resource group configuration
        /// </summary>
        [Output("managedResourceGroupConfiguration")]
        public Output<Outputs.ManagedRGConfigurationResponse?> ManagedResourceGroupConfiguration { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Defines the provisioning states.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Defines the SAP Product type.
        /// </summary>
        [Output("sapProduct")]
        public Output<string> SapProduct { get; private set; } = null!;

        /// <summary>
        /// Defines the Virtual Instance for SAP state.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Defines the SAP Instance status.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SAPVirtualInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SAPVirtualInstance(string name, SAPVirtualInstanceArgs args, CustomResourceOptions? options = null)
            : base("azure-native:workloads/v20211201preview:SAPVirtualInstance", name, args ?? new SAPVirtualInstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SAPVirtualInstance(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:workloads/v20211201preview:SAPVirtualInstance", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:workloads:SAPVirtualInstance"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SAPVirtualInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SAPVirtualInstance Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SAPVirtualInstance(name, id, options);
        }
    }

    public sealed class SAPVirtualInstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines if an existing SAP system is being registered or a new SAP system is being created
        /// </summary>
        [Input("configuration", required: true)]
        public object Configuration { get; set; } = null!;

        /// <summary>
        /// Defines the environment type - Production/Non Production.
        /// </summary>
        [Input("environment", required: true)]
        public InputUnion<string, Pulumi.AzureNative.Workloads.V20211201Preview.SAPEnvironmentType> Environment { get; set; } = null!;

        /// <summary>
        /// Managed service identity (user assigned identities)
        /// </summary>
        [Input("identity")]
        public Input<Inputs.UserAssignedServiceIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Managed resource group configuration
        /// </summary>
        [Input("managedResourceGroupConfiguration")]
        public Input<Inputs.ManagedRGConfigurationArgs>? ManagedResourceGroupConfiguration { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Defines the SAP Product type.
        /// </summary>
        [Input("sapProduct", required: true)]
        public InputUnion<string, Pulumi.AzureNative.Workloads.V20211201Preview.SAPProductType> SapProduct { get; set; } = null!;

        /// <summary>
        /// The name of the Virtual Instances for SAP.
        /// </summary>
        [Input("sapVirtualInstanceName")]
        public Input<string>? SapVirtualInstanceName { get; set; }

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

        public SAPVirtualInstanceArgs()
        {
        }
    }
}
