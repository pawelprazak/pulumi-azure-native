// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501

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
	case "azure-native:network/v20200501:ApplicationGateway":
		r = &ApplicationGateway{}
	case "azure-native:network/v20200501:ApplicationGatewayPrivateEndpointConnection":
		r = &ApplicationGatewayPrivateEndpointConnection{}
	case "azure-native:network/v20200501:ApplicationSecurityGroup":
		r = &ApplicationSecurityGroup{}
	case "azure-native:network/v20200501:AzureFirewall":
		r = &AzureFirewall{}
	case "azure-native:network/v20200501:BastionHost":
		r = &BastionHost{}
	case "azure-native:network/v20200501:ConnectionMonitor":
		r = &ConnectionMonitor{}
	case "azure-native:network/v20200501:DdosCustomPolicy":
		r = &DdosCustomPolicy{}
	case "azure-native:network/v20200501:DdosProtectionPlan":
		r = &DdosProtectionPlan{}
	case "azure-native:network/v20200501:ExpressRouteCircuit":
		r = &ExpressRouteCircuit{}
	case "azure-native:network/v20200501:ExpressRouteCircuitAuthorization":
		r = &ExpressRouteCircuitAuthorization{}
	case "azure-native:network/v20200501:ExpressRouteCircuitConnection":
		r = &ExpressRouteCircuitConnection{}
	case "azure-native:network/v20200501:ExpressRouteCircuitPeering":
		r = &ExpressRouteCircuitPeering{}
	case "azure-native:network/v20200501:ExpressRouteConnection":
		r = &ExpressRouteConnection{}
	case "azure-native:network/v20200501:ExpressRouteCrossConnectionPeering":
		r = &ExpressRouteCrossConnectionPeering{}
	case "azure-native:network/v20200501:ExpressRouteGateway":
		r = &ExpressRouteGateway{}
	case "azure-native:network/v20200501:ExpressRoutePort":
		r = &ExpressRoutePort{}
	case "azure-native:network/v20200501:FirewallPolicy":
		r = &FirewallPolicy{}
	case "azure-native:network/v20200501:FirewallPolicyRuleCollectionGroup":
		r = &FirewallPolicyRuleCollectionGroup{}
	case "azure-native:network/v20200501:FlowLog":
		r = &FlowLog{}
	case "azure-native:network/v20200501:FrontDoor":
		r = &FrontDoor{}
	case "azure-native:network/v20200501:HubRouteTable":
		r = &HubRouteTable{}
	case "azure-native:network/v20200501:HubVirtualNetworkConnection":
		r = &HubVirtualNetworkConnection{}
	case "azure-native:network/v20200501:InboundNatRule":
		r = &InboundNatRule{}
	case "azure-native:network/v20200501:IpAllocation":
		r = &IpAllocation{}
	case "azure-native:network/v20200501:IpGroup":
		r = &IpGroup{}
	case "azure-native:network/v20200501:LoadBalancer":
		r = &LoadBalancer{}
	case "azure-native:network/v20200501:LoadBalancerBackendAddressPool":
		r = &LoadBalancerBackendAddressPool{}
	case "azure-native:network/v20200501:LocalNetworkGateway":
		r = &LocalNetworkGateway{}
	case "azure-native:network/v20200501:NatGateway":
		r = &NatGateway{}
	case "azure-native:network/v20200501:NetworkInterface":
		r = &NetworkInterface{}
	case "azure-native:network/v20200501:NetworkInterfaceTapConfiguration":
		r = &NetworkInterfaceTapConfiguration{}
	case "azure-native:network/v20200501:NetworkProfile":
		r = &NetworkProfile{}
	case "azure-native:network/v20200501:NetworkSecurityGroup":
		r = &NetworkSecurityGroup{}
	case "azure-native:network/v20200501:NetworkVirtualAppliance":
		r = &NetworkVirtualAppliance{}
	case "azure-native:network/v20200501:NetworkWatcher":
		r = &NetworkWatcher{}
	case "azure-native:network/v20200501:P2sVpnGateway":
		r = &P2sVpnGateway{}
	case "azure-native:network/v20200501:PacketCapture":
		r = &PacketCapture{}
	case "azure-native:network/v20200501:PrivateDnsZoneGroup":
		r = &PrivateDnsZoneGroup{}
	case "azure-native:network/v20200501:PrivateEndpoint":
		r = &PrivateEndpoint{}
	case "azure-native:network/v20200501:PrivateLinkService":
		r = &PrivateLinkService{}
	case "azure-native:network/v20200501:PrivateLinkServicePrivateEndpointConnection":
		r = &PrivateLinkServicePrivateEndpointConnection{}
	case "azure-native:network/v20200501:PublicIPAddress":
		r = &PublicIPAddress{}
	case "azure-native:network/v20200501:PublicIPPrefix":
		r = &PublicIPPrefix{}
	case "azure-native:network/v20200501:Route":
		r = &Route{}
	case "azure-native:network/v20200501:RouteFilter":
		r = &RouteFilter{}
	case "azure-native:network/v20200501:RouteFilterRule":
		r = &RouteFilterRule{}
	case "azure-native:network/v20200501:RouteTable":
		r = &RouteTable{}
	case "azure-native:network/v20200501:RulesEngine":
		r = &RulesEngine{}
	case "azure-native:network/v20200501:SecurityPartnerProvider":
		r = &SecurityPartnerProvider{}
	case "azure-native:network/v20200501:SecurityRule":
		r = &SecurityRule{}
	case "azure-native:network/v20200501:ServiceEndpointPolicy":
		r = &ServiceEndpointPolicy{}
	case "azure-native:network/v20200501:ServiceEndpointPolicyDefinition":
		r = &ServiceEndpointPolicyDefinition{}
	case "azure-native:network/v20200501:Subnet":
		r = &Subnet{}
	case "azure-native:network/v20200501:VirtualApplianceSite":
		r = &VirtualApplianceSite{}
	case "azure-native:network/v20200501:VirtualHub":
		r = &VirtualHub{}
	case "azure-native:network/v20200501:VirtualHubBgpConnection":
		r = &VirtualHubBgpConnection{}
	case "azure-native:network/v20200501:VirtualHubIpConfiguration":
		r = &VirtualHubIpConfiguration{}
	case "azure-native:network/v20200501:VirtualHubRouteTableV2":
		r = &VirtualHubRouteTableV2{}
	case "azure-native:network/v20200501:VirtualNetwork":
		r = &VirtualNetwork{}
	case "azure-native:network/v20200501:VirtualNetworkGateway":
		r = &VirtualNetworkGateway{}
	case "azure-native:network/v20200501:VirtualNetworkGatewayConnection":
		r = &VirtualNetworkGatewayConnection{}
	case "azure-native:network/v20200501:VirtualNetworkPeering":
		r = &VirtualNetworkPeering{}
	case "azure-native:network/v20200501:VirtualNetworkTap":
		r = &VirtualNetworkTap{}
	case "azure-native:network/v20200501:VirtualRouter":
		r = &VirtualRouter{}
	case "azure-native:network/v20200501:VirtualRouterPeering":
		r = &VirtualRouterPeering{}
	case "azure-native:network/v20200501:VirtualWan":
		r = &VirtualWan{}
	case "azure-native:network/v20200501:VpnConnection":
		r = &VpnConnection{}
	case "azure-native:network/v20200501:VpnGateway":
		r = &VpnGateway{}
	case "azure-native:network/v20200501:VpnServerConfiguration":
		r = &VpnServerConfiguration{}
	case "azure-native:network/v20200501:VpnSite":
		r = &VpnSite{}
	case "azure-native:network/v20200501:WebApplicationFirewallPolicy":
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
		"network/v20200501",
		&module{version},
	)
}
