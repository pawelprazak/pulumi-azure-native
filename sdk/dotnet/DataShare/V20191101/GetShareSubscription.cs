// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataShare.V20191101
{
    [Obsolete(@"Version 2019-11-01 will be removed in v2 of the provider.")]
    public static class GetShareSubscription
    {
        /// <summary>
        /// A share subscription data transfer object.
        /// </summary>
        public static Task<GetShareSubscriptionResult> InvokeAsync(GetShareSubscriptionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetShareSubscriptionResult>("azure-native:datashare/v20191101:getShareSubscription", args ?? new GetShareSubscriptionArgs(), options.WithDefaults());

        /// <summary>
        /// A share subscription data transfer object.
        /// </summary>
        public static Output<GetShareSubscriptionResult> Invoke(GetShareSubscriptionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetShareSubscriptionResult>("azure-native:datashare/v20191101:getShareSubscription", args ?? new GetShareSubscriptionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetShareSubscriptionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public string ShareSubscriptionName { get; set; } = null!;

        public GetShareSubscriptionArgs()
        {
        }
    }

    public sealed class GetShareSubscriptionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public Input<string> ShareSubscriptionName { get; set; } = null!;

        public GetShareSubscriptionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetShareSubscriptionResult
    {
        /// <summary>
        /// Time at which the share subscription was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// The resource id of the azure resource
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The invitation id.
        /// </summary>
        public readonly string InvitationId;
        /// <summary>
        /// Name of the azure resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Email of the provider who created the resource
        /// </summary>
        public readonly string ProviderEmail;
        /// <summary>
        /// Name of the provider who created the resource
        /// </summary>
        public readonly string ProviderName;
        /// <summary>
        /// Tenant name of the provider who created the resource
        /// </summary>
        public readonly string ProviderTenantName;
        /// <summary>
        /// Provisioning state of the share subscription
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Description of share
        /// </summary>
        public readonly string ShareDescription;
        /// <summary>
        /// Kind of share
        /// </summary>
        public readonly string ShareKind;
        /// <summary>
        /// Name of the share
        /// </summary>
        public readonly string ShareName;
        /// <summary>
        /// Gets the current status of share subscription.
        /// </summary>
        public readonly string ShareSubscriptionStatus;
        /// <summary>
        /// Terms of a share
        /// </summary>
        public readonly string ShareTerms;
        /// <summary>
        /// Source share location.
        /// </summary>
        public readonly string SourceShareLocation;
        /// <summary>
        /// Type of the azure resource
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Email of the user who created the resource
        /// </summary>
        public readonly string UserEmail;
        /// <summary>
        /// Name of the user who created the resource
        /// </summary>
        public readonly string UserName;

        [OutputConstructor]
        private GetShareSubscriptionResult(
            string createdAt,

            string id,

            string invitationId,

            string name,

            string providerEmail,

            string providerName,

            string providerTenantName,

            string provisioningState,

            string shareDescription,

            string shareKind,

            string shareName,

            string shareSubscriptionStatus,

            string shareTerms,

            string sourceShareLocation,

            string type,

            string userEmail,

            string userName)
        {
            CreatedAt = createdAt;
            Id = id;
            InvitationId = invitationId;
            Name = name;
            ProviderEmail = providerEmail;
            ProviderName = providerName;
            ProviderTenantName = providerTenantName;
            ProvisioningState = provisioningState;
            ShareDescription = shareDescription;
            ShareKind = shareKind;
            ShareName = shareName;
            ShareSubscriptionStatus = shareSubscriptionStatus;
            ShareTerms = shareTerms;
            SourceShareLocation = sourceShareLocation;
            Type = type;
            UserEmail = userEmail;
            UserName = userName;
        }
    }
}
