// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Sql
{
    public static class GetServerAzureADOnlyAuthentication
    {
        /// <summary>
        /// Azure Active Directory only authentication.
        /// API Version: 2020-11-01-preview.
        /// </summary>
        public static Task<GetServerAzureADOnlyAuthenticationResult> InvokeAsync(GetServerAzureADOnlyAuthenticationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServerAzureADOnlyAuthenticationResult>("azure-native:sql:getServerAzureADOnlyAuthentication", args ?? new GetServerAzureADOnlyAuthenticationArgs(), options.WithDefaults());

        /// <summary>
        /// Azure Active Directory only authentication.
        /// API Version: 2020-11-01-preview.
        /// </summary>
        public static Output<GetServerAzureADOnlyAuthenticationResult> Invoke(GetServerAzureADOnlyAuthenticationInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetServerAzureADOnlyAuthenticationResult>("azure-native:sql:getServerAzureADOnlyAuthentication", args ?? new GetServerAzureADOnlyAuthenticationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServerAzureADOnlyAuthenticationArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of server azure active directory only authentication.
        /// </summary>
        [Input("authenticationName", required: true)]
        public string AuthenticationName { get; set; } = null!;

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

        public GetServerAzureADOnlyAuthenticationArgs()
        {
        }
    }

    public sealed class GetServerAzureADOnlyAuthenticationInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of server azure active directory only authentication.
        /// </summary>
        [Input("authenticationName", required: true)]
        public Input<string> AuthenticationName { get; set; } = null!;

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

        public GetServerAzureADOnlyAuthenticationInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServerAzureADOnlyAuthenticationResult
    {
        /// <summary>
        /// Azure Active Directory only Authentication enabled.
        /// </summary>
        public readonly bool AzureADOnlyAuthentication;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetServerAzureADOnlyAuthenticationResult(
            bool azureADOnlyAuthentication,

            string id,

            string name,

            string type)
        {
            AzureADOnlyAuthentication = azureADOnlyAuthentication;
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
