// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB.V20210415.Inputs
{

    /// <summary>
    /// The set of data plane operations permitted through this Role Definition.
    /// </summary>
    public sealed class PermissionArgs : Pulumi.ResourceArgs
    {
        [Input("dataActions")]
        private InputList<string>? _dataActions;

        /// <summary>
        /// An array of data actions that are allowed.
        /// </summary>
        public InputList<string> DataActions
        {
            get => _dataActions ?? (_dataActions = new InputList<string>());
            set => _dataActions = value;
        }

        [Input("notDataActions")]
        private InputList<string>? _notDataActions;

        /// <summary>
        /// An array of data actions that are denied.
        /// </summary>
        public InputList<string> NotDataActions
        {
            get => _notDataActions ?? (_notDataActions = new InputList<string>());
            set => _notDataActions = value;
        }

        public PermissionArgs()
        {
        }
    }
}
