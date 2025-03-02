// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20220101Preview.Inputs
{

    /// <summary>
    /// The available data types for Dynamics365 data connector.
    /// </summary>
    public sealed class Dynamics365DataConnectorDataTypesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Common Data Service data type connection.
        /// </summary>
        [Input("dynamics365CdsActivities", required: true)]
        public Input<Inputs.Dynamics365DataConnectorDataTypesDynamics365CdsActivitiesArgs> Dynamics365CdsActivities { get; set; } = null!;

        public Dynamics365DataConnectorDataTypesArgs()
        {
        }
    }
}
