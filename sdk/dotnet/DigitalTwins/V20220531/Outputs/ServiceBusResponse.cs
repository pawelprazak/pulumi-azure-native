// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DigitalTwins.V20220531.Outputs
{

    /// <summary>
    /// Properties related to ServiceBus.
    /// </summary>
    [OutputType]
    public sealed class ServiceBusResponse
    {
        /// <summary>
        /// Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        /// </summary>
        public readonly string? AuthenticationType;
        /// <summary>
        /// Time when the Endpoint was added to DigitalTwinsInstance.
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        public readonly string? DeadLetterSecret;
        /// <summary>
        /// Dead letter storage URL for identity-based authentication.
        /// </summary>
        public readonly string? DeadLetterUri;
        /// <summary>
        /// The type of Digital Twins endpoint
        /// Expected value is 'ServiceBus'.
        /// </summary>
        public readonly string EndpointType;
        /// <summary>
        /// The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol 'sb://'.
        /// </summary>
        public readonly string? EndpointUri;
        /// <summary>
        /// The ServiceBus Topic name for identity-based authentication.
        /// </summary>
        public readonly string? EntityPath;
        /// <summary>
        /// PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        public readonly string? PrimaryConnectionString;
        /// <summary>
        /// The provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        public readonly string? SecondaryConnectionString;

        [OutputConstructor]
        private ServiceBusResponse(
            string? authenticationType,

            string createdTime,

            string? deadLetterSecret,

            string? deadLetterUri,

            string endpointType,

            string? endpointUri,

            string? entityPath,

            string? primaryConnectionString,

            string provisioningState,

            string? secondaryConnectionString)
        {
            AuthenticationType = authenticationType;
            CreatedTime = createdTime;
            DeadLetterSecret = deadLetterSecret;
            DeadLetterUri = deadLetterUri;
            EndpointType = endpointType;
            EndpointUri = endpointUri;
            EntityPath = entityPath;
            PrimaryConnectionString = primaryConnectionString;
            ProvisioningState = provisioningState;
            SecondaryConnectionString = secondaryConnectionString;
        }
    }
}
