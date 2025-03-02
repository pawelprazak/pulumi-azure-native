// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB.V20150408
{
    /// <summary>
    /// An Azure Cosmos DB SQL database.
    /// </summary>
    [Obsolete(@"Version 2015-04-08 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:documentdb/v20150408:DatabaseAccountSqlDatabase")]
    public partial class DatabaseAccountSqlDatabase : Pulumi.CustomResource
    {
        /// <summary>
        /// A system generated property that specified the addressable path of the collections resource.
        /// </summary>
        [Output("colls")]
        public Output<string?> Colls { get; private set; } = null!;

        /// <summary>
        /// A system generated property representing the resource etag required for optimistic concurrency control.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// The location of the resource group to which the resource belongs.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the database account.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A system generated property. A unique identifier.
        /// </summary>
        [Output("rid")]
        public Output<string?> Rid { get; private set; } = null!;

        /// <summary>
        /// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// A system generated property that denotes the last updated timestamp of the resource.
        /// </summary>
        [Output("ts")]
        public Output<object?> Ts { get; private set; } = null!;

        /// <summary>
        /// The type of Azure resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// A system generated property that specifies the addressable path of the users resource.
        /// </summary>
        [Output("users")]
        public Output<string?> Users { get; private set; } = null!;


        /// <summary>
        /// Create a DatabaseAccountSqlDatabase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DatabaseAccountSqlDatabase(string name, DatabaseAccountSqlDatabaseArgs args, CustomResourceOptions? options = null)
            : base("azure-native:documentdb/v20150408:DatabaseAccountSqlDatabase", name, args ?? new DatabaseAccountSqlDatabaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DatabaseAccountSqlDatabase(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:documentdb/v20150408:DatabaseAccountSqlDatabase", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:documentdb:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20150401:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20151106:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20160319:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20160331:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20190801:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20191212:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20200301:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20200401:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20200601preview:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20200901:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210115:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210301preview:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210315:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210401preview:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210415:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210515:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210615:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210701preview:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20211015:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20211015preview:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20211115preview:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20220215preview:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20220515:DatabaseAccountSqlDatabase"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20220515preview:DatabaseAccountSqlDatabase"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DatabaseAccountSqlDatabase resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DatabaseAccountSqlDatabase Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DatabaseAccountSqlDatabase(name, id, options);
        }
    }

    public sealed class DatabaseAccountSqlDatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cosmos DB database account name.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// Cosmos DB database name.
        /// </summary>
        [Input("databaseName")]
        public Input<string>? DatabaseName { get; set; }

        [Input("options", required: true)]
        private InputMap<string>? _options;

        /// <summary>
        /// A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request.
        /// </summary>
        public InputMap<string> Options
        {
            get => _options ?? (_options = new InputMap<string>());
            set => _options = value;
        }

        /// <summary>
        /// The standard JSON format of a SQL database
        /// </summary>
        [Input("resource", required: true)]
        public Input<Inputs.SqlDatabaseResourceArgs> Resource { get; set; } = null!;

        /// <summary>
        /// Name of an Azure resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public DatabaseAccountSqlDatabaseArgs()
        {
        }
    }
}
