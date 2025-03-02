// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Confluent.V20200301Preview.Outputs
{

    /// <summary>
    /// Subscriber detail
    /// </summary>
    [OutputType]
    public sealed class OrganizationResourcePropertiesResponseUserDetail
    {
        /// <summary>
        /// Email address
        /// </summary>
        public readonly string? EmailAddress;
        /// <summary>
        /// First name
        /// </summary>
        public readonly string? FirstName;
        /// <summary>
        /// Last name
        /// </summary>
        public readonly string? LastName;

        [OutputConstructor]
        private OrganizationResourcePropertiesResponseUserDetail(
            string? emailAddress,

            string? firstName,

            string? lastName)
        {
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
