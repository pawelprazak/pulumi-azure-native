// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AVS.V20200717Preview
{
    public static class ListPrivateCloudAdminCredentials
    {
        /// <summary>
        /// Administrative credentials for accessing vCenter and NSX-T
        /// </summary>
        public static Task<ListPrivateCloudAdminCredentialsResult> InvokeAsync(ListPrivateCloudAdminCredentialsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListPrivateCloudAdminCredentialsResult>("azure-native:avs/v20200717preview:listPrivateCloudAdminCredentials", args ?? new ListPrivateCloudAdminCredentialsArgs(), options.WithDefaults());

        /// <summary>
        /// Administrative credentials for accessing vCenter and NSX-T
        /// </summary>
        public static Output<ListPrivateCloudAdminCredentialsResult> Invoke(ListPrivateCloudAdminCredentialsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListPrivateCloudAdminCredentialsResult>("azure-native:avs/v20200717preview:listPrivateCloudAdminCredentials", args ?? new ListPrivateCloudAdminCredentialsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListPrivateCloudAdminCredentialsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the private cloud
        /// </summary>
        [Input("privateCloudName", required: true)]
        public string PrivateCloudName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListPrivateCloudAdminCredentialsArgs()
        {
        }
    }

    public sealed class ListPrivateCloudAdminCredentialsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the private cloud
        /// </summary>
        [Input("privateCloudName", required: true)]
        public Input<string> PrivateCloudName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListPrivateCloudAdminCredentialsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListPrivateCloudAdminCredentialsResult
    {
        /// <summary>
        /// NSX-T Manager password
        /// </summary>
        public readonly string NsxtPassword;
        /// <summary>
        /// NSX-T Manager username
        /// </summary>
        public readonly string NsxtUsername;
        /// <summary>
        /// vCenter admin password
        /// </summary>
        public readonly string VcenterPassword;
        /// <summary>
        /// vCenter admin username
        /// </summary>
        public readonly string VcenterUsername;

        [OutputConstructor]
        private ListPrivateCloudAdminCredentialsResult(
            string nsxtPassword,

            string nsxtUsername,

            string vcenterPassword,

            string vcenterUsername)
        {
            NsxtPassword = nsxtPassword;
            NsxtUsername = nsxtUsername;
            VcenterPassword = vcenterPassword;
            VcenterUsername = vcenterUsername;
        }
    }
}
