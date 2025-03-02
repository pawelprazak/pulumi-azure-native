// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ApiManagement.V20210101Preview.Inputs
{

    /// <summary>
    /// Email Template Parameter contract.
    /// </summary>
    public sealed class EmailTemplateParametersContractPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template parameter description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Template parameter name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Template parameter title.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        public EmailTemplateParametersContractPropertiesArgs()
        {
        }
    }
}
