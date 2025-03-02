// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A container group.
 */
/** @deprecated Version 2020-11-01 will be removed in v2 of the provider. */
export function getContainerGroup(args: GetContainerGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerGroupResult> {
    pulumi.log.warn("getContainerGroup is deprecated: Version 2020-11-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:containerinstance/v20201101:getContainerGroup", {
        "containerGroupName": args.containerGroupName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetContainerGroupArgs {
    /**
     * The name of the container group.
     */
    containerGroupName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * A container group.
 */
export interface GetContainerGroupResult {
    /**
     * The containers within the container group.
     */
    readonly containers: outputs.containerinstance.v20201101.ContainerResponse[];
    /**
     * The diagnostic information for a container group.
     */
    readonly diagnostics?: outputs.containerinstance.v20201101.ContainerGroupDiagnosticsResponse;
    /**
     * The DNS config information for a container group.
     */
    readonly dnsConfig?: outputs.containerinstance.v20201101.DnsConfigurationResponse;
    /**
     * The encryption properties for a container group.
     */
    readonly encryptionProperties?: outputs.containerinstance.v20201101.EncryptionPropertiesResponse;
    /**
     * The resource id.
     */
    readonly id: string;
    /**
     * The identity of the container group, if configured.
     */
    readonly identity?: outputs.containerinstance.v20201101.ContainerGroupIdentityResponse;
    /**
     * The image registry credentials by which the container group is created from.
     */
    readonly imageRegistryCredentials?: outputs.containerinstance.v20201101.ImageRegistryCredentialResponse[];
    /**
     * The init containers for a container group.
     */
    readonly initContainers?: outputs.containerinstance.v20201101.InitContainerDefinitionResponse[];
    /**
     * The instance view of the container group. Only valid in response.
     */
    readonly instanceView: outputs.containerinstance.v20201101.ContainerGroupResponseInstanceView;
    /**
     * The IP address type of the container group.
     */
    readonly ipAddress?: outputs.containerinstance.v20201101.IpAddressResponse;
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * The network profile information for a container group.
     */
    readonly networkProfile?: outputs.containerinstance.v20201101.ContainerGroupNetworkProfileResponse;
    /**
     * The operating system type required by the containers in the container group.
     */
    readonly osType: string;
    /**
     * The provisioning state of the container group. This only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * Restart policy for all containers within the container group. 
     * - `Always` Always restart
     * - `OnFailure` Restart on failure
     * - `Never` Never restart
     */
    readonly restartPolicy?: string;
    /**
     * The SKU for a container group.
     */
    readonly sku?: string;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type: string;
    /**
     * The list of volumes that can be mounted by containers in this container group.
     */
    readonly volumes?: outputs.containerinstance.v20201101.VolumeResponse[];
}

export function getContainerGroupOutput(args: GetContainerGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetContainerGroupResult> {
    return pulumi.output(args).apply(a => getContainerGroup(a, opts))
}

export interface GetContainerGroupOutputArgs {
    /**
     * The name of the container group.
     */
    containerGroupName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
