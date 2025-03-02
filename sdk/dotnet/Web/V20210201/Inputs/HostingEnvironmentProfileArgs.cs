// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20210201.Inputs
{

    /// <summary>
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    public sealed class HostingEnvironmentProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource ID of the App Service Environment.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        public HostingEnvironmentProfileArgs()
        {
        }
    }
}
