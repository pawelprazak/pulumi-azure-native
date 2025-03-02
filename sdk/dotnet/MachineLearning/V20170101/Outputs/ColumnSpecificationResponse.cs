// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearning.V20170101.Outputs
{

    /// <summary>
    /// Swagger 2.0 schema for a column within the data table representing a web service input or output. See Swagger specification: http://swagger.io/specification/
    /// </summary>
    [OutputType]
    public sealed class ColumnSpecificationResponse
    {
        /// <summary>
        /// If the data type is categorical, this provides the list of accepted categories.
        /// </summary>
        public readonly ImmutableArray<object> Enum;
        /// <summary>
        /// Additional format information for the data type.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// Data type of the column.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Flag indicating if the type supports null values or not.
        /// </summary>
        public readonly bool? XMsIsnullable;
        /// <summary>
        /// Flag indicating whether the categories are treated as an ordered set or not, if this is a categorical column.
        /// </summary>
        public readonly bool? XMsIsordered;

        [OutputConstructor]
        private ColumnSpecificationResponse(
            ImmutableArray<object> @enum,

            string? format,

            string type,

            bool? xMsIsnullable,

            bool? xMsIsordered)
        {
            Enum = @enum;
            Format = format;
            Type = type;
            XMsIsnullable = xMsIsnullable;
            XMsIsordered = xMsIsordered;
        }
    }
}
