// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ProviderHub.V20210501Preview.Outputs
{

    [OutputType]
    public sealed class ResourceTypeRegistrationPropertiesResponseFeaturesRule
    {
        public readonly string RequiredFeaturesPolicy;

        [OutputConstructor]
        private ResourceTypeRegistrationPropertiesResponseFeaturesRule(string requiredFeaturesPolicy)
        {
            RequiredFeaturesPolicy = requiredFeaturesPolicy;
        }
    }
}
