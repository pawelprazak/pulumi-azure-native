// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Security.V20220501Preview.Inputs
{

    /// <summary>
    /// The cloudwatch to kinesis connection configuration
    /// </summary>
    public sealed class DefenderForContainersAwsOfferingCloudWatchToKinesisArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The cloud role ARN in AWS used by CloudWatch to transfer data into Kinesis
        /// </summary>
        [Input("cloudRoleArn")]
        public Input<string>? CloudRoleArn { get; set; }

        public DefenderForContainersAwsOfferingCloudWatchToKinesisArgs()
        {
        }
    }
}
