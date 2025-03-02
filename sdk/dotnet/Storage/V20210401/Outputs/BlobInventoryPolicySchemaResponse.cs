// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Storage.V20210401.Outputs
{

    /// <summary>
    /// The storage account blob inventory policy rules.
    /// </summary>
    [OutputType]
    public sealed class BlobInventoryPolicySchemaResponse
    {
        /// <summary>
        /// Policy is enabled if set to true.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// The storage account blob inventory policy rules. The rule is applied when it is enabled.
        /// </summary>
        public readonly ImmutableArray<Outputs.BlobInventoryPolicyRuleResponse> Rules;
        /// <summary>
        /// The valid value is Inventory
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private BlobInventoryPolicySchemaResponse(
            bool enabled,

            ImmutableArray<Outputs.BlobInventoryPolicyRuleResponse> rules,

            string type)
        {
            Enabled = enabled;
            Rules = rules;
            Type = type;
        }
    }
}
