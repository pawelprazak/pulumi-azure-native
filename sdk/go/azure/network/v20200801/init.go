// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-azure-native/sdk/go/azure"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "azure-native:network/v20200801:ApplicationGateway":
		r = &ApplicationGateway{}
	case "azure-native:network/v20200801:ApplicationGatewayPrivateEndpointConnection":
		r = &ApplicationGatewayPrivateEndpointConnection{}
	case "azure-native:network/v20200801:ApplicationSecurityGroup":
		r = &ApplicationSecurityGroup{}
	case "azure-native:network/v20200801:AzureFirewall":
		r = &AzureFirewall{}
	case "azure-native:network/v20200801:BastionHost":
		r = &BastionHost{}
	case "azure-native:network/v20200801:ConnectionMonitor":
		r = &ConnectionMonitor{}
	case "azure-native:network/v20200801:CustomIPPrefix":
		r = &CustomIPPrefix{}
	case "azure-native:network/v20200801:DdosCustomPolicy":
		r = &DdosCustomPolicy{}
	case "azure-native:network/v20200801:DdosProtectionPlan":
		r = &DdosProtectionPlan{}
	case "azure-native:network/v20200801:DscpConfiguration":
		r = &DscpConfiguration{}
	case "azure-native:network/v20200801:ExpressRouteCircuit":
		r = &ExpressRouteCircuit{}
	case "azure-native:network/v20200801:ExpressRouteCircuitAuthorization":
		r = &ExpressRouteCircuitAuthorization{}
	case "azure-native:network/v20200801:ExpressRouteCircuitConnection":
		r = &ExpressRouteCircuitConnection{}
	case "azure-native:network/v20200801:ExpressRouteCircuitPeering":
		r = &ExpressRouteCircuitPeering{}
	case "azure-native:network/v20200801:ExpressRouteConnection":
		r = &ExpressRouteConnection{}
	case "azure-native:network/v20200801:ExpressRouteCrossConnectionPeering":
		r = &ExpressRouteCrossConnectionPeering{}
	case "azure-native:network/v20200801:ExpressRouteGateway":
		r = &ExpressRouteGateway{}
	case "azure-native:network/v20200801:ExpressRoutePort":
		r = &ExpressRoutePort{}
	case "azure-native:network/v20200801:FirewallPolicy":
		r = &FirewallPolicy{}
	case "azure-native:network/v20200801:FirewallPolicyRuleCollectionGroup":
		r = &FirewallPolicyRuleCollectionGroup{}
	case "azure-native:network/v20200801:FlowLog":
		r = &FlowLog{}
	case "azure-native:network/v20200801:HubRouteTable":
		r = &HubRouteTable{}
	case "azure-native:network/v20200801:HubVirtualNetworkConnection":
		r = &HubVirtualNetworkConnection{}
	case "azure-native:network/v20200801:InboundNatRule":
		r = &InboundNatRule{}
	case "azure-native:network/v20200801:IpAllocation":
		r = &IpAllocation{}
	case "azure-native:network/v20200801:IpGroup":
		r = &IpGroup{}
	case "azure-native:network/v20200801:LoadBalancer":
		r = &LoadBalancer{}
	case "azure-native:network/v20200801:LoadBalancerBackendAddressPool":
		r = &LoadBalancerBackendAddressPool{}
	case "azure-native:network/v20200801:LocalNetworkGateway":
		r = &LocalNetworkGateway{}
	case "azure-native:network/v20200801:NatGateway":
		r = &NatGateway{}
	case "azure-native:network/v20200801:NatRule":
		r = &NatRule{}
	case "azure-native:network/v20200801:NetworkInterface":
		r = &NetworkInterface{}
	case "azure-native:network/v20200801:NetworkInterfaceTapConfiguration":
		r = &NetworkInterfaceTapConfiguration{}
	case "azure-native:network/v20200801:NetworkProfile":
		r = &NetworkProfile{}
	case "azure-native:network/v20200801:NetworkSecurityGroup":
		r = &NetworkSecurityGroup{}
	case "azure-native:network/v20200801:NetworkVirtualAppliance":
		r = &NetworkVirtualAppliance{}
	case "azure-native:network/v20200801:NetworkWatcher":
		r = &NetworkWatcher{}
	case "azure-native:network/v20200801:P2sVpnGateway":
		r = &P2sVpnGateway{}
	case "azure-native:network/v20200801:PacketCapture":
		r = &PacketCapture{}
	case "azure-native:network/v20200801:PrivateDnsZoneGroup":
		r = &PrivateDnsZoneGroup{}
	case "azure-native:network/v20200801:PrivateEndpoint":
		r = &PrivateEndpoint{}
	case "azure-native:network/v20200801:PrivateLinkService":
		r = &PrivateLinkService{}
	case "azure-native:network/v20200801:PrivateLinkServicePrivateEndpointConnection":
		r = &PrivateLinkServicePrivateEndpointConnection{}
	case "azure-native:network/v20200801:PublicIPAddress":
		r = &PublicIPAddress{}
	case "azure-native:network/v20200801:PublicIPPrefix":
		r = &PublicIPPrefix{}
	case "azure-native:network/v20200801:Route":
		r = &Route{}
	case "azure-native:network/v20200801:RouteFilter":
		r = &RouteFilter{}
	case "azure-native:network/v20200801:RouteFilterRule":
		r = &RouteFilterRule{}
	case "azure-native:network/v20200801:RouteTable":
		r = &RouteTable{}
	case "azure-native:network/v20200801:SecurityPartnerProvider":
		r = &SecurityPartnerProvider{}
	case "azure-native:network/v20200801:SecurityRule":
		r = &SecurityRule{}
	case "azure-native:network/v20200801:ServiceEndpointPolicy":
		r = &ServiceEndpointPolicy{}
	case "azure-native:network/v20200801:ServiceEndpointPolicyDefinition":
		r = &ServiceEndpointPolicyDefinition{}
	case "azure-native:network/v20200801:Subnet":
		r = &Subnet{}
	case "azure-native:network/v20200801:VirtualApplianceSite":
		r = &VirtualApplianceSite{}
	case "azure-native:network/v20200801:VirtualHub":
		r = &VirtualHub{}
	case "azure-native:network/v20200801:VirtualHubBgpConnection":
		r = &VirtualHubBgpConnection{}
	case "azure-native:network/v20200801:VirtualHubIpConfiguration":
		r = &VirtualHubIpConfiguration{}
	case "azure-native:network/v20200801:VirtualHubRouteTableV2":
		r = &VirtualHubRouteTableV2{}
	case "azure-native:network/v20200801:VirtualNetwork":
		r = &VirtualNetwork{}
	case "azure-native:network/v20200801:VirtualNetworkGateway":
		r = &VirtualNetworkGateway{}
	case "azure-native:network/v20200801:VirtualNetworkGatewayConnection":
		r = &VirtualNetworkGatewayConnection{}
	case "azure-native:network/v20200801:VirtualNetworkPeering":
		r = &VirtualNetworkPeering{}
	case "azure-native:network/v20200801:VirtualNetworkTap":
		r = &VirtualNetworkTap{}
	case "azure-native:network/v20200801:VirtualRouter":
		r = &VirtualRouter{}
	case "azure-native:network/v20200801:VirtualRouterPeering":
		r = &VirtualRouterPeering{}
	case "azure-native:network/v20200801:VirtualWan":
		r = &VirtualWan{}
	case "azure-native:network/v20200801:VpnConnection":
		r = &VpnConnection{}
	case "azure-native:network/v20200801:VpnGateway":
		r = &VpnGateway{}
	case "azure-native:network/v20200801:VpnServerConfiguration":
		r = &VpnServerConfiguration{}
	case "azure-native:network/v20200801:VpnSite":
		r = &VpnSite{}
	case "azure-native:network/v20200801:WebApplicationFirewallPolicy":
		r = &WebApplicationFirewallPolicy{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := azure.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"azure-native",
		"network/v20200801",
		&module{version},
	)
}
