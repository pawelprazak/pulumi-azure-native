// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DBforPostgreSQL.V20210410PrivatePreview.Inputs
{

    public sealed class ServerPropertiesDelegatedSubnetArgumentsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// delegated subnet arm resource id.
        /// </summary>
        [Input("subnetArmResourceId")]
        public Input<string>? SubnetArmResourceId { get; set; }

        public ServerPropertiesDelegatedSubnetArgumentsArgs()
        {
        }
    }
}
