// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20220101
{
    public static class ListActiveConnectivityConfigurations
    {
        /// <summary>
        /// Result of the request to list active connectivity configurations. It contains a list of active connectivity configurations and a skiptoken to get the next set of results.
        /// </summary>
        public static Task<ListActiveConnectivityConfigurationsResult> InvokeAsync(ListActiveConnectivityConfigurationsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListActiveConnectivityConfigurationsResult>("azure-native:network/v20220101:listActiveConnectivityConfigurations", args ?? new ListActiveConnectivityConfigurationsArgs(), options.WithDefaults());

        /// <summary>
        /// Result of the request to list active connectivity configurations. It contains a list of active connectivity configurations and a skiptoken to get the next set of results.
        /// </summary>
        public static Output<ListActiveConnectivityConfigurationsResult> Invoke(ListActiveConnectivityConfigurationsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListActiveConnectivityConfigurationsResult>("azure-native:network/v20220101:listActiveConnectivityConfigurations", args ?? new ListActiveConnectivityConfigurationsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListActiveConnectivityConfigurationsArgs : Pulumi.InvokeArgs
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

        public ListActiveConnectivityConfigurationsArgs()
        {
        }
    }

    public sealed class ListActiveConnectivityConfigurationsInvokeArgs : Pulumi.InvokeArgs
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

        public ListActiveConnectivityConfigurationsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListActiveConnectivityConfigurationsResult
    {
        /// <summary>
        /// When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data.
        /// </summary>
        public readonly string? SkipToken;
        /// <summary>
        /// Gets a page of active connectivity configurations.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActiveConnectivityConfigurationResponse> Value;

        [OutputConstructor]
        private ListActiveConnectivityConfigurationsResult(
            string? skipToken,

            ImmutableArray<Outputs.ActiveConnectivityConfigurationResponse> value)
        {
            SkipToken = skipToken;
            Value = value;
        }
    }
}
