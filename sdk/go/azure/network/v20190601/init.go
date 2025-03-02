// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601

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
	case "azure-native:network/v20190601:ApplicationGateway":
		r = &ApplicationGateway{}
	case "azure-native:network/v20190601:ApplicationSecurityGroup":
		r = &ApplicationSecurityGroup{}
	case "azure-native:network/v20190601:AzureFirewall":
		r = &AzureFirewall{}
	case "azure-native:network/v20190601:BastionHost":
		r = &BastionHost{}
	case "azure-native:network/v20190601:ConnectionMonitor":
		r = &ConnectionMonitor{}
	case "azure-native:network/v20190601:DdosCustomPolicy":
		r = &DdosCustomPolicy{}
	case "azure-native:network/v20190601:DdosProtectionPlan":
		r = &DdosProtectionPlan{}
	case "azure-native:network/v20190601:ExpressRouteCircuit":
		r = &ExpressRouteCircuit{}
	case "azure-native:network/v20190601:ExpressRouteCircuitAuthorization":
		r = &ExpressRouteCircuitAuthorization{}
	case "azure-native:network/v20190601:ExpressRouteCircuitConnection":
		r = &ExpressRouteCircuitConnection{}
	case "azure-native:network/v20190601:ExpressRouteCircuitPeering":
		r = &ExpressRouteCircuitPeering{}
	case "azure-native:network/v20190601:ExpressRouteConnection":
		r = &ExpressRouteConnection{}
	case "azure-native:network/v20190601:ExpressRouteCrossConnectionPeering":
		r = &ExpressRouteCrossConnectionPeering{}
	case "azure-native:network/v20190601:ExpressRouteGateway":
		r = &ExpressRouteGateway{}
	case "azure-native:network/v20190601:ExpressRoutePort":
		r = &ExpressRoutePort{}
	case "azure-native:network/v20190601:FirewallPolicy":
		r = &FirewallPolicy{}
	case "azure-native:network/v20190601:FirewallPolicyRuleGroup":
		r = &FirewallPolicyRuleGroup{}
	case "azure-native:network/v20190601:InboundNatRule":
		r = &InboundNatRule{}
	case "azure-native:network/v20190601:LoadBalancer":
		r = &LoadBalancer{}
	case "azure-native:network/v20190601:LocalNetworkGateway":
		r = &LocalNetworkGateway{}
	case "azure-native:network/v20190601:NatGateway":
		r = &NatGateway{}
	case "azure-native:network/v20190601:NetworkInterface":
		r = &NetworkInterface{}
	case "azure-native:network/v20190601:NetworkInterfaceTapConfiguration":
		r = &NetworkInterfaceTapConfiguration{}
	case "azure-native:network/v20190601:NetworkProfile":
		r = &NetworkProfile{}
	case "azure-native:network/v20190601:NetworkSecurityGroup":
		r = &NetworkSecurityGroup{}
	case "azure-native:network/v20190601:NetworkWatcher":
		r = &NetworkWatcher{}
	case "azure-native:network/v20190601:P2sVpnGateway":
		r = &P2sVpnGateway{}
	case "azure-native:network/v20190601:P2sVpnServerConfiguration":
		r = &P2sVpnServerConfiguration{}
	case "azure-native:network/v20190601:PacketCapture":
		r = &PacketCapture{}
	case "azure-native:network/v20190601:PrivateEndpoint":
		r = &PrivateEndpoint{}
	case "azure-native:network/v20190601:PrivateLinkService":
		r = &PrivateLinkService{}
	case "azure-native:network/v20190601:PublicIPAddress":
		r = &PublicIPAddress{}
	case "azure-native:network/v20190601:PublicIPPrefix":
		r = &PublicIPPrefix{}
	case "azure-native:network/v20190601:Route":
		r = &Route{}
	case "azure-native:network/v20190601:RouteFilter":
		r = &RouteFilter{}
	case "azure-native:network/v20190601:RouteFilterRule":
		r = &RouteFilterRule{}
	case "azure-native:network/v20190601:RouteTable":
		r = &RouteTable{}
	case "azure-native:network/v20190601:SecurityRule":
		r = &SecurityRule{}
	case "azure-native:network/v20190601:ServiceEndpointPolicy":
		r = &ServiceEndpointPolicy{}
	case "azure-native:network/v20190601:ServiceEndpointPolicyDefinition":
		r = &ServiceEndpointPolicyDefinition{}
	case "azure-native:network/v20190601:Subnet":
		r = &Subnet{}
	case "azure-native:network/v20190601:VirtualHub":
		r = &VirtualHub{}
	case "azure-native:network/v20190601:VirtualNetwork":
		r = &VirtualNetwork{}
	case "azure-native:network/v20190601:VirtualNetworkGateway":
		r = &VirtualNetworkGateway{}
	case "azure-native:network/v20190601:VirtualNetworkGatewayConnection":
		r = &VirtualNetworkGatewayConnection{}
	case "azure-native:network/v20190601:VirtualNetworkPeering":
		r = &VirtualNetworkPeering{}
	case "azure-native:network/v20190601:VirtualNetworkTap":
		r = &VirtualNetworkTap{}
	case "azure-native:network/v20190601:VirtualWan":
		r = &VirtualWan{}
	case "azure-native:network/v20190601:VpnConnection":
		r = &VpnConnection{}
	case "azure-native:network/v20190601:VpnGateway":
		r = &VpnGateway{}
	case "azure-native:network/v20190601:VpnSite":
		r = &VpnSite{}
	case "azure-native:network/v20190601:WebApplicationFirewallPolicy":
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
		"network/v20190601",
		&module{version},
	)
}
