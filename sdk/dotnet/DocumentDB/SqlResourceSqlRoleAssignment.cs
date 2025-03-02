// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB
{
    /// <summary>
    /// An Azure Cosmos DB Role Assignment
    /// API Version: 2021-03-01-preview.
    /// </summary>
    [AzureNativeResourceType("azure-native:documentdb:SqlResourceSqlRoleAssignment")]
    public partial class SqlResourceSqlRoleAssignment : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The unique identifier for the associated AAD principal in the AAD graph to which access is being granted through this Role Assignment. Tenant ID for the principal is inferred using the tenant associated with the subscription.
        /// </summary>
        [Output("principalId")]
        public Output<string?> PrincipalId { get; private set; } = null!;

        /// <summary>
        /// The unique identifier for the associated Role Definition.
        /// </summary>
        [Output("roleDefinitionId")]
        public Output<string?> RoleDefinitionId { get; private set; } = null!;

        /// <summary>
        /// The data plane resource path for which access is being granted through this Role Assignment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// The type of Azure resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SqlResourceSqlRoleAssignment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SqlResourceSqlRoleAssignment(string name, SqlResourceSqlRoleAssignmentArgs args, CustomResourceOptions? options = null)
            : base("azure-native:documentdb:SqlResourceSqlRoleAssignment", name, args ?? new SqlResourceSqlRoleAssignmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SqlResourceSqlRoleAssignment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:documentdb:SqlResourceSqlRoleAssignment", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20200601preview:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210301preview:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210401preview:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210415:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210515:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210615:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20210701preview:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20211015:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20211015preview:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20211115preview:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20220215preview:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20220515:SqlResourceSqlRoleAssignment"},
                    new Pulumi.Alias { Type = "azure-native:documentdb/v20220515preview:SqlResourceSqlRoleAssignment"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SqlResourceSqlRoleAssignment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SqlResourceSqlRoleAssignment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SqlResourceSqlRoleAssignment(name, id, options);
        }
    }

    public sealed class SqlResourceSqlRoleAssignmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cosmos DB database account name.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The unique identifier for the associated AAD principal in the AAD graph to which access is being granted through this Role Assignment. Tenant ID for the principal is inferred using the tenant associated with the subscription.
        /// </summary>
        [Input("principalId")]
        public Input<string>? PrincipalId { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The GUID for the Role Assignment.
        /// </summary>
        [Input("roleAssignmentId")]
        public Input<string>? RoleAssignmentId { get; set; }

        /// <summary>
        /// The unique identifier for the associated Role Definition.
        /// </summary>
        [Input("roleDefinitionId")]
        public Input<string>? RoleDefinitionId { get; set; }

        /// <summary>
        /// The data plane resource path for which access is being granted through this Role Assignment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public SqlResourceSqlRoleAssignmentArgs()
        {
        }
    }
}
