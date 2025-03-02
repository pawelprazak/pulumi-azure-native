// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20200601.Inputs
{

    public sealed class FacebookArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("graphApiVersion")]
        public Input<string>? GraphApiVersion { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("login")]
        public Input<Inputs.LoginScopesArgs>? Login { get; set; }

        [Input("registration")]
        public Input<Inputs.AppRegistrationArgs>? Registration { get; set; }

        public FacebookArgs()
        {
        }
    }
}
