// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20160330
{
    /// <summary>
    /// Container service.
    /// </summary>
    [Obsolete(@"Version 2016-03-30 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:containerservice/v20160330:ContainerService")]
    public partial class ContainerService : Pulumi.CustomResource
    {
        /// <summary>
        /// Properties of the agent pool.
        /// </summary>
        [Output("agentPoolProfiles")]
        public Output<ImmutableArray<Outputs.ContainerServiceAgentPoolProfileResponse>> AgentPoolProfiles { get; private set; } = null!;

        /// <summary>
        /// Properties of the diagnostic agent.
        /// </summary>
        [Output("diagnosticsProfile")]
        public Output<Outputs.ContainerServiceDiagnosticsProfileResponse?> DiagnosticsProfile { get; private set; } = null!;

        /// <summary>
        /// Properties of Linux VMs.
        /// </summary>
        [Output("linuxProfile")]
        public Output<Outputs.ContainerServiceLinuxProfileResponse> LinuxProfile { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Properties of master agents.
        /// </summary>
        [Output("masterProfile")]
        public Output<Outputs.ContainerServiceMasterProfileResponse> MasterProfile { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Properties of the orchestrator.
        /// </summary>
        [Output("orchestratorProfile")]
        public Output<Outputs.ContainerServiceOrchestratorProfileResponse?> OrchestratorProfile { get; private set; } = null!;

        /// <summary>
        /// the current deployment or provisioning state, which only appears in the response.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Properties of Windows VMs.
        /// </summary>
        [Output("windowsProfile")]
        public Output<Outputs.ContainerServiceWindowsProfileResponse?> WindowsProfile { get; private set; } = null!;


        /// <summary>
        /// Create a ContainerService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContainerService(string name, ContainerServiceArgs args, CustomResourceOptions? options = null)
            : base("azure-native:containerservice/v20160330:ContainerService", name, args ?? new ContainerServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContainerService(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:containerservice/v20160330:ContainerService", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:containerservice/v20151101preview:ContainerService"},
                    new Pulumi.Alias { Type = "azure-native:containerservice/v20160930:ContainerService"},
                    new Pulumi.Alias { Type = "azure-native:containerservice/v20170131:ContainerService"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ContainerService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContainerService Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ContainerService(name, id, options);
        }
    }

    public sealed class ContainerServiceArgs : Pulumi.ResourceArgs
    {
        [Input("agentPoolProfiles", required: true)]
        private InputList<Inputs.ContainerServiceAgentPoolProfileArgs>? _agentPoolProfiles;

        /// <summary>
        /// Properties of the agent pool.
        /// </summary>
        public InputList<Inputs.ContainerServiceAgentPoolProfileArgs> AgentPoolProfiles
        {
            get => _agentPoolProfiles ?? (_agentPoolProfiles = new InputList<Inputs.ContainerServiceAgentPoolProfileArgs>());
            set => _agentPoolProfiles = value;
        }

        /// <summary>
        /// The name of the container service in the specified subscription and resource group.
        /// </summary>
        [Input("containerServiceName")]
        public Input<string>? ContainerServiceName { get; set; }

        /// <summary>
        /// Properties of the diagnostic agent.
        /// </summary>
        [Input("diagnosticsProfile")]
        public Input<Inputs.ContainerServiceDiagnosticsProfileArgs>? DiagnosticsProfile { get; set; }

        /// <summary>
        /// Properties of Linux VMs.
        /// </summary>
        [Input("linuxProfile", required: true)]
        public Input<Inputs.ContainerServiceLinuxProfileArgs> LinuxProfile { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Properties of master agents.
        /// </summary>
        [Input("masterProfile", required: true)]
        public Input<Inputs.ContainerServiceMasterProfileArgs> MasterProfile { get; set; } = null!;

        /// <summary>
        /// Properties of the orchestrator.
        /// </summary>
        [Input("orchestratorProfile")]
        public Input<Inputs.ContainerServiceOrchestratorProfileArgs>? OrchestratorProfile { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

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

        /// <summary>
        /// Properties of Windows VMs.
        /// </summary>
        [Input("windowsProfile")]
        public Input<Inputs.ContainerServiceWindowsProfileArgs>? WindowsProfile { get; set; }

        public ContainerServiceArgs()
        {
        }
    }
}
