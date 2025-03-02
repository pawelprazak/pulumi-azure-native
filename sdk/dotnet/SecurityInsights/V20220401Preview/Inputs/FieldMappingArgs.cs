// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20220401Preview.Inputs
{

    /// <summary>
    /// A single field mapping of the mapped entity
    /// </summary>
    public sealed class FieldMappingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// the column name to be mapped to the identifier
        /// </summary>
        [Input("columnName")]
        public Input<string>? ColumnName { get; set; }

        /// <summary>
        /// the V3 identifier of the entity
        /// </summary>
        [Input("identifier")]
        public Input<string>? Identifier { get; set; }

        public FieldMappingArgs()
        {
        }
    }
}
