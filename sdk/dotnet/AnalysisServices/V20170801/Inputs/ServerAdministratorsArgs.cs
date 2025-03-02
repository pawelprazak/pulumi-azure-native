// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AnalysisServices.V20170801.Inputs
{

    /// <summary>
    /// An array of administrator user identities.
    /// </summary>
    public sealed class ServerAdministratorsArgs : Pulumi.ResourceArgs
    {
        [Input("members")]
        private InputList<string>? _members;

        /// <summary>
        /// An array of administrator user identities.
        /// </summary>
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        public ServerAdministratorsArgs()
        {
        }
    }
}
