// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Peerings in a VirtualNetwork resource
 */
export function getvNetPeering(args: GetvNetPeeringArgs, opts?: pulumi.InvokeOptions): Promise<GetvNetPeeringResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:databricks/v20220401preview:getvNetPeering", {
        "peeringName": args.peeringName,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetvNetPeeringArgs {
    /**
     * The name of the workspace vNet peering.
     */
    peeringName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the workspace.
     */
    workspaceName: string;
}

/**
 * Peerings in a VirtualNetwork resource
 */
export interface GetvNetPeeringResult {
    /**
     * Whether the forwarded traffic from the VMs in the local virtual network will be allowed/disallowed in remote virtual network.
     */
    readonly allowForwardedTraffic?: boolean;
    /**
     * If gateway links can be used in remote virtual networking to link to this virtual network.
     */
    readonly allowGatewayTransit?: boolean;
    /**
     * Whether the VMs in the local virtual network space would be able to access the VMs in remote virtual network space.
     */
    readonly allowVirtualNetworkAccess?: boolean;
    /**
     * The reference to the databricks virtual network address space.
     */
    readonly databricksAddressSpace?: outputs.databricks.v20220401preview.AddressSpaceResponse;
    /**
     *  The remote virtual network should be in the same region. See here to learn more (https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
     */
    readonly databricksVirtualNetwork?: outputs.databricks.v20220401preview.VirtualNetworkPeeringPropertiesFormatResponseDatabricksVirtualNetwork;
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Name of the virtual network peering resource
     */
    readonly name: string;
    /**
     * The status of the virtual network peering.
     */
    readonly peeringState: string;
    /**
     * The provisioning state of the virtual network peering resource.
     */
    readonly provisioningState: string;
    /**
     * The reference to the remote virtual network address space.
     */
    readonly remoteAddressSpace?: outputs.databricks.v20220401preview.AddressSpaceResponse;
    /**
     *  The remote virtual network should be in the same region. See here to learn more (https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
     */
    readonly remoteVirtualNetwork: outputs.databricks.v20220401preview.VirtualNetworkPeeringPropertiesFormatResponseRemoteVirtualNetwork;
    /**
     * type of the virtual network peering resource
     */
    readonly type: string;
    /**
     * If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway.
     */
    readonly useRemoteGateways?: boolean;
}

export function getvNetPeeringOutput(args: GetvNetPeeringOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetvNetPeeringResult> {
    return pulumi.output(args).apply(a => getvNetPeering(a, opts))
}

export interface GetvNetPeeringOutputArgs {
    /**
     * The name of the workspace vNet peering.
     */
    peeringName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the workspace.
     */
    workspaceName: pulumi.Input<string>;
}
