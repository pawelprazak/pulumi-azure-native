// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ApiManagement.V20201201
{
    public static class ListNamedValue
    {
        /// <summary>
        /// Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.
        /// </summary>
        public static Task<ListNamedValueResult> InvokeAsync(ListNamedValueArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListNamedValueResult>("azure-native:apimanagement/v20201201:listNamedValue", args ?? new ListNamedValueArgs(), options.WithDefaults());

        /// <summary>
        /// Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.
        /// </summary>
        public static Output<ListNamedValueResult> Invoke(ListNamedValueInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListNamedValueResult>("azure-native:apimanagement/v20201201:listNamedValue", args ?? new ListNamedValueInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListNamedValueArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Identifier of the NamedValue.
        /// </summary>
        [Input("namedValueId", required: true)]
        public string NamedValueId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public ListNamedValueArgs()
        {
        }
    }

    public sealed class ListNamedValueInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Identifier of the NamedValue.
        /// </summary>
        [Input("namedValueId", required: true)]
        public Input<string> NamedValueId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ListNamedValueInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListNamedValueResult
    {
        /// <summary>
        /// This is secret value of the NamedValue entity.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private ListNamedValueResult(string? value)
        {
            Value = value;
        }
    }
}
