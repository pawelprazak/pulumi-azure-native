// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureArcData.V20210601Preview.Inputs
{

    /// <summary>
    /// Properties of sqlManagedInstance.
    /// </summary>
    public sealed class SqlManagedInstancePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The instance admin user
        /// </summary>
        [Input("admin")]
        public Input<string>? Admin { get; set; }

        /// <summary>
        /// Username and password for basic authentication.
        /// </summary>
        [Input("basicLoginInformation")]
        public Input<Inputs.BasicLoginInformationArgs>? BasicLoginInformation { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [Input("dataControllerId")]
        public Input<string>? DataControllerId { get; set; }

        /// <summary>
        /// The instance end time
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// The raw kubernetes information
        /// </summary>
        [Input("k8sRaw")]
        public Input<object>? K8sRaw { get; set; }

        /// <summary>
        /// Last uploaded date from Kubernetes cluster. Defaults to current date time
        /// </summary>
        [Input("lastUploadedDate")]
        public Input<string>? LastUploadedDate { get; set; }

        /// <summary>
        /// The instance start time
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        public SqlManagedInstancePropertiesArgs()
        {
        }
    }
}
