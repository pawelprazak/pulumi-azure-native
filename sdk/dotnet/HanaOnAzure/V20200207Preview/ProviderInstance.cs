// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HanaOnAzure.V20200207Preview
{
    /// <summary>
    /// A provider instance associated with a SAP monitor.
    /// </summary>
    [AzureNativeResourceType("azure-native:hanaonazure/v20200207preview:ProviderInstance")]
    public partial class ProviderInstance : Pulumi.CustomResource
    {
        /// <summary>
        /// A JSON string containing metadata of the provider instance.
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A JSON string containing the properties of the provider instance.
        /// </summary>
        [Output("properties")]
        public Output<string> Properties { get; private set; } = null!;

        /// <summary>
        /// State of provisioning of the provider instance
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ProviderInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ProviderInstance(string name, ProviderInstanceArgs args, CustomResourceOptions? options = null)
            : base("azure-native:hanaonazure/v20200207preview:ProviderInstance", name, args ?? new ProviderInstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ProviderInstance(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:hanaonazure/v20200207preview:ProviderInstance", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:hanaonazure:ProviderInstance"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ProviderInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ProviderInstance Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ProviderInstance(name, id, options);
        }
    }

    public sealed class ProviderInstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A JSON string containing metadata of the provider instance.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        /// <summary>
        /// A JSON string containing the properties of the provider instance.
        /// </summary>
        [Input("properties")]
        public Input<string>? Properties { get; set; }

        /// <summary>
        /// Name of the provider instance.
        /// </summary>
        [Input("providerInstanceName")]
        public Input<string>? ProviderInstanceName { get; set; }

        /// <summary>
        /// Name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the SAP monitor resource.
        /// </summary>
        [Input("sapMonitorName", required: true)]
        public Input<string> SapMonitorName { get; set; } = null!;

        /// <summary>
        /// The type of provider instance.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ProviderInstanceArgs()
        {
        }
    }
}
