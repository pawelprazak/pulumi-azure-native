// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Devices.V20210702Preview.Inputs
{

    /// <summary>
    /// The device streams properties of iothub.
    /// </summary>
    public sealed class IotHubPropertiesDeviceStreamsArgs : Pulumi.ResourceArgs
    {
        [Input("streamingEndpoints")]
        private InputList<string>? _streamingEndpoints;

        /// <summary>
        /// List of Device Streams Endpoints.
        /// </summary>
        public InputList<string> StreamingEndpoints
        {
            get => _streamingEndpoints ?? (_streamingEndpoints = new InputList<string>());
            set => _streamingEndpoints = value;
        }

        public IotHubPropertiesDeviceStreamsArgs()
        {
        }
    }
}
