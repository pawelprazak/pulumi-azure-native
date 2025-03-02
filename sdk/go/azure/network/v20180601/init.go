// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601

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
	case "azure-native:network/v20180601:ApplicationGateway":
		r = &ApplicationGateway{}
	case "azure-native:network/v20180601:ApplicationSecurityGroup":
		r = &ApplicationSecurityGroup{}
	case "azure-native:network/v20180601:AzureFirewall":
		r = &AzureFirewall{}
	case "azure-native:network/v20180601:ConnectionMonitor":
		r = &ConnectionMonitor{}
	case "azure-native:network/v20180601:DdosProtectionPlan":
		r = &DdosProtectionPlan{}
	case "azure-native:network/v20180601:ExpressRouteCircuit":
		r = &ExpressRouteCircuit{}
	case "azure-native:network/v20180601:ExpressRouteCircuitAuthorization":
		r = &ExpressRouteCircuitAuthorization{}
	case "azure-native:network/v20180601:ExpressRouteCircuitConnection":
		r = &ExpressRouteCircuitConnection{}
	case "azure-native:network/v20180601:ExpressRouteCircuitPeering":
		r = &ExpressRouteCircuitPeering{}
	case "azure-native:network/v20180601:ExpressRouteCrossConnectionPeering":
		r = &ExpressRouteCrossConnectionPeering{}
	case "azure-native:network/v20180601:InboundNatRule":
		r = &InboundNatRule{}
	case "azure-native:network/v20180601:LoadBalancer":
		r = &LoadBalancer{}
	case "azure-native:network/v20180601:LocalNetworkGateway":
		r = &LocalNetworkGateway{}
	case "azure-native:network/v20180601:NetworkInterface":
		r = &NetworkInterface{}
	case "azure-native:network/v20180601:NetworkSecurityGroup":
		r = &NetworkSecurityGroup{}
	case "azure-native:network/v20180601:NetworkWatcher":
		r = &NetworkWatcher{}
	case "azure-native:network/v20180601:PacketCapture":
		r = &PacketCapture{}
	case "azure-native:network/v20180601:PublicIPAddress":
		r = &PublicIPAddress{}
	case "azure-native:network/v20180601:Route":
		r = &Route{}
	case "azure-native:network/v20180601:RouteFilter":
		r = &RouteFilter{}
	case "azure-native:network/v20180601:RouteFilterRule":
		r = &RouteFilterRule{}
	case "azure-native:network/v20180601:RouteTable":
		r = &RouteTable{}
	case "azure-native:network/v20180601:SecurityRule":
		r = &SecurityRule{}
	case "azure-native:network/v20180601:Subnet":
		r = &Subnet{}
	case "azure-native:network/v20180601:VirtualHub":
		r = &VirtualHub{}
	case "azure-native:network/v20180601:VirtualNetwork":
		r = &VirtualNetwork{}
	case "azure-native:network/v20180601:VirtualNetworkGateway":
		r = &VirtualNetworkGateway{}
	case "azure-native:network/v20180601:VirtualNetworkGatewayConnection":
		r = &VirtualNetworkGatewayConnection{}
	case "azure-native:network/v20180601:VirtualNetworkPeering":
		r = &VirtualNetworkPeering{}
	case "azure-native:network/v20180601:VirtualWAN":
		r = &VirtualWAN{}
	case "azure-native:network/v20180601:VpnConnection":
		r = &VpnConnection{}
	case "azure-native:network/v20180601:VpnGateway":
		r = &VpnGateway{}
	case "azure-native:network/v20180601:VpnSite":
		r = &VpnSite{}
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
		"network/v20180601",
		&module{version},
	)
}
