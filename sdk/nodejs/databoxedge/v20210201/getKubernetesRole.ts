// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The limited preview of Kubernetes Cluster Management from the Azure supports:
 * 1. Using a simple turn-key option in Azure Portal, deploy a Kubernetes cluster on your Azure Stack Edge device.
 * 2. Configure Kubernetes cluster running on your device with Arc enabled Kubernetes with a click of a button in the Azure Portal.
 *     Azure Arc enables organizations to view, manage, and govern their on-premises Kubernetes clusters using the Azure Portal, command line tools, and APIs.
 * 3. Easily configure Persistent Volumes using SMB and NFS shares for storing container data.
 *     For more information, refer to the document here: https://databoxupdatepackages.blob.core.windows.net/documentation/Microsoft-Azure-Stack-Edge-K8-Cloud-Management-20210323.pdf
 *     Or Demo: https://databoxupdatepackages.blob.core.windows.net/documentation/Microsoft-Azure-Stack-Edge-K8S-Cloud-Management-20210323.mp4
 *     By using this feature, you agree to the preview legal terms. See the https://azure.microsoft.com/en-us/support/legal/preview-supplemental-terms/
 */
export function getKubernetesRole(args: GetKubernetesRoleArgs, opts?: pulumi.InvokeOptions): Promise<GetKubernetesRoleResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:databoxedge/v20210201:getKubernetesRole", {
        "deviceName": args.deviceName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetKubernetesRoleArgs {
    /**
     * The device name.
     */
    deviceName: string;
    /**
     * The role name.
     */
    name: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
}

/**
 * The limited preview of Kubernetes Cluster Management from the Azure supports:
 * 1. Using a simple turn-key option in Azure Portal, deploy a Kubernetes cluster on your Azure Stack Edge device. 
 * 2. Configure Kubernetes cluster running on your device with Arc enabled Kubernetes with a click of a button in the Azure Portal. 
 *  Azure Arc enables organizations to view, manage, and govern their on-premises Kubernetes clusters using the Azure Portal, command line tools, and APIs.
 * 3. Easily configure Persistent Volumes using SMB and NFS shares for storing container data. 
 *  For more information, refer to the document here: https://databoxupdatepackages.blob.core.windows.net/documentation/Microsoft-Azure-Stack-Edge-K8-Cloud-Management-20210323.pdf 
 *  Or Demo: https://databoxupdatepackages.blob.core.windows.net/documentation/Microsoft-Azure-Stack-Edge-K8S-Cloud-Management-20210323.mp4
 *  By using this feature, you agree to the preview legal terms. See the https://azure.microsoft.com/en-us/support/legal/preview-supplemental-terms/
 */
export interface GetKubernetesRoleResult {
    /**
     * Host OS supported by the Kubernetes role.
     */
    readonly hostPlatform: string;
    /**
     * Platform where the runtime is hosted.
     */
    readonly hostPlatformType: string;
    /**
     * The path ID that uniquely identifies the object.
     */
    readonly id: string;
    /**
     * Role type.
     * Expected value is 'Kubernetes'.
     */
    readonly kind: "Kubernetes";
    /**
     * Kubernetes cluster configuration
     */
    readonly kubernetesClusterInfo: outputs.databoxedge.v20210201.KubernetesClusterInfoResponse;
    /**
     * Kubernetes role resources
     */
    readonly kubernetesRoleResources: outputs.databoxedge.v20210201.KubernetesRoleResourcesResponse;
    /**
     * The object name.
     */
    readonly name: string;
    /**
     * State of Kubernetes deployment
     */
    readonly provisioningState: string;
    /**
     * Role status.
     */
    readonly roleStatus: string;
    /**
     * Role configured on ASE resource
     */
    readonly systemData: outputs.databoxedge.v20210201.SystemDataResponse;
    /**
     * The hierarchical type of the object.
     */
    readonly type: string;
}

export function getKubernetesRoleOutput(args: GetKubernetesRoleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKubernetesRoleResult> {
    return pulumi.output(args).apply(a => getKubernetesRole(a, opts))
}

export interface GetKubernetesRoleOutputArgs {
    /**
     * The device name.
     */
    deviceName: pulumi.Input<string>;
    /**
     * The role name.
     */
    name: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
