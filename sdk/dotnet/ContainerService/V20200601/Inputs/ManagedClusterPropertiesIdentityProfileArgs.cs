// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20200601.Inputs
{

    public sealed class ManagedClusterPropertiesIdentityProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The client id of the user assigned identity.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// The object id of the user assigned identity.
        /// </summary>
        [Input("objectId")]
        public Input<string>? ObjectId { get; set; }

        /// <summary>
        /// The resource id of the user assigned identity.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        public ManagedClusterPropertiesIdentityProfileArgs()
        {
        }
    }
}
