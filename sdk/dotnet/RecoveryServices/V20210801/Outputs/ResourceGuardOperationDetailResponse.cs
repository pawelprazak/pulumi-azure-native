// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20210801.Outputs
{

    [OutputType]
    public sealed class ResourceGuardOperationDetailResponse
    {
        public readonly string? DefaultResourceRequest;
        public readonly string? VaultCriticalOperation;

        [OutputConstructor]
        private ResourceGuardOperationDetailResponse(
            string? defaultResourceRequest,

            string? vaultCriticalOperation)
        {
            DefaultResourceRequest = defaultResourceRequest;
            VaultCriticalOperation = vaultCriticalOperation;
        }
    }
}
