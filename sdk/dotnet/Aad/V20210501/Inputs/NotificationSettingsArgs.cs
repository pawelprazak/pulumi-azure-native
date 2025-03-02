// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Aad.V20210501.Inputs
{

    /// <summary>
    /// Settings for notification
    /// </summary>
    public sealed class NotificationSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("additionalRecipients")]
        private InputList<string>? _additionalRecipients;

        /// <summary>
        /// The list of additional recipients
        /// </summary>
        public InputList<string> AdditionalRecipients
        {
            get => _additionalRecipients ?? (_additionalRecipients = new InputList<string>());
            set => _additionalRecipients = value;
        }

        /// <summary>
        /// Should domain controller admins be notified
        /// </summary>
        [Input("notifyDcAdmins")]
        public InputUnion<string, Pulumi.AzureNative.Aad.V20210501.NotifyDcAdmins>? NotifyDcAdmins { get; set; }

        /// <summary>
        /// Should global admins be notified
        /// </summary>
        [Input("notifyGlobalAdmins")]
        public InputUnion<string, Pulumi.AzureNative.Aad.V20210501.NotifyGlobalAdmins>? NotifyGlobalAdmins { get; set; }

        public NotificationSettingsArgs()
        {
        }
    }
}
