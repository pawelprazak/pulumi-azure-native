// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SignalRService.Outputs
{

    /// <summary>
    /// The billing information of the SignalR resource.
    /// </summary>
    [OutputType]
    public sealed class ResourceSkuResponse
    {
        /// <summary>
        /// Optional, integer. The unit count of SignalR resource. 1 by default.
        /// 
        /// If present, following values are allowed:
        ///     Free: 1
        ///     Standard: 1,2,5,10,20,50,100
        /// </summary>
        public readonly int? Capacity;
        /// <summary>
        /// Not used. Retained for future use.
        /// </summary>
        public readonly string Family;
        /// <summary>
        /// The name of the SKU. Required.
        /// 
        /// Allowed values: Standard_S1, Free_F1
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Not used. Retained for future use.
        /// </summary>
        public readonly string Size;
        /// <summary>
        /// Optional tier of this particular SKU. 'Standard' or 'Free'. 
        /// 
        /// `Basic` is deprecated, use `Standard` instead.
        /// </summary>
        public readonly string? Tier;

        [OutputConstructor]
        private ResourceSkuResponse(
            int? capacity,

            string family,

            string name,

            string size,

            string? tier)
        {
            Capacity = capacity;
            Family = family;
            Name = name;
            Size = size;
            Tier = tier;
        }
    }
}
