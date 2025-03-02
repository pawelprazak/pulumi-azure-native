// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./applicationGateway";
export * from "./expressRouteCircuit";
export * from "./expressRouteCircuitAuthorization";
export * from "./expressRouteCircuitPeering";
export * from "./getApplicationGateway";
export * from "./getExpressRouteCircuit";
export * from "./getExpressRouteCircuitAuthorization";
export * from "./getExpressRouteCircuitPeering";
export * from "./getLoadBalancer";
export * from "./getLocalNetworkGateway";
export * from "./getNetworkInterface";
export * from "./getNetworkSecurityGroup";
export * from "./getNetworkWatcher";
export * from "./getPacketCapture";
export * from "./getPublicIPAddress";
export * from "./getRoute";
export * from "./getRouteTable";
export * from "./getSecurityRule";
export * from "./getSubnet";
export * from "./getVirtualNetwork";
export * from "./getVirtualNetworkGateway";
export * from "./getVirtualNetworkGatewayAdvertisedRoutes";
export * from "./getVirtualNetworkGatewayBgpPeerStatus";
export * from "./getVirtualNetworkGatewayConnection";
export * from "./getVirtualNetworkGatewayLearnedRoutes";
export * from "./getVirtualNetworkPeering";
export * from "./loadBalancer";
export * from "./localNetworkGateway";
export * from "./networkInterface";
export * from "./networkSecurityGroup";
export * from "./networkWatcher";
export * from "./packetCapture";
export * from "./publicIPAddress";
export * from "./route";
export * from "./routeTable";
export * from "./securityRule";
export * from "./subnet";
export * from "./virtualNetwork";
export * from "./virtualNetworkGateway";
export * from "./virtualNetworkGatewayConnection";
export * from "./virtualNetworkPeering";

// Export enums:
export * from "../../types/enums/network/v20160901";

// Import resources to register:
import { ApplicationGateway } from "./applicationGateway";
import { ExpressRouteCircuit } from "./expressRouteCircuit";
import { ExpressRouteCircuitAuthorization } from "./expressRouteCircuitAuthorization";
import { ExpressRouteCircuitPeering } from "./expressRouteCircuitPeering";
import { LoadBalancer } from "./loadBalancer";
import { LocalNetworkGateway } from "./localNetworkGateway";
import { NetworkInterface } from "./networkInterface";
import { NetworkSecurityGroup } from "./networkSecurityGroup";
import { NetworkWatcher } from "./networkWatcher";
import { PacketCapture } from "./packetCapture";
import { PublicIPAddress } from "./publicIPAddress";
import { Route } from "./route";
import { RouteTable } from "./routeTable";
import { SecurityRule } from "./securityRule";
import { Subnet } from "./subnet";
import { VirtualNetwork } from "./virtualNetwork";
import { VirtualNetworkGateway } from "./virtualNetworkGateway";
import { VirtualNetworkGatewayConnection } from "./virtualNetworkGatewayConnection";
import { VirtualNetworkPeering } from "./virtualNetworkPeering";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:network/v20160901:ApplicationGateway":
                return new ApplicationGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:ExpressRouteCircuit":
                return new ExpressRouteCircuit(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:ExpressRouteCircuitAuthorization":
                return new ExpressRouteCircuitAuthorization(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:ExpressRouteCircuitPeering":
                return new ExpressRouteCircuitPeering(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:LoadBalancer":
                return new LoadBalancer(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:LocalNetworkGateway":
                return new LocalNetworkGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:NetworkInterface":
                return new NetworkInterface(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:NetworkSecurityGroup":
                return new NetworkSecurityGroup(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:NetworkWatcher":
                return new NetworkWatcher(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:PacketCapture":
                return new PacketCapture(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:PublicIPAddress":
                return new PublicIPAddress(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:Route":
                return new Route(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:RouteTable":
                return new RouteTable(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:SecurityRule":
                return new SecurityRule(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:Subnet":
                return new Subnet(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:VirtualNetwork":
                return new VirtualNetwork(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:VirtualNetworkGateway":
                return new VirtualNetworkGateway(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:VirtualNetworkGatewayConnection":
                return new VirtualNetworkGatewayConnection(name, <any>undefined, { urn })
            case "azure-native:network/v20160901:VirtualNetworkPeering":
                return new VirtualNetworkPeering(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "network/v20160901", _module)
