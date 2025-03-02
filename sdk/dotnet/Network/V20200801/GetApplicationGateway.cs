// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20200801
{
    public static class GetApplicationGateway
    {
        /// <summary>
        /// Application gateway resource.
        /// </summary>
        public static Task<GetApplicationGatewayResult> InvokeAsync(GetApplicationGatewayArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApplicationGatewayResult>("azure-native:network/v20200801:getApplicationGateway", args ?? new GetApplicationGatewayArgs(), options.WithDefaults());

        /// <summary>
        /// Application gateway resource.
        /// </summary>
        public static Output<GetApplicationGatewayResult> Invoke(GetApplicationGatewayInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetApplicationGatewayResult>("azure-native:network/v20200801:getApplicationGateway", args ?? new GetApplicationGatewayInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApplicationGatewayArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application gateway.
        /// </summary>
        [Input("applicationGatewayName", required: true)]
        public string ApplicationGatewayName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetApplicationGatewayArgs()
        {
        }
    }

    public sealed class GetApplicationGatewayInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the application gateway.
        /// </summary>
        [Input("applicationGatewayName", required: true)]
        public Input<string> ApplicationGatewayName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetApplicationGatewayInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApplicationGatewayResult
    {
        /// <summary>
        /// Authentication certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayAuthenticationCertificateResponse> AuthenticationCertificates;
        /// <summary>
        /// Autoscale Configuration.
        /// </summary>
        public readonly Outputs.ApplicationGatewayAutoscaleConfigurationResponse? AutoscaleConfiguration;
        /// <summary>
        /// Backend address pool of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayBackendAddressPoolResponse> BackendAddressPools;
        /// <summary>
        /// Backend http settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayBackendHttpSettingsResponse> BackendHttpSettingsCollection;
        /// <summary>
        /// Custom error configurations of the application gateway resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayCustomErrorResponse> CustomErrorConfigurations;
        /// <summary>
        /// Whether FIPS is enabled on the application gateway resource.
        /// </summary>
        public readonly bool? EnableFips;
        /// <summary>
        /// Whether HTTP2 is enabled on the application gateway resource.
        /// </summary>
        public readonly bool? EnableHttp2;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Reference to the FirewallPolicy resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse? FirewallPolicy;
        /// <summary>
        /// If true, associates a firewall policy with an application gateway regardless whether the policy differs from the WAF Config.
        /// </summary>
        public readonly bool? ForceFirewallPolicyAssociation;
        /// <summary>
        /// Frontend IP addresses of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayFrontendIPConfigurationResponse> FrontendIPConfigurations;
        /// <summary>
        /// Frontend ports of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayFrontendPortResponse> FrontendPorts;
        /// <summary>
        /// Subnets of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayIPConfigurationResponse> GatewayIPConfigurations;
        /// <summary>
        /// Http listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayHttpListenerResponse> HttpListeners;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The identity of the application gateway, if configured.
        /// </summary>
        public readonly Outputs.ManagedServiceIdentityResponse? Identity;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Operational state of the application gateway resource.
        /// </summary>
        public readonly string OperationalState;
        /// <summary>
        /// Private Endpoint connections on application gateway.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayPrivateEndpointConnectionResponse> PrivateEndpointConnections;
        /// <summary>
        /// PrivateLink configurations on application gateway.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayPrivateLinkConfigurationResponse> PrivateLinkConfigurations;
        /// <summary>
        /// Probes of the application gateway resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayProbeResponse> Probes;
        /// <summary>
        /// The provisioning state of the application gateway resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Redirect configurations of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayRedirectConfigurationResponse> RedirectConfigurations;
        /// <summary>
        /// Request routing rules of the application gateway resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayRequestRoutingRuleResponse> RequestRoutingRules;
        /// <summary>
        /// The resource GUID property of the application gateway resource.
        /// </summary>
        public readonly string ResourceGuid;
        /// <summary>
        /// Rewrite rules for the application gateway resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayRewriteRuleSetResponse> RewriteRuleSets;
        /// <summary>
        /// SKU of the application gateway resource.
        /// </summary>
        public readonly Outputs.ApplicationGatewaySkuResponse? Sku;
        /// <summary>
        /// SSL certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewaySslCertificateResponse> SslCertificates;
        /// <summary>
        /// SSL policy of the application gateway resource.
        /// </summary>
        public readonly Outputs.ApplicationGatewaySslPolicyResponse? SslPolicy;
        /// <summary>
        /// SSL profiles of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewaySslProfileResponse> SslProfiles;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Trusted client certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayTrustedClientCertificateResponse> TrustedClientCertificates;
        /// <summary>
        /// Trusted Root certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayTrustedRootCertificateResponse> TrustedRootCertificates;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// URL path map of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayUrlPathMapResponse> UrlPathMaps;
        /// <summary>
        /// Web application firewall configuration.
        /// </summary>
        public readonly Outputs.ApplicationGatewayWebApplicationFirewallConfigurationResponse? WebApplicationFirewallConfiguration;
        /// <summary>
        /// A list of availability zones denoting where the resource needs to come from.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetApplicationGatewayResult(
            ImmutableArray<Outputs.ApplicationGatewayAuthenticationCertificateResponse> authenticationCertificates,

            Outputs.ApplicationGatewayAutoscaleConfigurationResponse? autoscaleConfiguration,

            ImmutableArray<Outputs.ApplicationGatewayBackendAddressPoolResponse> backendAddressPools,

            ImmutableArray<Outputs.ApplicationGatewayBackendHttpSettingsResponse> backendHttpSettingsCollection,

            ImmutableArray<Outputs.ApplicationGatewayCustomErrorResponse> customErrorConfigurations,

            bool? enableFips,

            bool? enableHttp2,

            string etag,

            Outputs.SubResourceResponse? firewallPolicy,

            bool? forceFirewallPolicyAssociation,

            ImmutableArray<Outputs.ApplicationGatewayFrontendIPConfigurationResponse> frontendIPConfigurations,

            ImmutableArray<Outputs.ApplicationGatewayFrontendPortResponse> frontendPorts,

            ImmutableArray<Outputs.ApplicationGatewayIPConfigurationResponse> gatewayIPConfigurations,

            ImmutableArray<Outputs.ApplicationGatewayHttpListenerResponse> httpListeners,

            string? id,

            Outputs.ManagedServiceIdentityResponse? identity,

            string? location,

            string name,

            string operationalState,

            ImmutableArray<Outputs.ApplicationGatewayPrivateEndpointConnectionResponse> privateEndpointConnections,

            ImmutableArray<Outputs.ApplicationGatewayPrivateLinkConfigurationResponse> privateLinkConfigurations,

            ImmutableArray<Outputs.ApplicationGatewayProbeResponse> probes,

            string provisioningState,

            ImmutableArray<Outputs.ApplicationGatewayRedirectConfigurationResponse> redirectConfigurations,

            ImmutableArray<Outputs.ApplicationGatewayRequestRoutingRuleResponse> requestRoutingRules,

            string resourceGuid,

            ImmutableArray<Outputs.ApplicationGatewayRewriteRuleSetResponse> rewriteRuleSets,

            Outputs.ApplicationGatewaySkuResponse? sku,

            ImmutableArray<Outputs.ApplicationGatewaySslCertificateResponse> sslCertificates,

            Outputs.ApplicationGatewaySslPolicyResponse? sslPolicy,

            ImmutableArray<Outputs.ApplicationGatewaySslProfileResponse> sslProfiles,

            ImmutableDictionary<string, string>? tags,

            ImmutableArray<Outputs.ApplicationGatewayTrustedClientCertificateResponse> trustedClientCertificates,

            ImmutableArray<Outputs.ApplicationGatewayTrustedRootCertificateResponse> trustedRootCertificates,

            string type,

            ImmutableArray<Outputs.ApplicationGatewayUrlPathMapResponse> urlPathMaps,

            Outputs.ApplicationGatewayWebApplicationFirewallConfigurationResponse? webApplicationFirewallConfiguration,

            ImmutableArray<string> zones)
        {
            AuthenticationCertificates = authenticationCertificates;
            AutoscaleConfiguration = autoscaleConfiguration;
            BackendAddressPools = backendAddressPools;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
            CustomErrorConfigurations = customErrorConfigurations;
            EnableFips = enableFips;
            EnableHttp2 = enableHttp2;
            Etag = etag;
            FirewallPolicy = firewallPolicy;
            ForceFirewallPolicyAssociation = forceFirewallPolicyAssociation;
            FrontendIPConfigurations = frontendIPConfigurations;
            FrontendPorts = frontendPorts;
            GatewayIPConfigurations = gatewayIPConfigurations;
            HttpListeners = httpListeners;
            Id = id;
            Identity = identity;
            Location = location;
            Name = name;
            OperationalState = operationalState;
            PrivateEndpointConnections = privateEndpointConnections;
            PrivateLinkConfigurations = privateLinkConfigurations;
            Probes = probes;
            ProvisioningState = provisioningState;
            RedirectConfigurations = redirectConfigurations;
            RequestRoutingRules = requestRoutingRules;
            ResourceGuid = resourceGuid;
            RewriteRuleSets = rewriteRuleSets;
            Sku = sku;
            SslCertificates = sslCertificates;
            SslPolicy = sslPolicy;
            SslProfiles = sslProfiles;
            Tags = tags;
            TrustedClientCertificates = trustedClientCertificates;
            TrustedRootCertificates = trustedRootCertificates;
            Type = type;
            UrlPathMaps = urlPathMaps;
            WebApplicationFirewallConfiguration = webApplicationFirewallConfiguration;
            Zones = zones;
        }
    }
}
