// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Storage.V20180201
{
    /// <summary>
    /// Properties of the blob container, including Id, resource name, resource type, Etag.
    /// </summary>
    [Obsolete(@"Version 2018-02-01 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:storage/v20180201:BlobContainer")]
    public partial class BlobContainer : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource Etag.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
        /// </summary>
        [Output("hasImmutabilityPolicy")]
        public Output<bool> HasImmutabilityPolicy { get; private set; } = null!;

        /// <summary>
        /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
        /// </summary>
        [Output("hasLegalHold")]
        public Output<bool> HasLegalHold { get; private set; } = null!;

        /// <summary>
        /// The ImmutabilityPolicy property of the container.
        /// </summary>
        [Output("immutabilityPolicy")]
        public Output<Outputs.ImmutabilityPolicyPropertiesResponse> ImmutabilityPolicy { get; private set; } = null!;

        /// <summary>
        /// Returns the date and time the container was last modified.
        /// </summary>
        [Output("lastModifiedTime")]
        public Output<string> LastModifiedTime { get; private set; } = null!;

        /// <summary>
        /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
        /// </summary>
        [Output("leaseDuration")]
        public Output<string> LeaseDuration { get; private set; } = null!;

        /// <summary>
        /// Lease state of the container.
        /// </summary>
        [Output("leaseState")]
        public Output<string> LeaseState { get; private set; } = null!;

        /// <summary>
        /// The lease status of the container.
        /// </summary>
        [Output("leaseStatus")]
        public Output<string> LeaseStatus { get; private set; } = null!;

        /// <summary>
        /// The LegalHold property of the container.
        /// </summary>
        [Output("legalHold")]
        public Output<Outputs.LegalHoldPropertiesResponse> LegalHold { get; private set; } = null!;

        /// <summary>
        /// A name-value pair to associate with the container as metadata.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies whether data in the container may be accessed publicly and the level of access.
        /// </summary>
        [Output("publicAccess")]
        public Output<string?> PublicAccess { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a BlobContainer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BlobContainer(string name, BlobContainerArgs args, CustomResourceOptions? options = null)
            : base("azure-native:storage/v20180201:BlobContainer", name, args ?? new BlobContainerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BlobContainer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:storage/v20180201:BlobContainer", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:storage:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20180301preview:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20180701:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20181101:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20190401:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20190601:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20200801preview:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210101:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210201:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210401:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210601:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210801:BlobContainer"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210901:BlobContainer"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing BlobContainer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BlobContainer Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new BlobContainer(name, id, options);
        }
    }

    public sealed class BlobContainerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
        /// </summary>
        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// A name-value pair to associate with the container as metadata.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        /// <summary>
        /// Specifies whether data in the container may be accessed publicly and the level of access.
        /// </summary>
        [Input("publicAccess")]
        public Input<Pulumi.AzureNative.Storage.V20180201.PublicAccess>? PublicAccess { get; set; }

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public BlobContainerArgs()
        {
        }
    }
}
