// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.BotService.Outputs
{

    /// <summary>
    /// The parameters to provide for the Enterprise Channel.
    /// </summary>
    [OutputType]
    public sealed class EnterpriseChannelPropertiesResponse
    {
        /// <summary>
        /// The nodes associated with the Enterprise Channel.
        /// </summary>
        public readonly ImmutableArray<Outputs.EnterpriseChannelNodeResponse> Nodes;
        /// <summary>
        /// The current state of the Enterprise Channel.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private EnterpriseChannelPropertiesResponse(
            ImmutableArray<Outputs.EnterpriseChannelNodeResponse> nodes,

            string? state)
        {
            Nodes = nodes;
            State = state;
        }
    }
}
