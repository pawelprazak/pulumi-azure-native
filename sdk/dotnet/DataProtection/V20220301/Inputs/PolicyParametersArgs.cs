// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataProtection.V20220301.Inputs
{

    /// <summary>
    /// Parameters in Policy
    /// </summary>
    public sealed class PolicyParametersArgs : Pulumi.ResourceArgs
    {
        [Input("dataStoreParametersList")]
        private InputList<Inputs.AzureOperationalStoreParametersArgs>? _dataStoreParametersList;

        /// <summary>
        /// Gets or sets the DataStore Parameters
        /// </summary>
        public InputList<Inputs.AzureOperationalStoreParametersArgs> DataStoreParametersList
        {
            get => _dataStoreParametersList ?? (_dataStoreParametersList = new InputList<Inputs.AzureOperationalStoreParametersArgs>());
            set => _dataStoreParametersList = value;
        }

        public PolicyParametersArgs()
        {
        }
    }
}
