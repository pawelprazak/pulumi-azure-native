// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AVS.V20210601.Inputs
{

    /// <summary>
    /// An iSCSI volume from Microsoft.StoragePool provider
    /// </summary>
    public sealed class DiskPoolVolumeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the LUN to be used for datastore
        /// </summary>
        [Input("lunName", required: true)]
        public Input<string> LunName { get; set; } = null!;

        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        [Input("mountOption")]
        public InputUnion<string, Pulumi.AzureNative.AVS.V20210601.MountOptionEnum>? MountOption { get; set; }

        /// <summary>
        /// Azure resource ID of the iSCSI target
        /// </summary>
        [Input("targetId", required: true)]
        public Input<string> TargetId { get; set; } = null!;

        public DiskPoolVolumeArgs()
        {
            MountOption = "MOUNT";
        }
    }
}
