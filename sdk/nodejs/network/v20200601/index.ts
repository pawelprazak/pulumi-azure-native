// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./applicationGateway";
export * from "./applicationGatewayPrivateEndpointConnection";
export * from "./applicationSecurityGroup";
export * from "./azureFirewall";
export * from "./bastionHost";
export * from "./connectionMonitor";
export * from "./customIPPrefix";
export * from "./ddosCustomPolicy";
export * from "./ddosProtectionPlan";
export * from "./dscpConfiguration";
export * from "./expressRouteCircuit";
export * from "./expressRouteCircuitAuthorization";
export * from "./expressRouteCircuitConnection";
export * from "./expressRouteCircuitPeering";
export * from "./expressRouteConnection";
export * from "./expressRouteCrossConnectionPeering";
export * from "./expressRouteGateway";
export * from "./expressRoutePort";
export * from "./firewallPolicy";
export * from "./firewallPolicyRuleCollectionGroup";
export * from "./flowLog";
export * from "./getActiveSessions";
export * from "./getApplicationGateway";
export * from "./getApplicationGatewayBackendHealthOnDemand";
export * from "./getApplicationGatewayPrivateEndpointConnection";
export * from "./getApplicationSecurityGroup";
export * from "./getAzureFirewall";
export * from "./getBastionHost";
export * from "./getBastionShareableLink";
export * from "./getConnectionMonitor";
export * from "./getCustomIPPrefix";
export * from "./getDdosCustomPolicy";
export * from "./getDdosProtectionPlan";
export * from "./getDscpConfiguration";
export * from "./getExpressRouteCircuit";
export * from "./getExpressRouteCircuitAuthorization";
export * from "./getExpressRouteCircuitConnection";
export * from "./getExpressRouteCircuitPeering";
export * from "./getExpressRouteConnection";
export * from "./getExpressRouteCrossConnectionPeering";
export * from "./getExpressRouteGateway";
export * from "./getExpressRoutePort";
export * from "./getFirewallPolicy";
export * from "./getFirewallPolicyRuleCollectionGroup";
export * from "./getFlowLog";
export * from "./getHubRouteTable";
export * from "./getHubVirtualNetworkConnection";
export * from "./getInboundNatRule";
export * from "./getIpAllocation";
export * from "./getIpGroup";
export * from "./getLoadBalancer";
export * from "./getLoadBalancerBackendAddressPool";
export * from "./getLocalNetworkGateway";
export * from "./getNatGateway";
export * from "./getNetworkInterface";
export * from "./getNetworkInterfaceTapConfiguration";
export * from "./getNetworkProfile";
export * from "./getNetworkSecurityGroup";
export * from "./getNetworkVirtualAppliance";
export * from "./getNetworkWatcher";
export * from "./getP2sVpnGateway";
export * from "./getP2sVpnGatewayP2sVpnConnectionHealth";
export * from "./getP2sVpnGatewayP2sVpnConnectionHealthDetailed";
export * from "./getPacketCapture";
export * from "./getPrivateDnsZoneGroup";
export * from "./getPrivateEndpoint";
export * from "./getPrivateLinkService";
export * from "./getPrivateLinkServicePrivateEndpointConnection";
export * from "./getPrivateRecordSet";
export * from "./getPrivateZone";
export * from "./getPublicIPAddress";
export * from "./getPublicIPPrefix";
export * from "./getRoute";
export * from "./getRouteFilter";
export * from "./getRouteFilterRule";
export * from "./getRouteTable";
export * from "./getSecurityPartnerProvider";
export * from "./getSecurityRule";
export * from "./getServiceEndpointPolicy";
export * from "./getServiceEndpointPolicyDefinition";
export * from "./getSubnet";
export * from "./getVirtualApplianceSite";
export * from "./getVirtualHub";
export * from "./getVirtualHubBgpConnection";
export * from "./getVirtualHubIpConfiguration";
export * from "./getVirtualHubRouteTableV2";
export * from "./getVirtualNetwork";
export * from "./getVirtualNetworkGateway";
export * from "./getVirtualNetworkGatewayAdvertisedRoutes";
export * from "./getVirtualNetworkGatewayBgpPeerStatus";
export * from "./getVirtualNetworkGatewayConnection";
export * from "./getVirtualNetworkGatewayLearnedRoutes";
export * from "./getVirtualNetworkGatewayVpnclientConnectionHealth";
export * from "./getVirtualNetworkGatewayVpnclientIpsecParameters";
export * from "./getVirtualNetworkLink";
export * from "./getVirtualNetworkPeering";
export * from "./getVirtualNetworkTap";
export * from "./getVirtualRouter";
export * from "./getVirtualRouterPeering";
export * from "./getVirtualWan";
export * from "./getVpnConnection";
export * from "./getVpnGateway";
export * from "./getVpnServerConfiguration";
export * from "./getVpnSite";
export * from "./getWebApplicationFirewallPolicy";
export * from "./hubRouteTable";
export * from "./hubVirtualNetworkConnection";
export * from "./inboundNatRule";
export * from "./ipAllocation";
export * from "./ipGroup";
export * from "./loadBalancer";
export * from "./loadBalancerBackendAddressPool";
export * from "./localNetworkGateway";
export * from "./natGateway";
export * from "./networkInterface";
export * from "./networkInterfaceTapConfiguration";
export * from "./networkProfile";
export * from "./networkSecurityGroup";
export * from "./networkVirtualAppliance";
export * from "./networkWatcher";
export * from "./p2sVpnGateway";
export * from "./packetCapture";
export * from "./privateDnsZoneGroup";
export * from "./privateEndpoint";
export * from "./privateLinkService";
export * from "./privateLinkServicePrivateEndpointConnection";
export * from "./privateRecordSet";
export * from "./privateZone";
export * from "./publicIPAddress";
export * from "./publicIPPrefix";
export * from "./route";
export * from "./routeFilter";
export * from "./routeFilterRule";
export * from "./routeTable";
export * from "./securityPartnerProvider";
export * from "./securityRule";
export * from "./serviceEndpointPolicy";
export * from "./serviceEndpointPolicyDefinition";
export * from "./subnet";
export * from "./virtualApplianceSite";
export * from "./virtualHub";
export * from "./virtualHubBgpConnection";
export * from "./virtualHubIpConfiguration";
export * from "./virtualHubRouteTableV2";
export * from "./virtualNetwork";
export * from "./virtualNetworkGateway";
export * from "./virtualNetworkGatewayConnection";
export * from "./virtualNetworkLink";
export * from "./virtualNetworkPeering";
export * from "./virtualNetworkTap";
export * from "./virtualRouter";
export * from "./virtualRouterPeering";
export * from "./virtualWan";
export * from "./vpnConnection";
export * from "./vpnGateway";
export * from "./vpnServerConfiguration";
export * from "./vpnSite";
export * from "./webApplicationFirewallPolicy";

// Export enums:
export * from "../../types/enums/network/v20200601";

// Import resources to register:
import { ApplicationGateway } from "./applicationGateway";
import { ApplicationGatewayPrivateEndpointConnection } from "./applicationGatewayPrivateEndpointConnection";
import { ApplicationSecurityGroup } from "./applicationSecurityGroup";
import { AzureFirewall } from "./azureFirewall";
import { BastionHost } from "./bastionHost";
import { ConnectionMonitor } from "./connectionMonitor";
import { CustomIPPrefix } from "./customIPPrefix";
import { DdosCustomPolicy } from "./ddosCustomPolicy";
import { DdosProtectionPlan } from "./ddosProtectionPlan";
import { DscpConfiguration } from "./dscpConfiguration";
import { ExpressRouteCircuit } from "./expressRouteCircuit";
import { ExpressRouteCircuitAuthorization } from "./expressRouteCircuitAuthorization";
import { ExpressRouteCircuitConnection } from "./expressRouteCircuitConnection";
import { ExpressRouteCircuitPeering } from "./expressRouteCircuitPeering";
import { ExpressRouteConnection } from "./expressRouteConnection";
import { ExpressRouteCrossConnectionPeering } from "./expressRouteCrossConnectionPeering";
import { ExpressRouteGateway } from "./expressRouteGateway";
import { ExpressRoutePort } from "./expressRoutePort";
import { FirewallPolicy } from "./firewallPolicy";
import { FirewallPolicyRuleCollectionGroup } from "./firewallPolicyRuleCollectionGroup";
import { FlowLog } from "./flowLog";
import { HubRouteTable } from "./hubRouteTable";
import { HubVirtualNetworkConnection } from "./hubVirtualNetworkConnection";
import { InboundNatRule } from "./inboundNatRule";
import { IpAllocation } from "./ipAllocation";
import { IpGroup } from "./ipGroup";
import { LoadBalancer } from "./loadBalancer";
import { LoadBalancerBackendAddressPool } from "./loadBalancerBackendAddressPool";
import { LocalNetworkGateway } from "./localNetworkGateway";
import { NatGateway } from "./natGateway";
import { NetworkInterface } from "./networkInterface";
import { NetworkInterfaceTapConfiguration } from "./networkInterfaceTapConfiguration";
import { NetworkProfile } from "./networkProfile";
import { NetworkSecurityGroup } from "./networkSecurityGroup";
import { NetworkVirtualAppliance } from "./networkVirtualAppliance";
import { NetworkWatcher } from "./networkWatcher";
import { P2sVpnGateway } from "./p2sVpnGateway";
import { PacketCapture } from "./packetCapture";
import { PrivateDnsZoneGroup } from "./privateDnsZoneGroup";
import { PrivateEndpoint } from "./privateEndpoint";
import { PrivateLinkService } from "./privateLinkService";
import { PrivateLinkServicePrivateEndpointConnection } from "./privateLinkServicePrivateEndpointConnection";
import { PrivateRecordSet } from "./privateRecordSet";
import { PrivateZone } from "./privateZone";
import { PublicIPAddress } from "./publicIPAddress";
import { PublicIPPrefix } from "./publicIPPrefix";
import { Route } from "./route";
import { RouteFilter } from "./routeFilter";
import { RouteFilterRule } from "./routeFilterRule";
import { RouteTable } from "./routeTable";
import { SecurityPartnerProvider } from "./securityPartnerProvider";
import { SecurityRule } from "./securityRule";
import { ServiceEndpointPolicy } from "./serviceEndpointPolicy";
import { ServiceEndpointPolicyDefinition } from "./serviceEndpointPolicyDefinition";
import { Subnet } from "./subnet";
import { VirtualApplianceSite } from "./virtualApplianceSite";
import { VirtualHub } from "./virtualHub";
import { VirtualHubBgpConnection } from "./virtualHubBgpConnection";
import { VirtualHubIpConfiguration } from "./virtualHubIpConfiguration";
import { VirtualHubRouteTableV2 } from "./virtualHubRouteTableV2";
import { VirtualNetwork } from "./virtualNetwork";
import { VirtualNetworkGateway } from "./virtualNetworkGateway";
import { VirtualNetworkGatewayConnection } from "./virtualNetworkGatewayConnection";
import { VirtualNetworkLink } from "./virtualNetworkLink";
import { VirtualNetworkPeering } from "./virtualNetworkPeering";
import { VirtualNetworkTap } from "./virtualNetworkTap";
import { VirtualRouter } from "./virtualRouter";
import { VirtualRouterPeering } from "./virtualRouterPeering";
import { VirtualWan } from "./virtualWan";
import { VpnConnection } from "./vpnConnection";
import { VpnGateway } from "./vpnGateway";
import { VpnServerConfiguration } from "./vpnServerConfiguration";
import { VpnSite } from "./vpnSite";
import { WebApplicationFirewallPolicy } from "./webApplicationFirewallPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:network/v20200601:ApplicationGateway":
                return new ApplicationGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ApplicationGatewayPrivateEndpointConnection":
                return new ApplicationGatewayPrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ApplicationSecurityGroup":
                return new ApplicationSecurityGroup(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:AzureFirewall":
                return new AzureFirewall(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:BastionHost":
                return new BastionHost(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ConnectionMonitor":
                return new ConnectionMonitor(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:CustomIPPrefix":
                return new CustomIPPrefix(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:DdosCustomPolicy":
                return new DdosCustomPolicy(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:DdosProtectionPlan":
                return new DdosProtectionPlan(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:DscpConfiguration":
                return new DscpConfiguration(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRouteCircuit":
                return new ExpressRouteCircuit(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRouteCircuitAuthorization":
                return new ExpressRouteCircuitAuthorization(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRouteCircuitConnection":
                return new ExpressRouteCircuitConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRouteCircuitPeering":
                return new ExpressRouteCircuitPeering(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRouteConnection":
                return new ExpressRouteConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRouteCrossConnectionPeering":
                return new ExpressRouteCrossConnectionPeering(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRouteGateway":
                return new ExpressRouteGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ExpressRoutePort":
                return new ExpressRoutePort(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:FirewallPolicy":
                return new FirewallPolicy(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:FirewallPolicyRuleCollectionGroup":
                return new FirewallPolicyRuleCollectionGroup(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:FlowLog":
                return new FlowLog(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:HubRouteTable":
                return new HubRouteTable(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:HubVirtualNetworkConnection":
                return new HubVirtualNetworkConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:InboundNatRule":
                return new InboundNatRule(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:IpAllocation":
                return new IpAllocation(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:IpGroup":
                return new IpGroup(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:LoadBalancer":
                return new LoadBalancer(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:LoadBalancerBackendAddressPool":
                return new LoadBalancerBackendAddressPool(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:LocalNetworkGateway":
                return new LocalNetworkGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:NatGateway":
                return new NatGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:NetworkInterface":
                return new NetworkInterface(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:NetworkInterfaceTapConfiguration":
                return new NetworkInterfaceTapConfiguration(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:NetworkProfile":
                return new NetworkProfile(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:NetworkSecurityGroup":
                return new NetworkSecurityGroup(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:NetworkVirtualAppliance":
                return new NetworkVirtualAppliance(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:NetworkWatcher":
                return new NetworkWatcher(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:P2sVpnGateway":
                return new P2sVpnGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PacketCapture":
                return new PacketCapture(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PrivateDnsZoneGroup":
                return new PrivateDnsZoneGroup(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PrivateEndpoint":
                return new PrivateEndpoint(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PrivateLinkService":
                return new PrivateLinkService(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PrivateLinkServicePrivateEndpointConnection":
                return new PrivateLinkServicePrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PrivateRecordSet":
                return new PrivateRecordSet(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PrivateZone":
                return new PrivateZone(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PublicIPAddress":
                return new PublicIPAddress(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:PublicIPPrefix":
                return new PublicIPPrefix(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:Route":
                return new Route(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:RouteFilter":
                return new RouteFilter(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:RouteFilterRule":
                return new RouteFilterRule(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:RouteTable":
                return new RouteTable(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:SecurityPartnerProvider":
                return new SecurityPartnerProvider(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:SecurityRule":
                return new SecurityRule(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ServiceEndpointPolicy":
                return new ServiceEndpointPolicy(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:ServiceEndpointPolicyDefinition":
                return new ServiceEndpointPolicyDefinition(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:Subnet":
                return new Subnet(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualApplianceSite":
                return new VirtualApplianceSite(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualHub":
                return new VirtualHub(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualHubBgpConnection":
                return new VirtualHubBgpConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualHubIpConfiguration":
                return new VirtualHubIpConfiguration(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualHubRouteTableV2":
                return new VirtualHubRouteTableV2(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualNetwork":
                return new VirtualNetwork(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualNetworkGateway":
                return new VirtualNetworkGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualNetworkGatewayConnection":
                return new VirtualNetworkGatewayConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualNetworkLink":
                return new VirtualNetworkLink(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualNetworkPeering":
                return new VirtualNetworkPeering(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualNetworkTap":
                return new VirtualNetworkTap(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualRouter":
                return new VirtualRouter(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualRouterPeering":
                return new VirtualRouterPeering(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VirtualWan":
                return new VirtualWan(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VpnConnection":
                return new VpnConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VpnGateway":
                return new VpnGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VpnServerConfiguration":
                return new VpnServerConfiguration(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:VpnSite":
                return new VpnSite(name, <any>undefined, { urn })
            case "azure-native:network/v20200601:WebApplicationFirewallPolicy":
                return new WebApplicationFirewallPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "network/v20200601", _module)
