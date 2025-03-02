// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Logz.V20201001.Outputs
{

    /// <summary>
    /// Definition of the properties for a TagRules resource.
    /// </summary>
    [OutputType]
    public sealed class MonitoringTagRulesPropertiesResponse
    {
        /// <summary>
        /// Set of rules for sending logs for the Monitor resource.
        /// </summary>
        public readonly Outputs.LogRulesResponse? LogRules;
        /// <summary>
        /// Flag specifying if the resource provisioning state as tracked by ARM.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;

        [OutputConstructor]
        private MonitoringTagRulesPropertiesResponse(
            Outputs.LogRulesResponse? logRules,

            string provisioningState,

            Outputs.SystemDataResponse systemData)
        {
            LogRules = logRules;
            ProvisioningState = provisioningState;
            SystemData = systemData;
        }
    }
}
