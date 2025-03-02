// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20150501.Outputs
{

    /// <summary>
    /// An XML configuration specification for a WebTest.
    /// </summary>
    [OutputType]
    public sealed class WebTestPropertiesResponseConfiguration
    {
        /// <summary>
        /// The XML specification of a WebTest to run against an application.
        /// </summary>
        public readonly string? WebTest;

        [OutputConstructor]
        private WebTestPropertiesResponseConfiguration(string? webTest)
        {
            WebTest = webTest;
        }
    }
}
