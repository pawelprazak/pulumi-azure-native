// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Storage.V20181101
{
    /// <summary>
    /// The properties of a storage account’s Blob service.
    /// </summary>
    [Obsolete(@"Version 2018-11-01 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:storage/v20181101:BlobServiceProperties")]
    public partial class BlobServiceProperties : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service.
        /// </summary>
        [Output("cors")]
        public Output<Outputs.CorsRulesResponse?> Cors { get; private set; } = null!;

        /// <summary>
        /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
        /// </summary>
        [Output("defaultServiceVersion")]
        public Output<string?> DefaultServiceVersion { get; private set; } = null!;

        /// <summary>
        /// The blob service properties for soft delete.
        /// </summary>
        [Output("deleteRetentionPolicy")]
        public Output<Outputs.DeleteRetentionPolicyResponse?> DeleteRetentionPolicy { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a BlobServiceProperties resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BlobServiceProperties(string name, BlobServicePropertiesArgs args, CustomResourceOptions? options = null)
            : base("azure-native:storage/v20181101:BlobServiceProperties", name, args ?? new BlobServicePropertiesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BlobServiceProperties(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:storage/v20181101:BlobServiceProperties", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:storage:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20180701:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20190401:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20190601:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20200801preview:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210101:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210201:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210401:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210601:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210801:BlobServiceProperties"},
                    new Pulumi.Alias { Type = "azure-native:storage/v20210901:BlobServiceProperties"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing BlobServiceProperties resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BlobServiceProperties Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new BlobServiceProperties(name, id, options);
        }
    }

    public sealed class BlobServicePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the blob Service within the specified storage account. Blob Service Name must be 'default'
        /// </summary>
        [Input("blobServicesName")]
        public Input<string>? BlobServicesName { get; set; }

        /// <summary>
        /// Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service.
        /// </summary>
        [Input("cors")]
        public Input<Inputs.CorsRulesArgs>? Cors { get; set; }

        /// <summary>
        /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
        /// </summary>
        [Input("defaultServiceVersion")]
        public Input<string>? DefaultServiceVersion { get; set; }

        /// <summary>
        /// The blob service properties for soft delete.
        /// </summary>
        [Input("deleteRetentionPolicy")]
        public Input<Inputs.DeleteRetentionPolicyArgs>? DeleteRetentionPolicy { get; set; }

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public BlobServicePropertiesArgs()
        {
        }
    }
}
