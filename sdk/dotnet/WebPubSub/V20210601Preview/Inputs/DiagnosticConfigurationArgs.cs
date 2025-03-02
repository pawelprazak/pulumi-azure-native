// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.WebPubSub.V20210601Preview.Inputs
{

    /// <summary>
    /// Diagnostic configuration of a Microsoft.SignalRService resource. Used together with Azure monitor DiagnosticSettings.
    /// </summary>
    public sealed class DiagnosticConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicate whether or not enable Connectivity logs.
        /// Available values: Enabled, Disabled.
        /// Case insensitive.
        /// </summary>
        [Input("enableConnectivityLogs")]
        public Input<string>? EnableConnectivityLogs { get; set; }

        /// <summary>
        /// Indicate whether or not enable Live Trace. 
        /// Available values: Enabled, Disabled. 
        /// Case insensitive. 
        /// Live Trace allows you to know what's happening inside Azure SignalR service, it will give you live traces in real time, it will be helpful when you developing your own Azure SignalR based web application or self-troubleshooting some issues.
        /// </summary>
        [Input("enableLiveTrace")]
        public Input<string>? EnableLiveTrace { get; set; }

        /// <summary>
        /// Indicate whether or not enable Messaging logs.
        /// Available values: Enabled, Disabled.
        /// Case insensitive.
        /// </summary>
        [Input("enableMessagingLogs")]
        public Input<string>? EnableMessagingLogs { get; set; }

        public DiagnosticConfigurationArgs()
        {
        }
    }
}
