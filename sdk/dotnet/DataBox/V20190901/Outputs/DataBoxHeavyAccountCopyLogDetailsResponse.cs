// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataBox.V20190901.Outputs
{

    /// <summary>
    /// Copy log details for a storage account for Databox heavy
    /// </summary>
    [OutputType]
    public sealed class DataBoxHeavyAccountCopyLogDetailsResponse
    {
        /// <summary>
        /// Destination account name.
        /// </summary>
        public readonly string AccountName;
        /// <summary>
        /// Indicates the type of job details.
        /// Expected value is 'DataBoxHeavy'.
        /// </summary>
        public readonly string CopyLogDetailsType;
        /// <summary>
        /// Link for copy logs.
        /// </summary>
        public readonly ImmutableArray<string> CopyLogLink;

        [OutputConstructor]
        private DataBoxHeavyAccountCopyLogDetailsResponse(
            string accountName,

            string copyLogDetailsType,

            ImmutableArray<string> copyLogLink)
        {
            AccountName = accountName;
            CopyLogDetailsType = copyLogDetailsType;
            CopyLogLink = copyLogLink;
        }
    }
}
