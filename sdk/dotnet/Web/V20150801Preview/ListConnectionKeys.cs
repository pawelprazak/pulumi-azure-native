// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20150801Preview
{
    public static class ListConnectionKeys
    {
        public static Task<ListConnectionKeysResult> InvokeAsync(ListConnectionKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListConnectionKeysResult>("azure-native:web/v20150801preview:listConnectionKeys", args ?? new ListConnectionKeysArgs(), options.WithDefaults());

        public static Output<ListConnectionKeysResult> Invoke(ListConnectionKeysInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListConnectionKeysResult>("azure-native:web/v20150801preview:listConnectionKeys", args ?? new ListConnectionKeysInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListConnectionKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The connection name.
        /// </summary>
        [Input("connectionName", required: true)]
        public string ConnectionName { get; set; } = null!;

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        /// <summary>
        /// Resource type
        /// </summary>
        [Input("type")]
        public string? Type { get; set; }

        /// <summary>
        /// time span for how long the keys will be valid
        /// </summary>
        [Input("validityTimeSpan")]
        public string? ValidityTimeSpan { get; set; }

        public ListConnectionKeysArgs()
        {
        }
    }

    public sealed class ListConnectionKeysInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The connection name.
        /// </summary>
        [Input("connectionName", required: true)]
        public Input<string> ConnectionName { get; set; } = null!;

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The resource group name.
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
        /// Resource type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// time span for how long the keys will be valid
        /// </summary>
        [Input("validityTimeSpan")]
        public Input<string>? ValidityTimeSpan { get; set; }

        public ListConnectionKeysInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListConnectionKeysResult
    {
        /// <summary>
        /// Connection Key
        /// </summary>
        public readonly string? ConnectionKey;
        /// <summary>
        /// Tokens/Claim
        /// </summary>
        public readonly ImmutableDictionary<string, object>? ParameterValues;

        [OutputConstructor]
        private ListConnectionKeysResult(
            string? connectionKey,

            ImmutableDictionary<string, object>? parameterValues)
        {
            ConnectionKey = connectionKey;
            ParameterValues = parameterValues;
        }
    }
}
