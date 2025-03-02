// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.Outputs
{

    /// <summary>
    /// Google AdWords service linked service.
    /// </summary>
    [OutputType]
    public sealed class GoogleAdWordsLinkedServiceResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR.
        /// </summary>
        public readonly string? AuthenticationType;
        /// <summary>
        /// The Client customer ID of the AdWords account that you want to fetch report data for.
        /// </summary>
        public readonly object? ClientCustomerID;
        /// <summary>
        /// The client id of the google application used to acquire the refresh token. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ClientId;
        /// <summary>
        /// The client secret of the google application used to acquire the refresh token.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? ClientSecret;
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse? ConnectVia;
        /// <summary>
        /// Properties used to connect to GoogleAds. It is mutually exclusive with any other properties in the linked service. Type: object.
        /// </summary>
        public readonly object? ConnectionProperties;
        /// <summary>
        /// Linked service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The developer token associated with the manager account that you use to grant access to the AdWords API.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? DeveloperToken;
        /// <summary>
        /// The service account email ID that is used for ServiceAuthentication and can only be used on self-hosted IR.
        /// </summary>
        public readonly object? Email;
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncryptedCredential;
        /// <summary>
        /// The full path to the .p12 key file that is used to authenticate the service account email address and can only be used on self-hosted IR.
        /// </summary>
        public readonly object? KeyFilePath;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// The refresh token obtained from Google for authorizing access to AdWords for UserAuthentication.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? RefreshToken;
        /// <summary>
        /// The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR.
        /// </summary>
        public readonly object? TrustedCertPath;
        /// <summary>
        /// Type of linked service.
        /// Expected value is 'GoogleAdWords'.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false.
        /// </summary>
        public readonly object? UseSystemTrustStore;

        [OutputConstructor]
        private GoogleAdWordsLinkedServiceResponse(
            ImmutableArray<object> annotations,

            string? authenticationType,

            object? clientCustomerID,

            object? clientId,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? clientSecret,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            object? connectionProperties,

            string? description,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? developerToken,

            object? email,

            object? encryptedCredential,

            object? keyFilePath,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? refreshToken,

            object? trustedCertPath,

            string type,

            object? useSystemTrustStore)
        {
            Annotations = annotations;
            AuthenticationType = authenticationType;
            ClientCustomerID = clientCustomerID;
            ClientId = clientId;
            ClientSecret = clientSecret;
            ConnectVia = connectVia;
            ConnectionProperties = connectionProperties;
            Description = description;
            DeveloperToken = developerToken;
            Email = email;
            EncryptedCredential = encryptedCredential;
            KeyFilePath = keyFilePath;
            Parameters = parameters;
            RefreshToken = refreshToken;
            TrustedCertPath = trustedCertPath;
            Type = type;
            UseSystemTrustStore = useSystemTrustStore;
        }
    }
}
