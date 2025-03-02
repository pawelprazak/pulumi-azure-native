// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB.V20220515.Outputs
{

    [OutputType]
    public sealed class SqlDatabaseGetPropertiesResponseResource
    {
        /// <summary>
        /// A system generated property that specified the addressable path of the collections resource.
        /// </summary>
        public readonly string? Colls;
        /// <summary>
        /// A system generated property representing the resource etag required for optimistic concurrency control.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Name of the Cosmos DB SQL database
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A system generated property. A unique identifier.
        /// </summary>
        public readonly string Rid;
        /// <summary>
        /// A system generated property that denotes the last updated timestamp of the resource.
        /// </summary>
        public readonly double Ts;
        /// <summary>
        /// A system generated property that specifies the addressable path of the users resource.
        /// </summary>
        public readonly string? Users;

        [OutputConstructor]
        private SqlDatabaseGetPropertiesResponseResource(
            string? colls,

            string etag,

            string id,

            string rid,

            double ts,

            string? users)
        {
            Colls = colls;
            Etag = etag;
            Id = id;
            Rid = rid;
            Ts = ts;
            Users = users;
        }
    }
}
