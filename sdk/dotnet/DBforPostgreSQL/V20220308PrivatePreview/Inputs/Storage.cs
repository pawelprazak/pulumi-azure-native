// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DBforPostgreSQL.V20220308PrivatePreview.Inputs
{

    /// <summary>
    /// Storage properties of a server
    /// </summary>
    public sealed class Storage : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Max storage allowed for a server.
        /// </summary>
        [Input("storageSizeGB")]
        public int? StorageSizeGB { get; set; }

        public Storage()
        {
        }
    }
}
