// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Batch.V20181201
{
    /// <summary>
    /// Contains information about a pool.
    /// </summary>
    [Obsolete(@"Version 2018-12-01 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:batch/v20181201:Pool")]
    public partial class Pool : Pulumi.CustomResource
    {
        [Output("allocationState")]
        public Output<string> AllocationState { get; private set; } = null!;

        [Output("allocationStateTransitionTime")]
        public Output<string> AllocationStateTransitionTime { get; private set; } = null!;

        /// <summary>
        /// The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
        /// </summary>
        [Output("applicationLicenses")]
        public Output<ImmutableArray<string>> ApplicationLicenses { get; private set; } = null!;

        /// <summary>
        /// Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
        /// </summary>
        [Output("applicationPackages")]
        public Output<ImmutableArray<Outputs.ApplicationPackageReferenceResponse>> ApplicationPackages { get; private set; } = null!;

        /// <summary>
        /// This property is set only if the pool automatically scales, i.e. autoScaleSettings are used.
        /// </summary>
        [Output("autoScaleRun")]
        public Output<Outputs.AutoScaleRunResponse> AutoScaleRun { get; private set; } = null!;

        /// <summary>
        /// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
        /// </summary>
        [Output("certificates")]
        public Output<ImmutableArray<Outputs.CertificateReferenceResponse>> Certificates { get; private set; } = null!;

        [Output("creationTime")]
        public Output<string> CreationTime { get; private set; } = null!;

        [Output("currentDedicatedNodes")]
        public Output<int> CurrentDedicatedNodes { get; private set; } = null!;

        [Output("currentLowPriorityNodes")]
        public Output<int> CurrentLowPriorityNodes { get; private set; } = null!;

        /// <summary>
        /// Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
        /// </summary>
        [Output("deploymentConfiguration")]
        public Output<Outputs.DeploymentConfigurationResponse?> DeploymentConfiguration { get; private set; } = null!;

        /// <summary>
        /// The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The ETag of the resource, used for concurrency statements.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
        /// </summary>
        [Output("interNodeCommunication")]
        public Output<string?> InterNodeCommunication { get; private set; } = null!;

        /// <summary>
        /// This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state.
        /// </summary>
        [Output("lastModified")]
        public Output<string> LastModified { get; private set; } = null!;

        [Output("maxTasksPerNode")]
        public Output<int?> MaxTasksPerNode { get; private set; } = null!;

        /// <summary>
        /// The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableArray<Outputs.MetadataItemResponse>> Metadata { get; private set; } = null!;

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The network configuration for a pool.
        /// </summary>
        [Output("networkConfiguration")]
        public Output<Outputs.NetworkConfigurationResponse?> NetworkConfiguration { get; private set; } = null!;

        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        [Output("provisioningStateTransitionTime")]
        public Output<string> ProvisioningStateTransitionTime { get; private set; } = null!;

        /// <summary>
        /// Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady).
        /// </summary>
        [Output("resizeOperationStatus")]
        public Output<Outputs.ResizeOperationStatusResponse> ResizeOperationStatus { get; private set; } = null!;

        /// <summary>
        /// Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
        /// </summary>
        [Output("scaleSettings")]
        public Output<Outputs.ScaleSettingsResponse?> ScaleSettings { get; private set; } = null!;

        /// <summary>
        /// In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
        /// </summary>
        [Output("startTask")]
        public Output<Outputs.StartTaskResponse?> StartTask { get; private set; } = null!;

        [Output("taskSchedulingPolicy")]
        public Output<Outputs.TaskSchedulingPolicyResponse?> TaskSchedulingPolicy { get; private set; } = null!;

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        [Output("userAccounts")]
        public Output<ImmutableArray<Outputs.UserAccountResponse>> UserAccounts { get; private set; } = null!;

        /// <summary>
        /// For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
        /// </summary>
        [Output("vmSize")]
        public Output<string?> VmSize { get; private set; } = null!;


        /// <summary>
        /// Create a Pool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Pool(string name, PoolArgs args, CustomResourceOptions? options = null)
            : base("azure-native:batch/v20181201:Pool", name, args ?? new PoolArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Pool(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:batch/v20181201:Pool", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:batch:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20170901:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20190401:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20190801:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20200301:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20200501:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20200901:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20210101:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20210601:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20220101:Pool"},
                    new Pulumi.Alias { Type = "azure-native:batch/v20220601:Pool"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Pool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Pool Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Pool(name, id, options);
        }
    }

    public sealed class PoolArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Batch account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("applicationLicenses")]
        private InputList<string>? _applicationLicenses;

        /// <summary>
        /// The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
        /// </summary>
        public InputList<string> ApplicationLicenses
        {
            get => _applicationLicenses ?? (_applicationLicenses = new InputList<string>());
            set => _applicationLicenses = value;
        }

        [Input("applicationPackages")]
        private InputList<Inputs.ApplicationPackageReferenceArgs>? _applicationPackages;

        /// <summary>
        /// Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
        /// </summary>
        public InputList<Inputs.ApplicationPackageReferenceArgs> ApplicationPackages
        {
            get => _applicationPackages ?? (_applicationPackages = new InputList<Inputs.ApplicationPackageReferenceArgs>());
            set => _applicationPackages = value;
        }

        [Input("certificates")]
        private InputList<Inputs.CertificateReferenceArgs>? _certificates;

        /// <summary>
        /// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
        /// </summary>
        public InputList<Inputs.CertificateReferenceArgs> Certificates
        {
            get => _certificates ?? (_certificates = new InputList<Inputs.CertificateReferenceArgs>());
            set => _certificates = value;
        }

        /// <summary>
        /// Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
        /// </summary>
        [Input("deploymentConfiguration")]
        public Input<Inputs.DeploymentConfigurationArgs>? DeploymentConfiguration { get; set; }

        /// <summary>
        /// The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
        /// </summary>
        [Input("interNodeCommunication")]
        public Input<Pulumi.AzureNative.Batch.V20181201.InterNodeCommunicationState>? InterNodeCommunication { get; set; }

        [Input("maxTasksPerNode")]
        public Input<int>? MaxTasksPerNode { get; set; }

        [Input("metadata")]
        private InputList<Inputs.MetadataItemArgs>? _metadata;

        /// <summary>
        /// The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
        /// </summary>
        public InputList<Inputs.MetadataItemArgs> Metadata
        {
            get => _metadata ?? (_metadata = new InputList<Inputs.MetadataItemArgs>());
            set => _metadata = value;
        }

        /// <summary>
        /// The network configuration for a pool.
        /// </summary>
        [Input("networkConfiguration")]
        public Input<Inputs.NetworkConfigurationArgs>? NetworkConfiguration { get; set; }

        /// <summary>
        /// The pool name. This must be unique within the account.
        /// </summary>
        [Input("poolName")]
        public Input<string>? PoolName { get; set; }

        /// <summary>
        /// The name of the resource group that contains the Batch account.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
        /// </summary>
        [Input("scaleSettings")]
        public Input<Inputs.ScaleSettingsArgs>? ScaleSettings { get; set; }

        /// <summary>
        /// In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
        /// </summary>
        [Input("startTask")]
        public Input<Inputs.StartTaskArgs>? StartTask { get; set; }

        [Input("taskSchedulingPolicy")]
        public Input<Inputs.TaskSchedulingPolicyArgs>? TaskSchedulingPolicy { get; set; }

        [Input("userAccounts")]
        private InputList<Inputs.UserAccountArgs>? _userAccounts;
        public InputList<Inputs.UserAccountArgs> UserAccounts
        {
            get => _userAccounts ?? (_userAccounts = new InputList<Inputs.UserAccountArgs>());
            set => _userAccounts = value;
        }

        /// <summary>
        /// For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
        /// </summary>
        [Input("vmSize")]
        public Input<string>? VmSize { get; set; }

        public PoolArgs()
        {
        }
    }
}
