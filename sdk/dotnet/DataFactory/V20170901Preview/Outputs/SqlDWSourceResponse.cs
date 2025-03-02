// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.V20170901Preview.Outputs
{

    /// <summary>
    /// A copy activity SQL Data Warehouse source.
    /// </summary>
    [OutputType]
    public sealed class SqlDWSourceResponse
    {
        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SourceRetryCount;
        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? SourceRetryWait;
        /// <summary>
        /// SQL Data Warehouse reader query. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SqlReaderQuery;
        /// <summary>
        /// Name of the stored procedure for a SQL Data Warehouse source. This cannot be used at the same time as SqlReaderQuery. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SqlReaderStoredProcedureName;
        /// <summary>
        /// Value and type setting for stored procedure parameters. Example: "{Parameter1: {value: "1", type: "int"}}". Type: object (or Expression with resultType object), itemType: StoredProcedureParameter.
        /// </summary>
        public readonly object? StoredProcedureParameters;
        /// <summary>
        /// Copy source type.
        /// Expected value is 'SqlDWSource'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private SqlDWSourceResponse(
            object? sourceRetryCount,

            object? sourceRetryWait,

            object? sqlReaderQuery,

            object? sqlReaderStoredProcedureName,

            object? storedProcedureParameters,

            string type)
        {
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            SqlReaderQuery = sqlReaderQuery;
            SqlReaderStoredProcedureName = sqlReaderStoredProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            Type = type;
        }
    }
}
