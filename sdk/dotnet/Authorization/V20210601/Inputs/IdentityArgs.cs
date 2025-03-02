// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Authorization.V20210601.Inputs
{

    /// <summary>
    /// Identity for the resource.  Policy assignments support a maximum of one identity.  That is either a system assigned identity or a single user assigned identity.
    /// </summary>
    public sealed class IdentityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The identity type. This is the only required field when adding a system or user assigned identity to a resource.
        /// </summary>
        [Input("type")]
        public Input<Pulumi.AzureNative.Authorization.V20210601.ResourceIdentityType>? Type { get; set; }

        [Input("userAssignedIdentities")]
        private InputMap<object>? _userAssignedIdentities;

        /// <summary>
        /// The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        public InputMap<object> UserAssignedIdentities
        {
            get => _userAssignedIdentities ?? (_userAssignedIdentities = new InputMap<object>());
            set => _userAssignedIdentities = value;
        }

        public IdentityArgs()
        {
        }
    }
}
