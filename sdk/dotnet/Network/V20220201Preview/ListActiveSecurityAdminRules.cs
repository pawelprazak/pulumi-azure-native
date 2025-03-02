// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20220201Preview
{
    public static class ListActiveSecurityAdminRules
    {
        /// <summary>
        /// Result of the request to list active security admin rules. It contains a list of active security admin rules and a skiptoken to get the next set of results.
        /// </summary>
        public static Task<ListActiveSecurityAdminRulesResult> InvokeAsync(ListActiveSecurityAdminRulesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListActiveSecurityAdminRulesResult>("azure-native:network/v20220201preview:listActiveSecurityAdminRules", args ?? new ListActiveSecurityAdminRulesArgs(), options.WithDefaults());

        /// <summary>
        /// Result of the request to list active security admin rules. It contains a list of active security admin rules and a skiptoken to get the next set of results.
        /// </summary>
        public static Output<ListActiveSecurityAdminRulesResult> Invoke(ListActiveSecurityAdminRulesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListActiveSecurityAdminRulesResult>("azure-native:network/v20220201preview:listActiveSecurityAdminRules", args ?? new ListActiveSecurityAdminRulesInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListActiveSecurityAdminRulesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the network manager.
        /// </summary>
        [Input("networkManagerName", required: true)]
        public string NetworkManagerName { get; set; } = null!;

        [Input("regions")]
        private List<string>? _regions;

        /// <summary>
        /// List of regions.
        /// </summary>
        public List<string> Regions
        {
            get => _regions ?? (_regions = new List<string>());
            set => _regions = value;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data.
        /// </summary>
        [Input("skipToken")]
        public string? SkipToken { get; set; }

        public ListActiveSecurityAdminRulesArgs()
        {
        }
    }

    public sealed class ListActiveSecurityAdminRulesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the network manager.
        /// </summary>
        [Input("networkManagerName", required: true)]
        public Input<string> NetworkManagerName { get; set; } = null!;

        [Input("regions")]
        private InputList<string>? _regions;

        /// <summary>
        /// List of regions.
        /// </summary>
        public InputList<string> Regions
        {
            get => _regions ?? (_regions = new InputList<string>());
            set => _regions = value;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data.
        /// </summary>
        [Input("skipToken")]
        public Input<string>? SkipToken { get; set; }

        public ListActiveSecurityAdminRulesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListActiveSecurityAdminRulesResult
    {
        /// <summary>
        /// When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data.
        /// </summary>
        public readonly string? SkipToken;
        /// <summary>
        /// Gets a page of active security admin rules.
        /// </summary>
        public readonly ImmutableArray<Union<Outputs.ActiveDefaultSecurityAdminRuleResponse, Outputs.ActiveSecurityAdminRuleResponse>> Value;

        [OutputConstructor]
        private ListActiveSecurityAdminRulesResult(
            string? skipToken,

            ImmutableArray<Union<Outputs.ActiveDefaultSecurityAdminRuleResponse, Outputs.ActiveSecurityAdminRuleResponse>> value)
        {
            SkipToken = skipToken;
            Value = value;
        }
    }
}
