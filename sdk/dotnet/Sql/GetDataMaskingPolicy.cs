// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Sql
{
    public static class GetDataMaskingPolicy
    {
        /// <summary>
        /// Represents a database data masking policy.
        /// API Version: 2014-04-01.
        /// </summary>
        public static Task<GetDataMaskingPolicyResult> InvokeAsync(GetDataMaskingPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDataMaskingPolicyResult>("azure-native:sql:getDataMaskingPolicy", args ?? new GetDataMaskingPolicyArgs(), options.WithDefaults());

        /// <summary>
        /// Represents a database data masking policy.
        /// API Version: 2014-04-01.
        /// </summary>
        public static Output<GetDataMaskingPolicyResult> Invoke(GetDataMaskingPolicyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDataMaskingPolicyResult>("azure-native:sql:getDataMaskingPolicy", args ?? new GetDataMaskingPolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDataMaskingPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the database for which the data masking rule applies.
        /// </summary>
        [Input("dataMaskingPolicyName", required: true)]
        public string DataMaskingPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("databaseName", required: true)]
        public string DatabaseName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public string ServerName { get; set; } = null!;

        public GetDataMaskingPolicyArgs()
        {
        }
    }

    public sealed class GetDataMaskingPolicyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the database for which the data masking rule applies.
        /// </summary>
        [Input("dataMaskingPolicyName", required: true)]
        public Input<string> DataMaskingPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("databaseName", required: true)]
        public Input<string> DatabaseName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        public GetDataMaskingPolicyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDataMaskingPolicyResult
    {
        /// <summary>
        /// The list of the application principals. This is a legacy parameter and is no longer used.
        /// </summary>
        public readonly string ApplicationPrincipals;
        /// <summary>
        /// The state of the data masking policy.
        /// </summary>
        public readonly string DataMaskingState;
        /// <summary>
        /// The list of the exempt principals. Specifies the semicolon-separated list of database users for which the data masking policy does not apply. The specified users receive data results without masking for all of the database queries.
        /// </summary>
        public readonly string? ExemptPrincipals;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The kind of data masking policy. Metadata, used for Azure portal.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The location of the data masking policy.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The masking level. This is a legacy parameter and is no longer used.
        /// </summary>
        public readonly string MaskingLevel;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDataMaskingPolicyResult(
            string applicationPrincipals,

            string dataMaskingState,

            string? exemptPrincipals,

            string id,

            string kind,

            string location,

            string maskingLevel,

            string name,

            string type)
        {
            ApplicationPrincipals = applicationPrincipals;
            DataMaskingState = dataMaskingState;
            ExemptPrincipals = exemptPrincipals;
            Id = id;
            Kind = kind;
            Location = location;
            MaskingLevel = maskingLevel;
            Name = name;
            Type = type;
        }
    }
}
