// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.BotService.V20180712.Outputs
{

    /// <summary>
    /// Facebook channel definition
    /// </summary>
    [OutputType]
    public sealed class FacebookChannelResponse
    {
        /// <summary>
        /// The channel name
        /// Expected value is 'FacebookChannel'.
        /// </summary>
        public readonly string ChannelName;
        /// <summary>
        /// The set of properties specific to bot facebook channel
        /// </summary>
        public readonly Outputs.FacebookChannelPropertiesResponse? Properties;

        [OutputConstructor]
        private FacebookChannelResponse(
            string channelName,

            Outputs.FacebookChannelPropertiesResponse? properties)
        {
            ChannelName = channelName;
            Properties = properties;
        }
    }
}
