// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.BotService.V20171201.Outputs
{

    /// <summary>
    /// A site for the Direct Line channel
    /// </summary>
    [OutputType]
    public sealed class DirectLineSiteResponse
    {
        /// <summary>
        /// Whether this site is enabled for DirectLine channel
        /// </summary>
        public readonly bool IsEnabled;
        /// <summary>
        /// Whether this site is enabled for Bot Framework V1 protocol
        /// </summary>
        public readonly bool IsV1Enabled;
        /// <summary>
        /// Whether this site is enabled for Bot Framework V1 protocol
        /// </summary>
        public readonly bool IsV3Enabled;
        /// <summary>
        /// Primary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Secondary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        public readonly string Key2;
        /// <summary>
        /// Site Id
        /// </summary>
        public readonly string SiteId;
        /// <summary>
        /// Site name
        /// </summary>
        public readonly string SiteName;

        [OutputConstructor]
        private DirectLineSiteResponse(
            bool isEnabled,

            bool isV1Enabled,

            bool isV3Enabled,

            string key,

            string key2,

            string siteId,

            string siteName)
        {
            IsEnabled = isEnabled;
            IsV1Enabled = isV1Enabled;
            IsV3Enabled = isV3Enabled;
            Key = key;
            Key2 = key2;
            SiteId = siteId;
            SiteName = siteName;
        }
    }
}
