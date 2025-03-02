// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.NetApp.V20190801.Outputs
{

    /// <summary>
    /// DataProtection volume, can have a replication object
    /// </summary>
    [OutputType]
    public sealed class VolumePropertiesResponseDataProtection
    {
        /// <summary>
        /// Replication properties
        /// </summary>
        public readonly Outputs.ReplicationObjectResponse? Replication;

        [OutputConstructor]
        private VolumePropertiesResponseDataProtection(Outputs.ReplicationObjectResponse? replication)
        {
            Replication = replication;
        }
    }
}
