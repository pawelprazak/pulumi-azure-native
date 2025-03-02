// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StoragePool.V20200315Preview.Outputs
{

    /// <summary>
    /// Access Control List (ACL) for an iSCSI target portal group
    /// </summary>
    [OutputType]
    public sealed class AclResponse
    {
        /// <summary>
        /// iSCSI initiator IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:client".
        /// </summary>
        public readonly string InitiatorIqn;
        /// <summary>
        /// List of LUN names mapped to the ACL.
        /// </summary>
        public readonly ImmutableArray<string> MappedLuns;
        /// <summary>
        /// Password for Challenge Handshake Authentication Protocol (CHAP) authentication.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// Username for Challenge Handshake Authentication Protocol (CHAP) authentication.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private AclResponse(
            string initiatorIqn,

            ImmutableArray<string> mappedLuns,

            string password,

            string username)
        {
            InitiatorIqn = initiatorIqn;
            MappedLuns = mappedLuns;
            Password = password;
            Username = username;
        }
    }
}
